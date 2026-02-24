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
using Npgsql;


//Bismillahirrahmanirrahim
//Author: Muhammed Kerem Demirbent
namespace AspanGround_2
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")] //Full yetki
    [System.Runtime.InteropServices.ComVisible(true)]  //Comlara full yetki
    public partial class AspanGround : Form
    {
        #region Descriptions

        private telemetry telemetry;  //telemetry.cs ile iletişim
        private PID PID;  //PID.cs ile iletişim
        private DatabaseManager dbManager; // SQL Veritabanı yöneticimiz
        private CloudDataManager cloudManager; // Bulut (MQTT) Veri yöneticimiz
        private PIDController[] pidGains = new PIDController[6];
        private bool[] pidValid = new bool[6];


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

        private LiveCharts.SeriesCollection _series;
        private LineSeries _rollSeries, _pitchSeries, _yawSeries, _rollSetpointSeries, _pitchSetpointSeries, _yawSetpointSeries;

        private float rollSetpoint;
        private float pitchSetpoint;
        private float yawSetpoint;
        
        private const int WindowSize = 100;
        private long _sampleIndex = 0;

        //Loglama işlemleri
        private StreamWriter logWriter; // Dosyaya yazmak için
        private bool isRecording = false; // TXT Kayıt durumunu takip eder
        private bool isSqlLogging = false; // SQL Kayıt durumunu takip eder

        private string logFolderPath; 
        
        private TelemetryData lastTelem; // SQL için son telemetri verisi
        private GpsData lastGps;         // SQL için son GPS verisi
        private long currentSessionId = 0; // Aktif uçuş oturumu ID'si
        #endregion

        #region AspanGround
        public AspanGround()   
        {
            InitializeComponent();
          
            telemetry = new telemetry(); //telemetri verileri okumak için nesne
            InitChartRP(); // Grafiklerin düzenlenmesi
            PID = new PID();
            radioNone.Checked = true;

            cloudManager = new CloudDataManager();
            
            cloudManager.OnPacketReceived += (packet) => {
                this.Invoke(new Action(() => ProcessValidatedPacket(packet)));
            };

            InitializeCloudUI();

            this.Load += async (s, e) =>
            {
                await InitializeWebView2Async();
            };

            //Log klasör yeri
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string company = "Aspan";   
            logFolderPath = Path.Combine(localAppData, company, "Logs");

            dbManager = new DatabaseManager(); // Veritabanını başlat

            // SQL Timer ayarları
            timerSQL.Interval = 1000;
            // timerSQL.Tick += timerSQL_Tick; // Bir kez yukarıda veya bir kez burada olmalı. 105. satırdakini sildim, buradakini tutuyorum.
            timerSQL.Tick += timerSQL_Tick;
        }
        #endregion
    }
}

