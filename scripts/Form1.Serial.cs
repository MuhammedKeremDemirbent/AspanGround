using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using System.Text;
using System.Drawing;

namespace AspanGround_2
{
    public enum PacketType : byte
    {
        Telemetry = 0x10,
        Gps = 0x11,
        ModelInfo = 0x12,
        PidRead = 0x20,
        PidWrite = 0x21,
        PidReply = 0x22
    }

    public partial class AspanGround
    {
        #region SerialPort
        private void ButtonConnect_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(ComboBoxBaudRates.Text) || string.IsNullOrEmpty(ComboBoxPorts.Text))
                {
                    MessageBox.Show("Lütfen port ayarlarını seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (serialPort != null)
                {
                    serialPort.DataReceived -= serialPort_DataReceived;
                    if (serialPort.IsOpen)
                        serialPort.Close();
                        serialPort.Dispose();
                        //timerGraphic.Start();
                        timerGauge.Start();
                        timerRCControls.Start();
                    labelNoConnection.Visible = false;
                }

                serialPort = new SerialPort(ComboBoxPorts.Text, Convert.ToInt32(ComboBoxBaudRates.Text));
                serialPort.WriteTimeout = 5000;
                serialPort.DataReceived += serialPort_DataReceived;
                serialPort.Open();

                ButtonConnect.Enabled = false;
                ButtonDisconnect.Enabled = true;
                pictureBoxGreen.Visible = true;
                pictureBoxGrey.Visible = false;
                labelNoConnection.Visible = false;
                labelConnected.Visible = true;

                // Yeni uçuş oturumu başlat
                currentSessionId = dbManager.StartNewSession("Otomatik Bağlantı");

                isSqlLogging = true; // Bağlantı kurulduğunda SQL kaydı başlar
                timerSQL.Start();    // SQL Zamanlayıcısını başlat

            }
            catch (Exception ex)
            {
                MessageBox.Show("Seri port açılırken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseConnection()
        {
            Console.WriteLine("[DEBUG] CloseConnection çağrıldı.");
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(CloseConnection));
                return;
            }

            watchdogTimer.Stop();

            if (serialPort != null)
            {
               
                if (serialPort.IsOpen)
                {
                    serialPort.DataReceived -= serialPort_DataReceived;
                    try { serialPort.Close(); } catch { }
                }
                serialPort.Dispose();
                serialPort = null;
            }

        
            timerGraphic.Stop();
            timerGauge.Stop(); 
            logWriter?.Close();
            isSqlLogging = false; // Bağlantı koptuğunda SQL kaydı durur
            timerSQL.Stop();      // SQL Zamanlayıcısını durdur
            currentSessionId = 0; // Oturumu sıfırla

            currentRoll = 0;
            currentPitch = 0;
            currentYaw = 0;
            currentAltitude = 0;
            
            attitudeIndicatorInstrumentControl1.SetAttitudeIndicatorParameters(0, 0); 
            headingIndicatorInstrumentControl1.SetHeadingIndicatorParameters(0);      

            attitudeIndicatorInstrumentControl1.Invalidate(); 
            headingIndicatorInstrumentControl1.Invalidate();

            ButtonDisconnect.Enabled = false;
            ButtonConnect.Enabled = true;
            pictureBoxGreen.Visible = false;
            pictureBoxGrey.Visible = true;
            labelNoConnection.Visible = true;
            labelConnected.Visible = false;

            radioNone.Checked = true;
            ButtonStartLog.Text = "Start Log";

            labelAltitude.Text = "0";
            labelLatitude.Text = "0";
            labelLongitude.Text = "0";
            labelRoll.Text = "0";
            labelPitch.Text = "0";
            labelYaw.Text = "0";
            labelRH.Text = "0";
            labelLH.Text = "0";
            labelRV.Text = "0";
            labelRollSetpoint.Text = "0";
            labelPitchSetpoint.Text = "0";
            labelYawSetpoint.Text = "0";
        }
        private void ButtonDisconnect_Click_1(object sender, EventArgs e)
        {
           CloseConnection();
        }
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort == null || !serialPort.IsOpen)
                return;

