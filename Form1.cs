using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AspanGround_2.PID;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//Bismillahirrahmanirrahim
//Author : Muhammed Kerem Demirbent
namespace AspanGround_2
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")] //Full yetki
    [System.Runtime.InteropServices.ComVisible(true)]  //Comlara full yetki
    public partial class AspanGround : Form
    {
        #region Descriptions

        private telemetry telemetry;  //telemetry.cs ile iletişim
        private PID PID;  //PID.cs ile iletişim
        private PIDController[] pidGains = new PIDController[3];
        

        private List<byte> buffer = new List<byte>();

        //ROLL PİTCH YAW ALT RH RV LH
        private float currentPitch;
        private float currentRoll;
        private float currentYaw;
       
        private float currentAltitude;       
        private float currentRH ;
        private float currentRV ;
        private float currentLH ;

        //GPS verisi
        private double currentLat;
        private double currentLon;
        #endregion

        #region ChartDescriptions

        private SeriesCollection _series;
        private LineSeries _rollSeries, _pitchSeries, _yawSeries, _rollSetpointSeries, _pitchSetpointSeries, _yawSetpointSeries;

        //Roll setpoint = (RH-1000)/12
        //Pitch setpoint = (RV-1000)/12
        //Yaw setpoint = (LH -1000)/12

        private float rollSetpoint;
        private float pitchSetpoint;
        private float yawSetpoint;
        
        private const int WindowSize = 100;
        private long _sampleIndex = 0;

        //Loglama işlemleri
        private StreamWriter logWriter; // Dosyaya yazmak için
        private bool isRecording = false; // Kayıt durumunu takip eder
        private string logFolderPath; // Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "AspanGround", "Logs");
        #endregion

        #region AspanGround
        public AspanGround()   
        {
            InitializeComponent();
          
            telemetry = new telemetry(); //telemetri verileri okumak için nesne
            InitChartRP(); // Grafiklerin düzenlenmesi
            PID = new PID();
            telemetry = new telemetry();
            radioNone.Checked = true;

            //pictureBoxLeftAnalogBack.Controls.Add(pictureBoxLeftAnalogFront);
            //pictureBoxLeftAnalogFront.BringToFront();
            //pictureBoxRightAnalogBack.Controls.Add(pictureBoxRightAnalogFront);
            //pictureBoxRightAnalogFront.BringToFront();     

            this.Load += async (s, e) =>
            {
                await InitializeWebView2Async();
            };

            //Log klasör yeri
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string company = "Aspan";   
            logFolderPath = Path.Combine(localAppData, company, "Logs");

        }
        #endregion
        
        #region Map and DatasetGridWiew
        private void InitializeWaypointTable()
        {       
            dataGridViewWaypoints.Rows.Clear();
        }

        int wpcounter = 1;
        private void webViewMap_WebMessageReceived(object sender, Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
        {
            string json = e.WebMessageAsJson;

            try
            {                
                var jobj = Newtonsoft.Json.Linq.JObject.Parse(json);
                var action = jobj.Value<string>("action") ?? string.Empty;

                int idx = jobj.TryGetValue("idx", out var idxTok) && idxTok.Type == Newtonsoft.Json.Linq.JTokenType.Integer
                          ? idxTok.Value<int>()
                          : -1;

                if (action == "add")
                {
                    
                    if (!TryGetDouble(jobj, "lat", out double lat) ||
                        !TryGetDouble(jobj, "lng", out double lng))
                    {
                        
                        Debug.WriteLine("Add mesajı eksik lat/lng.");
                        return;
                    }
                     
                    
                    double alt = TryGetDouble(jobj, "alt", out double tmpAlt) ? tmpAlt : 0.0;

                    int insertIndex = Math.Max(0, Math.Min(idx, dataGridViewWaypoints.Rows.Count));

                    dataGridViewWaypoints.Rows.Insert(insertIndex, new object[]
                    {
                insertIndex,
                "WAYPOINT-" + wpcounter,
                alt.ToString(),
                lng.ToString("F6"),
                lat.ToString("F6"),
                    });
                    wpcounter++;

                    // Idx sütunlarını güncelle
                    for (int r = insertIndex + 1; r < dataGridViewWaypoints.Rows.Count; r++)
                    {
                        dataGridViewWaypoints.Rows[r].Cells["idx"].Value = r;
                    }
                }
                else if (action == "remove" || action == "removed")
                {
                    // idx kontrolü
                    if (idx >= 0 && idx < dataGridViewWaypoints.Rows.Count)
                    {
                        dataGridViewWaypoints.Rows.RemoveAt(idx);
                        for (int r = idx; r < dataGridViewWaypoints.Rows.Count; r++)
                        {
                            dataGridViewWaypoints.Rows[r].Cells["idx"].Value = r;
                        }
                    }
                }
                else if (action == "update")
                {
                    if (!TryGetDouble(jobj, "lat", out double lat) ||
                        !TryGetDouble(jobj, "lng", out double lng))
                    {
                        Debug.WriteLine("Update mesajı eksik lat/lng.");
                        return;
                    }

                    double alt = TryGetDouble(jobj, "alt", out double tmpAlt) ? tmpAlt : 0.0;

                    if (idx >= 0 && idx < dataGridViewWaypoints.Rows.Count)
                    {
                        dataGridViewWaypoints.Rows[idx].Cells["Latitude"].Value = lat.ToString("F6");
                        dataGridViewWaypoints.Rows[idx].Cells["Longitude"].Value = lng.ToString("F6");
                        dataGridViewWaypoints.Rows[idx].Cells["Altitude"].Value = alt.ToString();
                    }
                }
                else
                {
                    Debug.WriteLine($"Bilinmeyen action: {action}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mesaj işlenirken hata: " + ex.Message);
            }
        }

        // Yardımcı: JObject'ten güvenli double alma
        private bool TryGetDouble(Newtonsoft.Json.Linq.JObject jobj, string propName, out double value)
        {
            value = 0;
            if (!jobj.TryGetValue(propName, out var tok)) return false;

            if (tok.Type == Newtonsoft.Json.Linq.JTokenType.Float || tok.Type == Newtonsoft.Json.Linq.JTokenType.Integer)
            {
                value = tok.Value<double>();
                return true;
            }
            if (tok.Type == Newtonsoft.Json.Linq.JTokenType.String)
            {
                return double.TryParse(tok.Value<string>(), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out value);
            }
            return false;
        }
        private async void ButtonDeleteWaypoint_Click(object sender, EventArgs e)
        {
            if (dataGridViewWaypoints.Rows.Count == 0) return;

            // Her zaman son satırın index'ini al (seçimden bağımsız)
            int idx = dataGridViewWaypoints.Rows.Count - 1;

            // DataGridView'den kaldır
            dataGridViewWaypoints.Rows.RemoveAt(idx);

            // Idx sütunlarını güncelle (son silindiği için loop çalışmayacak, ama güvenli olsun)
            for (int r = idx; r < dataGridViewWaypoints.Rows.Count; r++)
            {
                dataGridViewWaypoints.Rows[r].Cells["idx"].Value = r;
            }

            wpcounter = Math.Max(1, wpcounter - 1);

            // Web tarafına da remove bilgisini gönder (idx JS array'inde de son index olmalı)
            string jsCode = $"removeWaypointFromJS({idx});";
            if (webViewMap?.CoreWebView2 != null)
            {
                await webViewMap.CoreWebView2.ExecuteScriptAsync(jsCode);
            }
        }


        private async Task InitializeWebView2Async()
        {
            try
            {
                // 1) UserDataFolder yolu
                string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string userDataFolder = Path.Combine(localAppData, "AspanMap");

                // 2) Klasörü oluştur
                Directory.CreateDirectory(userDataFolder);

                // 3) Tüm işlem tek try içinde
                var env = await CoreWebView2Environment.CreateAsync(
                    browserExecutableFolder: null,
                    userDataFolder: userDataFolder);

                await webViewMap.EnsureCoreWebView2Async(env);
            }
            catch (System.UnauthorizedAccessException ex)
            {
                Debug.WriteLine($"WebView2 yetki hatası sessize alındı: {ex.Message}");
                // Burada *hiçbir şey yapma*, böylece crash olmaz!
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"WebView2 başka hata: {ex.Message}");
                // Diğer hatalar için istersen log tut.
            }
        }

    
        private async void UpdateDroneOnMap(double latitude, double longitude, double altitude, float roll, float pitch, float yaw)
        {
            if (webViewMap?.CoreWebView2 == null) return;

            try
            {

                string jsCode = $"updateIhaPosition({longitude.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {latitude.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {altitude.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {yaw.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {pitch.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {roll.ToString(System.Globalization.CultureInfo.InvariantCulture)});";

                await webViewMap.CoreWebView2.ExecuteScriptAsync(jsCode);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"JS update hatası: {ex.Message}");
            }
        }
        #endregion

        #region OpeningClosing
        private void AspanGround_Load(object sender, EventArgs e)
        {
            string htmlPath = Path.Combine(Application.StartupPath, "Resources", "map.html");
            webViewMap.Source = new Uri(htmlPath);
            //await webViewMap.EnsureCoreWebView2Async(null);
            InitializeWaypointTable();
            timerGauge.Start();
        }
        private void AspanGround_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
               
                DialogResult result = MessageBox.Show(
                    "Port bağlantısı hâlâ açık. Uygulamayı kapatmadan önce port bağlantısını kesiniz. ",
                    "Uygulamayı kapatmak ister misiniz?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.No)
                {                    
                    e.Cancel = true;
                    return;
                }
                else
                {
                    serialPort = null;
                    ButtonDisconnect_Click_1(null, EventArgs.Empty);
                    timerRCControls.Stop();                  
                    timerSerialCheck.Stop();
                   
                    if (isRecording && logWriter != null) //Loglama yeri 
                    {
                        try
                        {
                            logWriter.Close();
                        }
                        catch { }
                        isRecording = false;
                    }
                }
            }
        }
        #endregion

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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Seri port açılırken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ButtonDisconnect_Click_1(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
              
                serialPort.DataReceived -= serialPort_DataReceived;
                serialPort.Close();
                serialPort.Dispose();
                serialPort = null;
                timerGraphic.Stop();
                timerGauge.Stop();
                logWriter?.Close();

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
            else
            {
                radioNone.Checked = true;
            }
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
                    // Paket başlık kontrolü
                    if (buffer[0] == 0x46 && buffer[1] == 0x43)
                    {
                        byte[] packet = buffer.GetRange(0, 20).ToArray();
                        buffer.RemoveRange(0, 20);

                        byte checksum = 0xFF;
                        for (int i = 0; i < 19; i++)
                            checksum -= packet[i];

                        if (packet[19] == checksum)
                        {
                            byte packetType = packet[2];
                            string hexDump = string.Join(" ", packet.Select(b => b.ToString("X2")));
                            Console.WriteLine($"Tam paket hex (Type=0x{packetType:X2}, ID={packet[3]}): {hexDump}");

                            this.Invoke(new Action(() =>
                            {
                                if (packetType == 0x10)
                                {                                                                      
                                    TelemetryData telem = telemetry.ParseTelemetry(packet);
                                    
                                    currentRoll = telem.Roll;
                                    currentPitch = telem.Pitch;
                                    currentAltitude = telem.Altitude;
                                    currentYaw = telem.Yaw;
                                    currentRH = telem.RH;
                                    currentRV = telem.RV;
                                    currentLH = telem.LH;
                                   
                                    rollSetpoint = (telem.RH - 1000) / 12;  //(currentRH-1000)/12
                                    pitchSetpoint = (telem.RV - 1000) / 12;
                                    yawSetpoint =  (telem.LH - 1000) / 12;

                                    labelRoll.Text = telem.Roll.ToString("F2");
                                    labelPitch.Text = telem.Pitch.ToString("F2");
                                    labelYaw.Text = telem.Yaw.ToString("F2");
                                    labelAltitude.Text = telem.Altitude.ToString("F0");
                                    //labelAltitudeWatch.Text = telem.Altitude.ToString("F0");
                                    labelRH.Text = telem.RH.ToString("F2");
                                    labelRV.Text = telem.RV.ToString("F2");
                                    labelLH.Text = telem.LH.ToString("F2");
                                  
                                    labelRollSetpoint.Text =((telem.RH - 1000) / 12).ToString("F2");  //labelRollSetpoint.Text =ROLLSetpoint.ToString("F2");
                                    labelPitchSetpoint.Text =((telem.RV - 1000) / 12).ToString("F2");
                                    labelYawSetpoint.Text = ((telem.LH - 1000) / 12).ToString("F2");
                                   
                                }
                                else if (packetType == 0x11)
                                {
                                  

                                    // GPS paketi
                                    GpsData gps = telemetry.ParseGps(packet);

                                    currentLat = gps.Latitude;
                                    currentLon = gps.Longitude;

                                    labelLatitude.Text = gps.Latitude.ToString("F7");
                                    labelLongitude.Text = gps.Longitude.ToString("F7");

                                    UpdateDroneOnMap(currentLat, currentLon, currentAltitude, currentRoll, currentPitch, currentYaw);

                                }
                                else if (packetType >= 0x00 && packetType <= 0x05)  // Tüm PID type'larını yakala (0x00-0x05)
                                {
                                    byte fwId = packet[2];  // *** DEĞİŞTİR: fwId = type ([2]) – log'lardan fwId burda! [3] her zaman 0 ***
                                    byte uiId = GetUiIdFromFw(fwId);
                                    if (uiId != 255)
                                    {
                                        Console.WriteLine($"PID paketi yakalandı: FW ID={fwId} (Type=0x{packetType:X2}), UI ID={uiId}");
                                        PIDController gains = PID.ParsePid(packet, fwId);
                                        pidGains[uiId] = gains;
                                        UpdatePid(uiId, gains);
                                        Console.WriteLine($"PID UI{uiId} güncellendi: P={gains.P:F2}, I={gains.I:F2}, D={gains.D:F2}");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"PID FW ID={fwId} (Type=0x{packetType:X2}) UI'ye map'lenemedi – Atlanıyor");
                                    }
                                }
                            })); 
                        }
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
                    
        private void timerGauge_Tick(object sender, EventArgs e)
        {
            attitudeIndicatorInstrumentControl1.SetAttitudeIndicatorParameters(currentPitch, currentRoll);
            headingIndicatorInstrumentControl1.SetHeadingIndicatorParameters(Convert.ToInt32(currentYaw));
            
            attitudeIndicatorInstrumentControl1.Invalidate();
            headingIndicatorInstrumentControl1.Invalidate();
            
            //Console.WriteLine($"Latitude: {currentLat}, Longitude: {currentLon}");           
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

        #region ChartGraphics
        private void InitChartRP()
        {
            var mapper = Mappers.Xy<ObservablePoint>()
                .X(pt => pt.X)
                .Y(pt => pt.Y);
            Charting.For<ObservablePoint>(mapper);

            // Roll serisi
            _rollSeries = new LineSeries
            {
                Title = "Roll",
                Values = new ChartValues<ObservablePoint>(),
                PointGeometry = null

            };
            // Yaw serisi
            _yawSeries = new LineSeries
            {
                Title = "Yaw",
                Values = new ChartValues<ObservablePoint>(),
                PointGeometry = null
            };

            // Pitch serisi
            _pitchSeries = new LineSeries
            {
                Title = "Pitch",
                
                Values = new ChartValues<ObservablePoint>(),
                PointGeometry = null
            };

            // RollSetpoint serisi
            _rollSetpointSeries = new LineSeries
            {
                Title = "RollSetpoint",
                Values = new ChartValues<ObservablePoint>(),
                PointGeometry = null
            };

            // PitchSetpoint serisi
            _pitchSetpointSeries = new LineSeries
            {
                Title = "PitchSetpoint",
                Values = new ChartValues<ObservablePoint>(),
                PointGeometry = null
            };

            // YawSetpoint serisi
            _yawSetpointSeries = new LineSeries
            {
                Title = "YawSetpoint",
                Values = new ChartValues<ObservablePoint>(),
                PointGeometry = null
            };


            _series = new SeriesCollection();
            ChartRollPitchYaw.Series = _series;


            ChartRollPitchYaw.AxisX.Clear();
            ChartRollPitchYaw.AxisX.Add(new Axis
            {
                LabelFormatter = value => "", //X eksenini kaldırdı 
            });

            ChartRollPitchYaw.AxisY.Clear();
            ChartRollPitchYaw.AxisY.Add(new Axis
            {
                Title = "",
                MinValue = -360,
                MaxValue = +360,
                LabelFormatter = v => v.ToString("0"),

            });
            ChartRollPitchYaw.LegendLocation = LegendLocation.Top;
        }
        private double GetRollFromYourBoard()
        {
            return currentRoll;
        }
        private double GetYawFromYourBoard()
        {
            return currentYaw;
        }
        private double GetYawSetpointFromYourBoard()
        {            
            return yawSetpoint;
        }
        private double GetPitchFromYourBoard()
        {
            return currentPitch;
        }
        private double GetPitchSetpointFromYourBoard()
        {
            return pitchSetpoint;
        }
        private double GetRollSetpointFromYourBoard()
        {
            return rollSetpoint;
        }
        private void radioYaw_CheckedChanged(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                _yawSeries.Stroke = System.Windows.Media.Brushes.DarkOrange;
                _yawSeries.Fill = System.Windows.Media.Brushes.Transparent;
                _yawSeries.StrokeThickness = 3;

                ChartRollPitchYaw.Series.Clear();
                ChartRollPitchYaw.Series.Add(_yawSeries);
                timerGraphic.Start();
            }
            else
            {
                MessageBox.Show("Kart ile bağlantı kurunuz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioNone.Checked = true;
            }                    
        }
        private void radioRoll_CheckedChanged(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                _rollSeries.Stroke = System.Windows.Media.Brushes.Red;
                _rollSeries.Fill = System.Windows.Media.Brushes.Transparent;
                _rollSeries.StrokeThickness = 3;

                ChartRollPitchYaw.Series.Clear();
                ChartRollPitchYaw.Series.Add(_rollSeries);
                timerGraphic.Start();
            }
            else
            {
                MessageBox.Show("Kart ile bağlantı kurunuz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioNone.Checked = true;
            }
        }
        private void radioPitch_CheckedChanged(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                _pitchSeries.Stroke = System.Windows.Media.Brushes.Green;
                _pitchSeries.Fill = System.Windows.Media.Brushes.Transparent;
                _pitchSeries.StrokeThickness = 3;

                ChartRollPitchYaw.Series.Clear();
                ChartRollPitchYaw.Series.Add(_pitchSeries);
                timerGraphic.Start();
            }
            else
            {
                MessageBox.Show("Kart ile bağlantı kurunuz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioNone.Checked = true;
            }
        }
        private void radioRollPitch_CheckedChanged(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                _rollSeries.Stroke = System.Windows.Media.Brushes.Red;
                _rollSeries.Fill = System.Windows.Media.Brushes.Transparent;
                _rollSeries.StrokeThickness = 3;

                _pitchSeries.Stroke = System.Windows.Media.Brushes.Green;
                _pitchSeries.Fill = System.Windows.Media.Brushes.Transparent;
                _pitchSeries.StrokeThickness = 3;

                ChartRollPitchYaw.Series.Clear();
                ChartRollPitchYaw.Series.Add(_rollSeries);
                ChartRollPitchYaw.Series.Add(_pitchSeries);
                timerGraphic.Start();
            }
            else
            {
                MessageBox.Show("Kart ile bağlantı kurunuz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioNone.Checked = true;
            }
        }

        private void radioRollSetpoint_CheckedChanged(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                _rollSeries.Stroke = System.Windows.Media.Brushes.Red;
                _rollSeries.Fill = System.Windows.Media.Brushes.Transparent;
                _rollSeries.StrokeThickness = 3;

                _rollSetpointSeries.Stroke = System.Windows.Media.Brushes.Blue;
                _rollSetpointSeries.Fill = System.Windows.Media.Brushes.Transparent;
                _rollSetpointSeries.StrokeThickness = 3;

                ChartRollPitchYaw.Series.Clear();
                ChartRollPitchYaw.Series.Add(_rollSeries);
                ChartRollPitchYaw.Series.Add(_rollSetpointSeries);
                timerGraphic.Start();
            }
            else
            {
                MessageBox.Show("Kart ile bağlantı kurunuz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioNone.Checked = true;
            }
        }
        private void radioPitchSetpoint_CheckedChanged(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                _pitchSeries.Stroke = System.Windows.Media.Brushes.Green;
                _pitchSeries.Fill = System.Windows.Media.Brushes.Transparent;
                _pitchSeries.StrokeThickness = 3;

                _pitchSetpointSeries.Stroke = System.Windows.Media.Brushes.Blue;
                _pitchSetpointSeries.Fill = System.Windows.Media.Brushes.Transparent;
                _pitchSetpointSeries.StrokeThickness = 3;

                ChartRollPitchYaw.Series.Clear();
                ChartRollPitchYaw.Series.Add(_pitchSeries);
                ChartRollPitchYaw.Series.Add(_pitchSetpointSeries);
                timerGraphic.Start();
            }
            else
            {
                MessageBox.Show("Kart ile bağlantı kurunuz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioNone.Checked = true;
            }
        }
        private void radioYawSetpoint_CheckedChanged(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                _yawSeries.Stroke = System.Windows.Media.Brushes.DarkOrange;
                _yawSeries.Fill = System.Windows.Media.Brushes.Transparent;
                _yawSeries.StrokeThickness = 3;

                _yawSetpointSeries.Stroke = System.Windows.Media.Brushes.Blue;
                _yawSetpointSeries.Fill = System.Windows.Media.Brushes.Transparent;
                _yawSetpointSeries.StrokeThickness = 3;

                ChartRollPitchYaw.Series.Clear();
                ChartRollPitchYaw.Series.Add(_yawSeries);
                ChartRollPitchYaw.Series.Add(_yawSetpointSeries);
                timerGraphic.Start();
            }
            else
            {
                MessageBox.Show("Kart ile bağlantı kurunuz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioNone.Checked = true;
            }
        }
        private void radioNone_CheckedChanged(object sender, EventArgs e)
        {
            ChartRollPitchYaw.Series.Clear();
            timerGraphic.Stop();
        }
        private void ButtonStartLog_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                if (!isRecording)
                {
                    try
                    {

                        if (!Directory.Exists(logFolderPath)) //Klasör yoksa yeniden oluşturur.
                        {
                            Directory.CreateDirectory(logFolderPath);
                        }

                        string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss"); //Log txt ismi
                        string safeFileName = $"log_{timestamp}.txt";
                        string logFilePath = Path.Combine(logFolderPath, safeFileName);

                        ButtonStartLog.Text = "Logging...";

                        timerGraphic.Start();

                        logWriter = new StreamWriter(logFilePath, false, Encoding.UTF8);
                        logWriter.WriteLine("Roll\t  Pitch\t  Yaw\t  RollSetpoint\t  PitchSetpoint\t  YawSetpoint");

                        isRecording = true;

                        MessageBox.Show($"Kayıt başlatıldı. Log dizini:\n{logFolderPath}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (UnauthorizedAccessException uae)
                    {
                        MessageBox.Show($"Yazma izni yok: {uae.Message}\n\nLütfen uygulamayı yönetici olarak çalıştır ya da izin verilen bir klasör kullan.", "İzin Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ButtonStartLog.Text = "Start Log";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Log başlatılamadı: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ButtonStartLog.Text = "Start Log";
                    }
                }
                else
                {
                    MessageBox.Show("Kayıt zaten başlatılmış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Kart ile bağlantı sağlanmadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioNone.Checked = true;
            }
        }
        private void ButtonSaveLog_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                if (isRecording)
                {
                    try
                    {
                        logWriter?.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Log kapanırken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        isRecording = false;
                        ButtonStartLog.Text = "Start Log";
                    }
                    MessageBox.Show("Kayıt durduruldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    radioNone.Checked = true;
                }
                else
                {
                    MessageBox.Show("Kayıt başlatılmamış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Bağlantı sağlanmamış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ButtonOpenFolder_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(logFolderPath))
                {
                    Process.Start("explorer.exe", logFolderPath);
                }
                else
                {
                    MessageBox.Show("Log klasörü bulundu değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Klasör açılamadı: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timerGraphic_Tick(object sender, EventArgs e)
        {
            var idx2 = _sampleIndex++;

            _rollSeries.Values.Add(new ObservablePoint(idx2, GetRollFromYourBoard()));
            _pitchSeries.Values.Add(new ObservablePoint(idx2, GetPitchFromYourBoard()));
            _yawSeries.Values.Add(new ObservablePoint(idx2, GetYawFromYourBoard()));
            _rollSetpointSeries.Values.Add(new ObservablePoint(idx2, GetRollSetpointFromYourBoard()));
            _pitchSetpointSeries.Values.Add(new ObservablePoint(idx2, GetPitchSetpointFromYourBoard()));
            _yawSetpointSeries.Values.Add(new ObservablePoint(idx2, GetYawSetpointFromYourBoard()));

            if (_rollSeries.Values.Count > WindowSize) _rollSeries.Values.RemoveAt(0);
            if (_pitchSeries.Values.Count > WindowSize) _pitchSeries.Values.RemoveAt(0);
            if (_yawSeries.Values.Count > WindowSize) _yawSeries.Values.RemoveAt(0);
            if (_rollSetpointSeries.Values.Count > WindowSize) _rollSetpointSeries.Values.RemoveAt(0);
            if (_pitchSetpointSeries.Values.Count > WindowSize) _pitchSetpointSeries.Values.RemoveAt(0);
            if (_yawSetpointSeries.Values.Count > WindowSize) _yawSetpointSeries.Values.RemoveAt(0);

            ChartRollPitchYaw.AxisX[0].MinValue = idx2 - WindowSize + 1;
            ChartRollPitchYaw.AxisX[0].MaxValue = idx2;

            if (isRecording && logWriter != null)
            {
                try
                {
                    // Log satırı
                    string logLine = $"{currentRoll}\t{currentPitch}\t{currentYaw}\t{rollSetpoint}\t{pitchSetpoint}\t{yawSetpoint}";
                    logWriter.WriteLine(logLine);
                }
                catch (UnauthorizedAccessException uae)
                {
                    isRecording = false;
                    logWriter?.Close();
                    MessageBox.Show($"Log yazılamadı, izin hatası: {uae.Message}", "İzin Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ButtonStartLog.Text = "Start Log";
                }
                catch (Exception ex)
                {      
                    isRecording = false;
                    logWriter?.Close();
                    MessageBox.Show($"Log yazılamadı: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ButtonStartLog.Text = "Start Log";
                }
            }
        }

        #endregion

        #region PID 
        private byte GetFwIdFromUi(byte uiId)
        {
            return (byte)(uiId == 0 ? 0 : uiId == 1 ? 2 : 5);
        }
        private byte GetUiIdFromFw(byte fwId)
        {
            if (fwId == 0) return 0;      // Roll Inner
            if (fwId == 2) return 1;      // Pitch Inner
            if (fwId == 5) return 2;      // Yaw Rate
            return 255;  // Atla
        }  
        private void UpdatePid(byte uiId, PIDController pid)
        {
            try
            {
                switch (uiId)
                {
                    case 0:  // Roll
                        NumericPR.Value = (decimal)pid.P;
                        NumericIR.Value = (decimal)pid.I;
                        NumericDR.Value = (decimal)pid.D;
                        NumericIMAXR.Value = (decimal)pid.IMAX;
                        NumericFILTR.Value = (decimal)pid.FF;
                        break;
                    case 1:  // Pitch
                        NumericPP.Value = (decimal)pid.P;
                        NumericIP.Value = (decimal)pid.I;
                        NumericDP.Value = (decimal)pid.D;
                        NumericIMAXP.Value = (decimal)pid.IMAX;
                        NumericFILTP.Value = (decimal)pid.FF;
                        break;
                    case 2:  // Yaw
                        NumericPY.Value = (decimal)pid.P;
                        NumericIY.Value = (decimal)pid.I;
                        NumericDY.Value = (decimal)pid.D;
                        NumericIMAXY.Value = (decimal)pid.IMAX;
                        NumericFILTY.Value = (decimal)pid.FF;
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"UI güncelleme hatası (uiId={uiId}): {ex.Message}");  // *** EKLE: Hata log ***
            }
        }
        private void ButtonRollWrite_Click(object sender, EventArgs e)
        {
            if (serialPort == null || !serialPort.IsOpen)
            {
                MessageBox.Show("Seri port bağlantısı yok! Önce 'Connect' butonuna basın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Console.WriteLine("PID yazma başlıyor...");

                PIDController rollGains = new PIDController((float)NumericPR.Value, (float)NumericIR.Value, (float)NumericDR.Value);
                byte[] rollPacket = PID.EncodePidWrite(0, rollGains);
                serialPort.Write(rollPacket, 0, 20);
                Console.WriteLine($"Roll yazıldı FW0 ([2]=0x00) - Hex: {BitConverter.ToString(rollPacket)} - P={rollGains.P:F2} I={rollGains.I:F2} D={rollGains.D:F2}");

                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Yazma sonrası read-back başlıyor...");
                ButtonRollRefresh_Click(sender, e);

                MessageBox.Show("PID'ler yazıldı ve yeniden yüklendi! Kartı resetle, Refresh ile kalıcı mı kontrol et.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Write hata: {ex.StackTrace}");
                MessageBox.Show($"Yazma hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ButtonPitchWrite_Click(object sender, EventArgs e)
        {
            if (serialPort == null || !serialPort.IsOpen)
            {
                MessageBox.Show("Seri port bağlantısı yok! Önce 'Connect' butonuna basın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Console.WriteLine("PID yazma başlıyor...");

                PIDController pitchGains = new PIDController((float)NumericPP.Value, (float)NumericIP.Value, (float)NumericDP.Value);
                byte[] pitchPacket = PID.EncodePidWrite(2, pitchGains);
                serialPort.Write(pitchPacket, 0, 20);
                Console.WriteLine($"Pitch yazıldı FW2 ([2]=0x02) - Hex: {BitConverter.ToString(pitchPacket)} - P={pitchGains.P:F2} I={pitchGains.I:F2} D={pitchGains.D:F2}");

                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Yazma sonrası read-back başlıyor...");
                ButtonPitchRefresh_Click(sender, e);

                MessageBox.Show("PID'ler yazıldı ve yeniden yüklendi! Kartı resetle, Refresh ile kalıcı mı kontrol et.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Write hata: {ex.StackTrace}");
                MessageBox.Show($"Yazma hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ButtonYawWrite_Click(object sender, EventArgs e)
        {
            if (serialPort == null || !serialPort.IsOpen)
            {
                MessageBox.Show("Seri port bağlantısı yok! Önce 'Connect' butonuna basın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Console.WriteLine("PID yazma başlıyor...");

                PIDController yawGains = new PIDController((float)NumericPY.Value, (float)NumericIY.Value, (float)NumericDY.Value);
                byte[] yawPacket = PID.EncodePidWrite(5, yawGains);
                serialPort.Write(yawPacket, 0, 20);
                Console.WriteLine($"Yaw yazıldı FW5 ([2]=0x05) - Hex: {BitConverter.ToString(yawPacket)} - P={yawGains.P:F2} I={yawGains.I:F2} D={yawGains.D:F2}");

                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Yazma sonrası read-back başlıyor...");
                ButtonYawRefresh_Click(sender, e);

                MessageBox.Show("PID'ler yazıldı ve yeniden yüklendi! Kartı resetle, Refresh ile kalıcı mı kontrol et.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Write hata: {ex.StackTrace}");
                MessageBox.Show($"Yazma hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ButtonRollRefresh_Click(object sender, EventArgs e)
        {
            if (serialPort == null || !serialPort.IsOpen)
            {
                MessageBox.Show("Seri port bağlantısı yok!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (PID == null)
            {
                MessageBox.Show("PID nesnesi başlatılmamış! Uygulamayı yeniden başlatın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                byte uiId = 0; // Roll
                byte fwId = GetFwIdFromUi(uiId);
                byte[] request = PID.EncodePidReadRequest(fwId);
                serialPort.Write(request, 0, request.Length);

                Console.WriteLine($"Roll (UI{uiId}, FW{fwId}) okuma isteği gönderildi - {BitConverter.ToString(request)}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Roll okuma hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ButtonPitchRefresh_Click(object sender, EventArgs e)
        {
            if (serialPort == null || !serialPort.IsOpen)
            {
                MessageBox.Show("Seri port bağlantısı yok!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (PID == null)
            {
                MessageBox.Show("PID nesnesi başlatılmamış! Uygulamayı yeniden başlatın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                byte uiId = 1; // Pitch
                byte fwId = GetFwIdFromUi(uiId);
                byte[] request = PID.EncodePidReadRequest(fwId);
                serialPort.Write(request, 0, request.Length);

                Console.WriteLine($"Pitch (UI{uiId}, FW{fwId}) okuma isteği gönderildi - {BitConverter.ToString(request)}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pitch okuma hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ButtonYawRefresh_Click(object sender, EventArgs e)
        {
            if (serialPort == null || !serialPort.IsOpen)
            {
                MessageBox.Show("Seri port bağlantısı yok!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (PID == null)
            {
                MessageBox.Show("PID nesnesi başlatılmamış! Uygulamayı yeniden başlatın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                byte uiId = 2; // Yaw
                byte fwId = GetFwIdFromUi(uiId);
                byte[] request = PID.EncodePidReadRequest(fwId);
                serialPort.Write(request, 0, request.Length);

                Console.WriteLine($"Yaw (UI{uiId}, FW{fwId}) okuma isteği gönderildi - {BitConverter.ToString(request)}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yaw okuma hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Info
        private void linkLabelWebSitesi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com/mail/u/0/#inbox");
        }

        private void linkLabelSoruGorus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/aspanuav/");
        }

        private void pictureBoxLinkedn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/company/aspan-uav/");
        }

        private void pictureBoxInstangram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/aspanuav/");
        }

        private void pictureBoxMail_Click(object sender, EventArgs e)
        {
            string alici = "keremdmrbnt03@gmail.com";  ///////          
            string mailto = $"mailto:{alici}";

            try
            {
                Process.Start(mailto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail uygulaması açılamadı: " + ex.Message);
            }
        }
        #endregion
       
    }
}