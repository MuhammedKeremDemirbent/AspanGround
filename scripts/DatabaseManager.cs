using System;
using System.Data;
using Npgsql;
using System.IO;
using System.Windows.Forms;

namespace AspanGround_2
{
    public class DatabaseManager
    {
        private string connectionString;

        public DatabaseManager()
        {
            // PostgreSQL bağlantı bilgileri
            // Not: Şifre kısmını pgAdmin'de belirlediğiniz şifre ile değiştirin.
            connectionString = "Host=localhost;Port=5432;Database=aspanground;Username=postgres;Password=Beyazpano123";

            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Tabloları oluşturma varsa atlar
                    string createSessionsTable = @"
                        CREATE TABLE IF NOT EXISTS FlightSessions (
                            Id SERIAL PRIMARY KEY,
                            FlightDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                            Note TEXT
                        );";

                    string createTelemetryTable = @"
                        CREATE TABLE IF NOT EXISTS TelemetryData (
                            Id SERIAL PRIMARY KEY,
                            FlightId INT REFERENCES FlightSessions(Id),
                            Timestamp TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                            Roll FLOAT,
                            Pitch FLOAT,
                            Yaw FLOAT,
                            Altitude FLOAT,
                            RH FLOAT,
                            RV FLOAT,
                            LH FLOAT
                        );";

                    string createGpsTable = @"
                        CREATE TABLE IF NOT EXISTS GpsData (
                            Id SERIAL PRIMARY KEY,
                            FlightId INT REFERENCES FlightSessions(Id),
                            Timestamp TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                            Latitude DOUBLE PRECISION,
                            Longitude DOUBLE PRECISION
                        );";

                    using (var command = new NpgsqlCommand(createSessionsTable, connection))
                    {
                        command.ExecuteNonQuery();
                        command.CommandText = createTelemetryTable;
                        command.ExecuteNonQuery();
                        command.CommandText = createGpsTable;
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PostgreSQL Bağlantı Hatası: " + ex.Message + "\n\nLütfen connectionString içindeki şifreyi kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public long StartNewSession(string notes = "")
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO FlightSessions (Note) VALUES (@notes) RETURNING Id;";
                    using (var command = new NpgsqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@notes", notes);
                        return Convert.ToInt64(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oturum başlatma hatası: " + ex.Message);
                return -1;
            }
        }

        public void SaveTelemetry(TelemetryData data, long sessionId)
        {
            if (sessionId <= 0) return;
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = @"
                        INSERT INTO TelemetryData (FlightId, Roll, Pitch, Yaw, Altitude, RH, RV, LH) 
                        VALUES (@sid, @roll, @pitch, @yaw, @alt, @rh, @rv, @lh)";

                    using (var command = new NpgsqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@sid", (int)sessionId);
                        command.Parameters.AddWithValue("@roll", (double)data.Roll);
                        command.Parameters.AddWithValue("@pitch", (double)data.Pitch);
                        command.Parameters.AddWithValue("@yaw", (double)data.Yaw);
                        command.Parameters.AddWithValue("@alt", (double)data.Altitude);
                        command.Parameters.AddWithValue("@rh", (double)data.RH);
                        command.Parameters.AddWithValue("@rv", (double)data.RV);
                        command.Parameters.AddWithValue("@lh", (double)data.LH);
                        
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[SQL HATA] Telemetry kaydı başarısız! Mesaj: {ex.Message}");
            }
        }

        public void SaveGps(GpsData data, long sessionId)
        {
            if (sessionId <= 0)
            {
                Console.WriteLine($"[SQL HATA] GPS kaydı başarısız! Geçersiz sessionId: {sessionId}");
                return;
            }
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO GpsData (FlightId, Latitude, Longitude) VALUES (@sid, @lat, @lon)";

                    using (var command = new NpgsqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@sid", (int)sessionId);
                        command.Parameters.AddWithValue("@lat", (double)data.Latitude);
                        command.Parameters.AddWithValue("@lon", (double)data.Longitude);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[SQL HATA] GPS kaydı başarısız! Mesaj: {ex.Message}");
            }
        }

        // --- Veri Okuma Metotları ---

        public DataTable GetAllSessions()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Id, FlightDate, Note FROM FlightSessions ORDER BY FlightDate DESC";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        using (var adapter = new NpgsqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oturum listesi getirme hatası: " + ex.Message);
            }
            return dt;
        }

        public DataTable GetTelemetryData(long sessionId)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Timestamp, Roll, Pitch, Yaw, Altitude FROM TelemetryData WHERE FlightId = @sid ORDER BY Timestamp";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@sid", (int)sessionId);
                        using (var adapter = new NpgsqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Telemetri verisi getirme hatası: " + ex.Message);
            }
            return dt;
        }
    }
}