            try
            {
                int bytesToRead = serialPort.BytesToRead;
                byte[] tempBuffer = new byte[bytesToRead];
                serialPort.Read(tempBuffer, 0, bytesToRead);

                buffer.AddRange(tempBuffer);

                while (buffer.Count >= 20)
                {
                    if (buffer[0] == 0x46 && buffer[1] == 0x43)
                    {
                        byte[] packet = buffer.GetRange(0, 20).ToArray();
                        buffer.RemoveRange(0, 20);

                        ProcessValidatedPacket(packet);
                    }
                    else
                    {
                        buffer.RemoveAt(0);
                    }
                }
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() =>
                {
                    MessageBox.Show("Veri alınırken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
            }
        }

        private void ProcessValidatedPacket(byte[] packet)
        {
            // Checksum doğrulaması
            byte checksum = 0xFF;
            for (int i = 0; i < 19; i++)
                checksum -= packet[i];

            if (packet[19] != checksum) return;

            byte packetType = packet[2];

            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ProcessValidatedPacket(packet)));
                return;
            }

            // UI Güncellemelerini burada yapıyoruz
            pictureBoxGreen.Visible = true;
            pictureBoxGrey.Visible = false;
            watchdogTimer.Stop();
            watchdogTimer.Start();

            if (packetType == (byte)PacketType.Telemetry)
            {
                TelemetryData telem = telemetry.ParseTelemetry(packet);

                currentRoll = telem.Roll;
                currentPitch = telem.Pitch;
                currentAltitude = telem.Altitude;
                currentYaw = telem.Yaw;
                currentRH = telem.RH;
                currentRV = telem.RV;
                currentLH = telem.LH;

                rollSetpoint = (telem.RH - 1000) / 12;
                pitchSetpoint = (telem.RV - 1000) / 12;
                yawSetpoint = (telem.LH - 1000) / 12;

                labelRoll.Text = telem.Roll.ToString("F2");
                labelPitch.Text = telem.Pitch.ToString("F2");
                labelYaw.Text = telem.Yaw.ToString("F2");
                labelAltitude.Text = telem.Altitude.ToString("F0");
                labelRH.Text = telem.RH.ToString("F2");
                labelRV.Text = telem.RV.ToString("F2");
                labelLH.Text = telem.LH.ToString("F2");

                labelRollSetpoint.Text = ((telem.RH - 1000) / 12).ToString("F2");
                labelPitchSetpoint.Text = ((telem.RV - 1000) / 12).ToString("F2");
                labelYawSetpoint.Text = ((telem.LH - 1000) / 12).ToString("F2");

                lastTelem = telem; // Veritabanı için veriyi güncelle

                if (isRecording && logWriter != null)
                {
                    logWriter.WriteLine($"{telem.Roll}\t{telem.Pitch}\t{telem.Yaw}\t{rollSetpoint}\t{pitchSetpoint}\t{yawSetpoint}");
                }
            }
            else if (packetType == (byte)PacketType.Gps)
            {
                GpsData gps = telemetry.ParseGps(packet);

                currentLat = gps.Latitude;
                currentLon = gps.Longitude;

                labelLatitude.Text = gps.Latitude.ToString("F7");
                labelLongitude.Text = gps.Longitude.ToString("F7");

                UpdateDroneOnMap(currentLat, currentLon, currentAltitude, currentRoll, currentPitch, currentYaw);

                lastGps = gps; // Veritabanı için veriyi güncelle

                if (isRecording && logWriter != null)
                {
                    logWriter.WriteLine($"GPS\t{gps.Latitude}\t{gps.Longitude}\t{currentAltitude}");
                }
            }
            else if (packetType == (byte)PacketType.PidReply)
            {
                byte fwId = packet[3];

                if (fwId > 5)
                {
                    Console.WriteLine($"Geçersiz PID fwId: {fwId}");
                    return;
                }

                PIDController gains = PID.ParsePid(packet, fwId);
                pidGains[fwId] = gains;

                Console.WriteLine($"PID REPLY → Axis={fwId} P={gains.P} I={gains.I} D={gains.D}");

                UpdatePid((PidAxis)fwId, gains);
            }
            else if (packetType == (byte)PacketType.ModelInfo)
            {
                ModelData modelInfo = telemetry.ParseModelInfo(packet);
            }
        }
                    
        private void timerGauge_Tick(object sender, EventArgs e)
        {
            attitudeIndicatorInstrumentControl1.SetAttitudeIndicatorParameters(currentPitch, currentRoll);
            headingIndicatorInstrumentControl1.SetHeadingIndicatorParameters(Convert.ToInt32(currentYaw));
            
            attitudeIndicatorInstrumentControl1.Invalidate();
            headingIndicatorInstrumentControl1.Invalidate();
            
            //Console.WriteLine($"Latitude: {currentLat}, Longitude: {currentLon}");           
        }
        private void watchdogTimer_Tick(object sender, EventArgs e)
        {
            // watchdogTimer.Stop(); // Watchdog'u şimdilik susturuyoruz ki MQTT testlerini kesmesin
            // CloseConnection();
            // MessageBox.Show("Veri akışı kesildiği için bağlantı sonlandırıldı.", "Bağlantı Koptu");
            Console.WriteLine("[WATCHDOG] Tick tetiklendi (Bağlantı kesme şimdilik pasif).");
        }
        private void timerSerialCheck_Tick(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            if (!ports.SequenceEqual(ComboBoxPorts.Items.Cast<string>()))
            {
                ComboBoxPorts.Items.Clear();
                ComboBoxPorts.Items.AddRange(ports);
                labelNoConnection.Visible = true;
            }
        }
        #endregion
    }
}
