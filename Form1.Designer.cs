namespace AspanGround_2
{
    partial class AspanGround
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AspanGround));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelUpper = new System.Windows.Forms.Panel();
            this.ButtonDisconnect = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonConnect = new Guna.UI2.WinForms.Guna2Button();
            this.ComboBoxPorts = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboBoxBaudRates = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelASPANGORUND = new System.Windows.Forms.Label();
            this.pictureBoxGrey = new System.Windows.Forms.PictureBox();
            this.pictureBoxGreen = new System.Windows.Forms.PictureBox();
            this.labelNoConnection = new System.Windows.Forms.Label();
            this.labelConnected = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.ChartRollPitchYaw = new LiveCharts.WinForms.CartesianChart();
            this.labelLongitude = new System.Windows.Forms.Label();
            this.labellngtd = new System.Windows.Forms.Label();
            this.lblroll = new System.Windows.Forms.Label();
            this.lblpitch = new System.Windows.Forms.Label();
            this.lblrh = new System.Windows.Forms.Label();
            this.lbllh = new System.Windows.Forms.Label();
            this.labelLatitude = new System.Windows.Forms.Label();
            this.labelRV = new System.Windows.Forms.Label();
            this.lbllttd = new System.Windows.Forms.Label();
            this.labelLH = new System.Windows.Forms.Label();
            this.labelYaw = new System.Windows.Forms.Label();
            this.lblrv = new System.Windows.Forms.Label();
            this.lblaltitude = new System.Windows.Forms.Label();
            this.labelRoll = new System.Windows.Forms.Label();
            this.labelAltitude = new System.Windows.Forms.Label();
            this.labelRH = new System.Windows.Forms.Label();
            this.lblyaw = new System.Windows.Forms.Label();
            this.labelPitch = new System.Windows.Forms.Label();
            this.timerGraphic = new System.Windows.Forms.Timer(this.components);
            this.timerRCControls = new System.Windows.Forms.Timer(this.components);
            this.TabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPageWATCH = new System.Windows.Forms.TabPage();
            this.panelMiddleAbove = new System.Windows.Forms.TableLayoutPanel();
            this.panelBelow = new System.Windows.Forms.Panel();
            this.panelBottomLeft = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.ButtonDeleteWaypoint = new Guna.UI2.WinForms.Guna2Button();
            this.headingIndicatorInstrumentControl1 = new AvionicsInstrumentControlDemo.HeadingIndicatorInstrumentControl();
            this.attitudeIndicatorInstrumentControl1 = new AvionicsInstrumentControlDemo.AttitudeIndicatorInstrumentControl();
            this.dataGridViewWaypoints = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webViewMap = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tabPageGRAPH = new System.Windows.Forms.TabPage();
            this.radioNone = new System.Windows.Forms.RadioButton();
            this.radioYawSetpoint = new System.Windows.Forms.RadioButton();
            this.radioPitchSetpoint = new System.Windows.Forms.RadioButton();
            this.radioRollSetpoint = new System.Windows.Forms.RadioButton();
            this.radioRollPitch = new System.Windows.Forms.RadioButton();
            this.radioYaw = new System.Windows.Forms.RadioButton();
            this.radioPitch = new System.Windows.Forms.RadioButton();
            this.radioRoll = new System.Windows.Forms.RadioButton();
            this.ButtonOpenFolder = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonSaveLog = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonStartLog = new Guna.UI2.WinForms.Guna2Button();
            this.tabPageDATA = new System.Windows.Forms.TabPage();
            this.lblSetpoint = new System.Windows.Forms.Label();
            this.lblGyro = new System.Windows.Forms.Label();
            this.lblKumanda = new System.Windows.Forms.Label();
            this.lblGPS = new System.Windows.Forms.Label();
            this.labelYawSetpoint = new System.Windows.Forms.Label();
            this.labelPitchSetpoint = new System.Windows.Forms.Label();
            this.labelRollSetpoint = new System.Windows.Forms.Label();
            this.lblptchstpnt = new System.Windows.Forms.Label();
            this.lblywstpnt = new System.Windows.Forms.Label();
            this.lblrllstpnt = new System.Windows.Forms.Label();
            this.tabPagePID = new System.Windows.Forms.TabPage();
            this.btnWriteAll = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefreshAll = new Guna.UI2.WinForms.Guna2Button();
            this.groupBoxRateNorth = new System.Windows.Forms.GroupBox();
            this.ButtonNorthRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonNorthWrite = new Guna.UI2.WinForms.Guna2Button();
            this.NumericEXTRAN = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.NumericPN = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.NumericDN = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.NumericIN = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxRateEast = new System.Windows.Forms.GroupBox();
            this.ButtonEastRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonEastWrite = new Guna.UI2.WinForms.Guna2Button();
            this.NumericEXTRAE = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.NumericPE = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.NumericDE = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.NumericIE = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBoxRateHeight = new System.Windows.Forms.GroupBox();
            this.ButtonHeightRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonHeightWrite = new Guna.UI2.WinForms.Guna2Button();
            this.NumericEXTRAH = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.NumericPH = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.NumericDH = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NumericIH = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxRateYaw = new System.Windows.Forms.GroupBox();
            this.ButtonYawRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonYawWrite = new Guna.UI2.WinForms.Guna2Button();
            this.NumericEXTRAY = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.NumericPY = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labelPY = new System.Windows.Forms.Label();
            this.NumericDY = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labelIY = new System.Windows.Forms.Label();
            this.NumericIY = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labelDY = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelIMAXY = new System.Windows.Forms.Label();
            this.groupBoxRatePitch = new System.Windows.Forms.GroupBox();
            this.ButtonPitchRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonPitchWrite = new Guna.UI2.WinForms.Guna2Button();
            this.NumericIEXTRAP = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.NumericPP = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labelPP = new System.Windows.Forms.Label();
            this.NumericDP = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labelIP = new System.Windows.Forms.Label();
            this.NumericIP = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labelDP = new System.Windows.Forms.Label();
            this.labelIMAXP = new System.Windows.Forms.Label();
            this.groupBoxRateRoll = new System.Windows.Forms.GroupBox();
            this.ButtonRollRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonRollWrite = new Guna.UI2.WinForms.Guna2Button();
            this.NumericEXTRAR = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.NumericPR = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labelPR = new System.Windows.Forms.Label();
            this.NumericDR = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labelIR = new System.Windows.Forms.Label();
            this.NumericIR = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labelDR = new System.Windows.Forms.Label();
            this.labelIMAXR = new System.Windows.Forms.Label();
            this.tabPageINFO = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBoxMail = new System.Windows.Forms.PictureBox();
            this.pictureBoxInstangram = new System.Windows.Forms.PictureBox();
            this.pictureBoxLinkedn = new System.Windows.Forms.PictureBox();
            this.linkLabelSoruGorus = new System.Windows.Forms.LinkLabel();
            this.labelHkkmzda = new System.Windows.Forms.Label();
            this.linkLabelWebSitesi = new System.Windows.Forms.LinkLabel();
            this.timerGauge = new System.Windows.Forms.Timer(this.components);
            this.timerSerialCheck = new System.Windows.Forms.Timer(this.components);
            this.panelUpper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).BeginInit();
            this.TabControl.SuspendLayout();
            this.tabPageWATCH.SuspendLayout();
            this.panelMiddleAbove.SuspendLayout();
            this.panelBelow.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWaypoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webViewMap)).BeginInit();
            this.tabPageGRAPH.SuspendLayout();
            this.tabPageDATA.SuspendLayout();
            this.tabPagePID.SuspendLayout();
            this.groupBoxRateNorth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEXTRAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericIN)).BeginInit();
            this.groupBoxRateEast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEXTRAE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericIE)).BeginInit();
            this.groupBoxRateHeight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEXTRAH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericIH)).BeginInit();
            this.groupBoxRateYaw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEXTRAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericIY)).BeginInit();
            this.groupBoxRatePitch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericIEXTRAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericIP)).BeginInit();
            this.groupBoxRateRoll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEXTRAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericIR)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInstangram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLinkedn)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUpper
            // 
            this.panelUpper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.panelUpper.Controls.Add(this.ButtonDisconnect);
            this.panelUpper.Controls.Add(this.ButtonConnect);
            this.panelUpper.Controls.Add(this.ComboBoxPorts);
            this.panelUpper.Controls.Add(this.ComboBoxBaudRates);
            this.panelUpper.Controls.Add(this.labelASPANGORUND);
            this.panelUpper.Controls.Add(this.pictureBoxGrey);
            this.panelUpper.Controls.Add(this.pictureBoxGreen);
            this.panelUpper.Controls.Add(this.labelNoConnection);
            this.panelUpper.Controls.Add(this.labelConnected);
            this.panelUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpper.Location = new System.Drawing.Point(0, 0);
            this.panelUpper.Name = "panelUpper";
            this.panelUpper.Size = new System.Drawing.Size(1969, 104);
            this.panelUpper.TabIndex = 3;
            // 
            // ButtonDisconnect
            // 
            this.ButtonDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDisconnect.Animated = true;
            this.ButtonDisconnect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonDisconnect.BorderRadius = 10;
            this.ButtonDisconnect.BorderThickness = 1;
            this.ButtonDisconnect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonDisconnect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonDisconnect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonDisconnect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonDisconnect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ButtonDisconnect.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.ButtonDisconnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonDisconnect.Location = new System.Drawing.Point(1661, 19);
            this.ButtonDisconnect.Name = "ButtonDisconnect";
            this.ButtonDisconnect.PressedColor = System.Drawing.Color.MintCream;
            this.ButtonDisconnect.Size = new System.Drawing.Size(254, 62);
            this.ButtonDisconnect.TabIndex = 66;
            this.ButtonDisconnect.Text = "DISCONNECT";
            this.ButtonDisconnect.Click += new System.EventHandler(this.ButtonDisconnect_Click_1);
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonConnect.Animated = true;
            this.ButtonConnect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonConnect.BorderRadius = 10;
            this.ButtonConnect.BorderThickness = 1;
            this.ButtonConnect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonConnect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonConnect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonConnect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonConnect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ButtonConnect.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.ButtonConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonConnect.IndicateFocus = true;
            this.ButtonConnect.Location = new System.Drawing.Point(1423, 19);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.PressedColor = System.Drawing.Color.MintCream;
            this.ButtonConnect.Size = new System.Drawing.Size(217, 62);
            this.ButtonConnect.TabIndex = 65;
            this.ButtonConnect.Text = "CONNECT";
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click_1);
            // 
            // ComboBoxPorts
            // 
            this.ComboBoxPorts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxPorts.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxPorts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ComboBoxPorts.BorderRadius = 10;
            this.ComboBoxPorts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPorts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ComboBoxPorts.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxPorts.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxPorts.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.ComboBoxPorts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ComboBoxPorts.ItemHeight = 30;
            this.ComboBoxPorts.Location = new System.Drawing.Point(1224, 32);
            this.ComboBoxPorts.Name = "ComboBoxPorts";
            this.ComboBoxPorts.Size = new System.Drawing.Size(172, 36);
            this.ComboBoxPorts.TabIndex = 64;
            // 
            // ComboBoxBaudRates
            // 
            this.ComboBoxBaudRates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxBaudRates.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxBaudRates.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ComboBoxBaudRates.BorderRadius = 10;
            this.ComboBoxBaudRates.DisplayMember = "KKK";
            this.ComboBoxBaudRates.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxBaudRates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxBaudRates.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ComboBoxBaudRates.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxBaudRates.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxBaudRates.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.ComboBoxBaudRates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ComboBoxBaudRates.ItemHeight = 30;
            this.ComboBoxBaudRates.Items.AddRange(new object[] {
            "115200",
            "57600"});
            this.ComboBoxBaudRates.ItemsAppearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComboBoxBaudRates.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ComboBoxBaudRates.Location = new System.Drawing.Point(1004, 32);
            this.ComboBoxBaudRates.Name = "ComboBoxBaudRates";
            this.ComboBoxBaudRates.Size = new System.Drawing.Size(172, 36);
            this.ComboBoxBaudRates.TabIndex = 62;
            // 
            // labelASPANGORUND
            // 
            this.labelASPANGORUND.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelASPANGORUND.AutoSize = true;
            this.labelASPANGORUND.Font = new System.Drawing.Font("Nirmala UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelASPANGORUND.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.labelASPANGORUND.Location = new System.Drawing.Point(3, 19);
            this.labelASPANGORUND.Name = "labelASPANGORUND";
            this.labelASPANGORUND.Size = new System.Drawing.Size(377, 62);
            this.labelASPANGORUND.TabIndex = 31;
            this.labelASPANGORUND.Text = "ASPAN GROUND";
            // 
            // pictureBoxGrey
            // 
            this.pictureBoxGrey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxGrey.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGrey.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGrey.Image")));
            this.pictureBoxGrey.Location = new System.Drawing.Point(687, 34);
            this.pictureBoxGrey.Name = "pictureBoxGrey";
            this.pictureBoxGrey.Size = new System.Drawing.Size(32, 30);
            this.pictureBoxGrey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGrey.TabIndex = 27;
            this.pictureBoxGrey.TabStop = false;
            // 
            // pictureBoxGreen
            // 
            this.pictureBoxGreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxGreen.BackColor = System.Drawing.Color.DimGray;
            this.pictureBoxGreen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGreen.Image")));
            this.pictureBoxGreen.Location = new System.Drawing.Point(687, 34);
            this.pictureBoxGreen.Name = "pictureBoxGreen";
            this.pictureBoxGreen.Size = new System.Drawing.Size(32, 30);
            this.pictureBoxGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGreen.TabIndex = 7;
            this.pictureBoxGreen.TabStop = false;
            // 
            // labelNoConnection
            // 
            this.labelNoConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNoConnection.AutoSize = true;
            this.labelNoConnection.BackColor = System.Drawing.Color.Transparent;
            this.labelNoConnection.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.labelNoConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.labelNoConnection.Location = new System.Drawing.Point(725, 32);
            this.labelNoConnection.Name = "labelNoConnection";
            this.labelNoConnection.Size = new System.Drawing.Size(197, 31);
            this.labelNoConnection.TabIndex = 5;
            this.labelNoConnection.Text = "NO CONNECTION";
            // 
            // labelConnected
            // 
            this.labelConnected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConnected.AutoSize = true;
            this.labelConnected.BackColor = System.Drawing.Color.Transparent;
            this.labelConnected.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.labelConnected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.labelConnected.Location = new System.Drawing.Point(725, 32);
            this.labelConnected.Name = "labelConnected";
            this.labelConnected.Size = new System.Drawing.Size(145, 31);
            this.labelConnected.TabIndex = 6;
            this.labelConnected.Text = "CONNECTED";
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // ChartRollPitchYaw
            // 
            this.ChartRollPitchYaw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ChartRollPitchYaw.BackColorTransparent = true;
            this.ChartRollPitchYaw.Cursor = System.Windows.Forms.Cursors.Default;
            this.ChartRollPitchYaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChartRollPitchYaw.ForeColor = System.Drawing.Color.Red;
            this.ChartRollPitchYaw.Location = new System.Drawing.Point(104, 240);
            this.ChartRollPitchYaw.Name = "ChartRollPitchYaw";
            this.ChartRollPitchYaw.Size = new System.Drawing.Size(1649, 336);
            this.ChartRollPitchYaw.TabIndex = 2;
            this.ChartRollPitchYaw.Text = "ChartRollPitchYaw";
            // 
            // labelLongitude
            // 
            this.labelLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLongitude.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelLongitude.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelLongitude.Location = new System.Drawing.Point(575, 746);
            this.labelLongitude.Name = "labelLongitude";
            this.labelLongitude.Size = new System.Drawing.Size(291, 62);
            this.labelLongitude.TabIndex = 47;
            this.labelLongitude.Text = "0";
            this.labelLongitude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labellngtd
            // 
            this.labellngtd.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.labellngtd.ForeColor = System.Drawing.Color.Gainsboro;
            this.labellngtd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labellngtd.Location = new System.Drawing.Point(300, 749);
            this.labellngtd.Name = "labellngtd";
            this.labellngtd.Size = new System.Drawing.Size(216, 59);
            this.labellngtd.TabIndex = 46;
            this.labellngtd.Text = "Longitude";
            this.labellngtd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblroll
            // 
            this.lblroll.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroll.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblroll.Location = new System.Drawing.Point(300, 84);
            this.lblroll.Name = "lblroll";
            this.lblroll.Size = new System.Drawing.Size(124, 59);
            this.lblroll.TabIndex = 38;
            this.lblroll.Text = "Roll";
            this.lblroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblpitch
            // 
            this.lblpitch.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpitch.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblpitch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblpitch.Location = new System.Drawing.Point(300, 152);
            this.lblpitch.Name = "lblpitch";
            this.lblpitch.Size = new System.Drawing.Size(124, 59);
            this.lblpitch.TabIndex = 36;
            this.lblpitch.Text = "Pitch";
            this.lblpitch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblrh
            // 
            this.lblrh.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblrh.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblrh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblrh.Location = new System.Drawing.Point(300, 457);
            this.lblrh.Name = "lblrh";
            this.lblrh.Size = new System.Drawing.Size(81, 59);
            this.lblrh.TabIndex = 39;
            this.lblrh.Text = "RH";
            this.lblrh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbllh
            // 
            this.lbllh.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.lbllh.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbllh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbllh.Location = new System.Drawing.Point(300, 519);
            this.lbllh.Name = "lbllh";
            this.lbllh.Size = new System.Drawing.Size(81, 59);
            this.lbllh.TabIndex = 37;
            this.lbllh.Text = "LH";
            this.lbllh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLatitude
            // 
            this.labelLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLatitude.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelLatitude.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelLatitude.Location = new System.Drawing.Point(575, 687);
            this.labelLatitude.Name = "labelLatitude";
            this.labelLatitude.Size = new System.Drawing.Size(291, 62);
            this.labelLatitude.TabIndex = 44;
            this.labelLatitude.Text = "0";
            this.labelLatitude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRV
            // 
            this.labelRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRV.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelRV.Location = new System.Drawing.Point(510, 392);
            this.labelRV.Name = "labelRV";
            this.labelRV.Size = new System.Drawing.Size(232, 62);
            this.labelRV.TabIndex = 31;
            this.labelRV.Text = "0";
            this.labelRV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbllttd
            // 
            this.lbllttd.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.lbllttd.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbllttd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbllttd.Location = new System.Drawing.Point(300, 690);
            this.lbllttd.Name = "lbllttd";
            this.lbllttd.Size = new System.Drawing.Size(204, 59);
            this.lbllttd.TabIndex = 43;
            this.lbllttd.Text = "Latitude";
            this.lbllttd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLH
            // 
            this.labelLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLH.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelLH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelLH.Location = new System.Drawing.Point(510, 516);
            this.labelLH.Name = "labelLH";
            this.labelLH.Size = new System.Drawing.Size(232, 62);
            this.labelLH.TabIndex = 35;
            this.labelLH.Text = "0";
            this.labelLH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelYaw
            // 
            this.labelYaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYaw.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelYaw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelYaw.Location = new System.Drawing.Point(510, 211);
            this.labelYaw.Name = "labelYaw";
            this.labelYaw.Size = new System.Drawing.Size(232, 62);
            this.labelYaw.TabIndex = 30;
            this.labelYaw.Text = "0";
            this.labelYaw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblrv
            // 
            this.lblrv.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblrv.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblrv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblrv.Location = new System.Drawing.Point(300, 395);
            this.lblrv.Name = "lblrv";
            this.lblrv.Size = new System.Drawing.Size(81, 59);
            this.lblrv.TabIndex = 41;
            this.lblrv.Text = "RV";
            this.lblrv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblaltitude
            // 
            this.lblaltitude.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblaltitude.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblaltitude.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblaltitude.Location = new System.Drawing.Point(852, 386);
            this.lblaltitude.Name = "lblaltitude";
            this.lblaltitude.Size = new System.Drawing.Size(148, 59);
            this.lblaltitude.TabIndex = 42;
            this.lblaltitude.Text = "Altitude";
            this.lblaltitude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRoll
            // 
            this.labelRoll.BackColor = System.Drawing.Color.Transparent;
            this.labelRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoll.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRoll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelRoll.Location = new System.Drawing.Point(510, 80);
            this.labelRoll.Name = "labelRoll";
            this.labelRoll.Size = new System.Drawing.Size(232, 62);
            this.labelRoll.TabIndex = 33;
            this.labelRoll.Text = "0";
            this.labelRoll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAltitude
            // 
            this.labelAltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAltitude.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelAltitude.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAltitude.Location = new System.Drawing.Point(1119, 383);
            this.labelAltitude.Name = "labelAltitude";
            this.labelAltitude.Size = new System.Drawing.Size(344, 62);
            this.labelAltitude.TabIndex = 34;
            this.labelAltitude.Text = "0";
            this.labelAltitude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRH
            // 
            this.labelRH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRH.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelRH.Location = new System.Drawing.Point(510, 454);
            this.labelRH.Name = "labelRH";
            this.labelRH.Size = new System.Drawing.Size(232, 62);
            this.labelRH.TabIndex = 32;
            this.labelRH.Text = "0";
            this.labelRH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblyaw
            // 
            this.lblyaw.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyaw.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblyaw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblyaw.Location = new System.Drawing.Point(300, 214);
            this.lblyaw.Name = "lblyaw";
            this.lblyaw.Size = new System.Drawing.Size(124, 59);
            this.lblyaw.TabIndex = 40;
            this.lblyaw.Text = "Yaw";
            this.lblyaw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPitch
            // 
            this.labelPitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPitch.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelPitch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPitch.Location = new System.Drawing.Point(510, 149);
            this.labelPitch.Name = "labelPitch";
            this.labelPitch.Size = new System.Drawing.Size(232, 62);
            this.labelPitch.TabIndex = 29;
            this.labelPitch.Text = "0";
            this.labelPitch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerGraphic
            // 
            this.timerGraphic.Interval = 125;
            this.timerGraphic.Tick += new System.EventHandler(this.timerGraphic_Tick);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPageWATCH);
            this.TabControl.Controls.Add(this.tabPageGRAPH);
            this.TabControl.Controls.Add(this.tabPageDATA);
            this.TabControl.Controls.Add(this.tabPagePID);
            this.TabControl.Controls.Add(this.tabPageINFO);
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TabControl.ItemSize = new System.Drawing.Size(180, 60);
            this.TabControl.Location = new System.Drawing.Point(0, 104);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1969, 949);
            this.TabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.TabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.TabControl.TabButtonHoverState.Font = new System.Drawing.Font("Nirmala UI Semilight", 16.2F);
            this.TabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.Snow;
            this.TabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabControl.TabButtonIdleState.Font = new System.Drawing.Font("Nirmala UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.TabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.TabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.TabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.Snow;
            this.TabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.TabControl.TabButtonSize = new System.Drawing.Size(180, 60);
            this.TabControl.TabIndex = 48;
            this.TabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabControl.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPageWATCH
            // 
            this.tabPageWATCH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.tabPageWATCH.Controls.Add(this.panelMiddleAbove);
            this.tabPageWATCH.Location = new System.Drawing.Point(4, 64);
            this.tabPageWATCH.Name = "tabPageWATCH";
            this.tabPageWATCH.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWATCH.Size = new System.Drawing.Size(1961, 881);
            this.tabPageWATCH.TabIndex = 0;
            this.tabPageWATCH.Text = "WATCH";
            // 
            // panelMiddleAbove
            // 
            this.panelMiddleAbove.ColumnCount = 2;
            this.panelMiddleAbove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.panelMiddleAbove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.panelMiddleAbove.Controls.Add(this.panelBelow, 0, 1);
            this.panelMiddleAbove.Controls.Add(this.panelLeft, 0, 0);
            this.panelMiddleAbove.Controls.Add(this.dataGridViewWaypoints, 1, 1);
            this.panelMiddleAbove.Controls.Add(this.webViewMap, 1, 0);
            this.panelMiddleAbove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddleAbove.Location = new System.Drawing.Point(3, 3);
            this.panelMiddleAbove.Name = "panelMiddleAbove";
            this.panelMiddleAbove.RowCount = 2;
            this.panelMiddleAbove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.panelMiddleAbove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelMiddleAbove.Size = new System.Drawing.Size(1955, 875);
            this.panelMiddleAbove.TabIndex = 37;
            // 
            // panelBelow
            // 
            this.panelBelow.Controls.Add(this.panelBottomLeft);
            this.panelBelow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBelow.Location = new System.Drawing.Point(3, 659);
            this.panelBelow.Name = "panelBelow";
            this.panelBelow.Size = new System.Drawing.Size(776, 213);
            this.panelBelow.TabIndex = 40;
            // 
            // panelBottomLeft
            // 
            this.panelBottomLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottomLeft.Location = new System.Drawing.Point(0, 0);
            this.panelBottomLeft.Name = "panelBottomLeft";
            this.panelBottomLeft.Size = new System.Drawing.Size(776, 213);
            this.panelBottomLeft.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.ButtonDeleteWaypoint);
            this.panelLeft.Controls.Add(this.headingIndicatorInstrumentControl1);
            this.panelLeft.Controls.Add(this.attitudeIndicatorInstrumentControl1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(3, 3);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(776, 650);
            this.panelLeft.TabIndex = 41;
            // 
            // ButtonDeleteWaypoint
            // 
            this.ButtonDeleteWaypoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDeleteWaypoint.Animated = true;
            this.ButtonDeleteWaypoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ButtonDeleteWaypoint.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonDeleteWaypoint.BorderRadius = 10;
            this.ButtonDeleteWaypoint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonDeleteWaypoint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonDeleteWaypoint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonDeleteWaypoint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonDeleteWaypoint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ButtonDeleteWaypoint.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeleteWaypoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonDeleteWaypoint.IndicateFocus = true;
            this.ButtonDeleteWaypoint.Location = new System.Drawing.Point(591, 516);
            this.ButtonDeleteWaypoint.Name = "ButtonDeleteWaypoint";
            this.ButtonDeleteWaypoint.PressedColor = System.Drawing.Color.MintCream;
            this.ButtonDeleteWaypoint.Size = new System.Drawing.Size(160, 114);
            this.ButtonDeleteWaypoint.TabIndex = 68;
            this.ButtonDeleteWaypoint.Text = "Delete Last Point";
            this.ButtonDeleteWaypoint.Click += new System.EventHandler(this.ButtonDeleteWaypoint_Click);
            // 
            // headingIndicatorInstrumentControl1
            // 
            this.headingIndicatorInstrumentControl1.Location = new System.Drawing.Point(389, 15);
            this.headingIndicatorInstrumentControl1.Name = "headingIndicatorInstrumentControl1";
            this.headingIndicatorInstrumentControl1.Size = new System.Drawing.Size(356, 343);
            this.headingIndicatorInstrumentControl1.TabIndex = 65;
            this.headingIndicatorInstrumentControl1.Text = "headingIndicatorInstrumentControl1";
            // 
            // attitudeIndicatorInstrumentControl1
            // 
            this.attitudeIndicatorInstrumentControl1.Location = new System.Drawing.Point(12, 15);
            this.attitudeIndicatorInstrumentControl1.Name = "attitudeIndicatorInstrumentControl1";
            this.attitudeIndicatorInstrumentControl1.Size = new System.Drawing.Size(358, 343);
            this.attitudeIndicatorInstrumentControl1.TabIndex = 64;
            this.attitudeIndicatorInstrumentControl1.Text = "attitudeIndicatorInstrumentControl1";
            // 
            // dataGridViewWaypoints
            // 
            this.dataGridViewWaypoints.AllowUserToAddRows = false;
            this.dataGridViewWaypoints.AllowUserToDeleteRows = false;
            this.dataGridViewWaypoints.AllowUserToResizeColumns = false;
            this.dataGridViewWaypoints.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dataGridViewWaypoints.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewWaypoints.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.dataGridViewWaypoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGridViewWaypoints.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewWaypoints.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewWaypoints.ColumnHeadersHeight = 35;
            this.dataGridViewWaypoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewWaypoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idx,
            this.Type,
            this.Altitude,
            this.Longitude,
            this.Latitude});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewWaypoints.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewWaypoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWaypoints.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.dataGridViewWaypoints.Location = new System.Drawing.Point(785, 659);
            this.dataGridViewWaypoints.Name = "dataGridViewWaypoints";
            this.dataGridViewWaypoints.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewWaypoints.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewWaypoints.RowHeadersVisible = false;
            this.dataGridViewWaypoints.RowHeadersWidth = 51;
            this.dataGridViewWaypoints.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Snow;
            this.dataGridViewWaypoints.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewWaypoints.RowTemplate.Height = 24;
            this.dataGridViewWaypoints.Size = new System.Drawing.Size(1167, 213);
            this.dataGridViewWaypoints.TabIndex = 43;
            this.dataGridViewWaypoints.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewWaypoints.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewWaypoints.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewWaypoints.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewWaypoints.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewWaypoints.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.dataGridViewWaypoints.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.dataGridViewWaypoints.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Snow;
            this.dataGridViewWaypoints.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewWaypoints.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridViewWaypoints.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.dataGridViewWaypoints.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewWaypoints.ThemeStyle.HeaderStyle.Height = 35;
            this.dataGridViewWaypoints.ThemeStyle.ReadOnly = true;
            this.dataGridViewWaypoints.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Snow;
            this.dataGridViewWaypoints.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewWaypoints.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridViewWaypoints.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewWaypoints.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridViewWaypoints.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Snow;
            this.dataGridViewWaypoints.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // idx
            // 
            this.idx.HeaderText = "idx";
            this.idx.MinimumWidth = 6;
            this.idx.Name = "idx";
            this.idx.ReadOnly = true;
            this.idx.Visible = false;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Altitude
            // 
            this.Altitude.HeaderText = "Altitude";
            this.Altitude.MinimumWidth = 6;
            this.Altitude.Name = "Altitude";
            this.Altitude.ReadOnly = true;
            // 
            // Longitude
            // 
            this.Longitude.HeaderText = "Longitude";
            this.Longitude.MinimumWidth = 6;
            this.Longitude.Name = "Longitude";
            this.Longitude.ReadOnly = true;
            // 
            // Latitude
            // 
            this.Latitude.HeaderText = "Latitude";
            this.Latitude.MinimumWidth = 6;
            this.Latitude.Name = "Latitude";
            this.Latitude.ReadOnly = true;
            // 
            // webViewMap
            // 
            this.webViewMap.AllowExternalDrop = true;
            this.webViewMap.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.webViewMap.CreationProperties = null;
            this.webViewMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.webViewMap.DefaultBackgroundColor = System.Drawing.Color.Transparent;
            this.webViewMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webViewMap.Location = new System.Drawing.Point(785, 3);
            this.webViewMap.Name = "webViewMap";
            this.webViewMap.Size = new System.Drawing.Size(1167, 650);
            this.webViewMap.TabIndex = 38;
            this.webViewMap.ZoomFactor = 1D;
            this.webViewMap.WebMessageReceived += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs>(this.webViewMap_WebMessageReceived);
            // 
            // tabPageGRAPH
            // 
            this.tabPageGRAPH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.tabPageGRAPH.Controls.Add(this.radioNone);
            this.tabPageGRAPH.Controls.Add(this.radioYawSetpoint);
            this.tabPageGRAPH.Controls.Add(this.radioPitchSetpoint);
            this.tabPageGRAPH.Controls.Add(this.radioRollSetpoint);
            this.tabPageGRAPH.Controls.Add(this.radioRollPitch);
            this.tabPageGRAPH.Controls.Add(this.radioYaw);
            this.tabPageGRAPH.Controls.Add(this.radioPitch);
            this.tabPageGRAPH.Controls.Add(this.radioRoll);
            this.tabPageGRAPH.Controls.Add(this.ButtonOpenFolder);
            this.tabPageGRAPH.Controls.Add(this.ButtonSaveLog);
            this.tabPageGRAPH.Controls.Add(this.ButtonStartLog);
            this.tabPageGRAPH.Controls.Add(this.ChartRollPitchYaw);
            this.tabPageGRAPH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPageGRAPH.Location = new System.Drawing.Point(4, 64);
            this.tabPageGRAPH.Name = "tabPageGRAPH";
            this.tabPageGRAPH.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGRAPH.Size = new System.Drawing.Size(1961, 881);
            this.tabPageGRAPH.TabIndex = 1;
            this.tabPageGRAPH.Text = "GRAPH";
            // 
            // radioNone
            // 
            this.radioNone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioNone.AutoSize = true;
            this.radioNone.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNone.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioNone.Location = new System.Drawing.Point(587, 76);
            this.radioNone.Name = "radioNone";
            this.radioNone.Size = new System.Drawing.Size(95, 39);
            this.radioNone.TabIndex = 96;
            this.radioNone.TabStop = true;
            this.radioNone.Text = "None";
            this.radioNone.UseVisualStyleBackColor = true;
            this.radioNone.CheckedChanged += new System.EventHandler(this.radioNone_CheckedChanged);
            // 
            // radioYawSetpoint
            // 
            this.radioYawSetpoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioYawSetpoint.AutoSize = true;
            this.radioYawSetpoint.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioYawSetpoint.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioYawSetpoint.Location = new System.Drawing.Point(342, 121);
            this.radioYawSetpoint.Name = "radioYawSetpoint";
            this.radioYawSetpoint.Size = new System.Drawing.Size(178, 39);
            this.radioYawSetpoint.TabIndex = 95;
            this.radioYawSetpoint.TabStop = true;
            this.radioYawSetpoint.Text = "Yaw/Setpoint";
            this.radioYawSetpoint.UseVisualStyleBackColor = true;
            this.radioYawSetpoint.CheckedChanged += new System.EventHandler(this.radioYawSetpoint_CheckedChanged);
            // 
            // radioPitchSetpoint
            // 
            this.radioPitchSetpoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioPitchSetpoint.AutoSize = true;
            this.radioPitchSetpoint.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPitchSetpoint.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioPitchSetpoint.Location = new System.Drawing.Point(345, 76);
            this.radioPitchSetpoint.Name = "radioPitchSetpoint";
            this.radioPitchSetpoint.Size = new System.Drawing.Size(188, 39);
            this.radioPitchSetpoint.TabIndex = 94;
            this.radioPitchSetpoint.TabStop = true;
            this.radioPitchSetpoint.Text = "Pitch/Setpoint";
            this.radioPitchSetpoint.UseVisualStyleBackColor = true;
            this.radioPitchSetpoint.CheckedChanged += new System.EventHandler(this.radioPitchSetpoint_CheckedChanged);
            // 
            // radioRollSetpoint
            // 
            this.radioRollSetpoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioRollSetpoint.AutoSize = true;
            this.radioRollSetpoint.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRollSetpoint.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioRollSetpoint.Location = new System.Drawing.Point(344, 31);
            this.radioRollSetpoint.Name = "radioRollSetpoint";
            this.radioRollSetpoint.Size = new System.Drawing.Size(174, 39);
            this.radioRollSetpoint.TabIndex = 93;
            this.radioRollSetpoint.TabStop = true;
            this.radioRollSetpoint.Text = "Roll/Setpoint";
            this.radioRollSetpoint.UseVisualStyleBackColor = true;
            this.radioRollSetpoint.CheckedChanged += new System.EventHandler(this.radioRollSetpoint_CheckedChanged);
            // 
            // radioRollPitch
            // 
            this.radioRollPitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioRollPitch.AutoSize = true;
            this.radioRollPitch.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRollPitch.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioRollPitch.Location = new System.Drawing.Point(599, 31);
            this.radioRollPitch.Name = "radioRollPitch";
            this.radioRollPitch.Size = new System.Drawing.Size(137, 39);
            this.radioRollPitch.TabIndex = 92;
            this.radioRollPitch.TabStop = true;
            this.radioRollPitch.Text = "Roll/Pitch";
            this.radioRollPitch.UseVisualStyleBackColor = true;
            this.radioRollPitch.CheckedChanged += new System.EventHandler(this.radioRollPitch_CheckedChanged);
            // 
            // radioYaw
            // 
            this.radioYaw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioYaw.AutoSize = true;
            this.radioYaw.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioYaw.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioYaw.Location = new System.Drawing.Point(152, 121);
            this.radioYaw.Name = "radioYaw";
            this.radioYaw.Size = new System.Drawing.Size(79, 39);
            this.radioYaw.TabIndex = 91;
            this.radioYaw.TabStop = true;
            this.radioYaw.Text = "Yaw";
            this.radioYaw.UseVisualStyleBackColor = true;
            this.radioYaw.CheckedChanged += new System.EventHandler(this.radioYaw_CheckedChanged);
            // 
            // radioPitch
            // 
            this.radioPitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioPitch.AutoSize = true;
            this.radioPitch.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPitch.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioPitch.Location = new System.Drawing.Point(155, 76);
            this.radioPitch.Name = "radioPitch";
            this.radioPitch.Size = new System.Drawing.Size(89, 39);
            this.radioPitch.TabIndex = 90;
            this.radioPitch.TabStop = true;
            this.radioPitch.Text = "Pitch";
            this.radioPitch.UseVisualStyleBackColor = true;
            this.radioPitch.CheckedChanged += new System.EventHandler(this.radioPitch_CheckedChanged);
            // 
            // radioRoll
            // 
            this.radioRoll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioRoll.AutoSize = true;
            this.radioRoll.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRoll.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioRoll.Location = new System.Drawing.Point(154, 31);
            this.radioRoll.Name = "radioRoll";
            this.radioRoll.Size = new System.Drawing.Size(75, 39);
            this.radioRoll.TabIndex = 89;
            this.radioRoll.TabStop = true;
            this.radioRoll.Text = "Roll";
            this.radioRoll.UseVisualStyleBackColor = true;
            this.radioRoll.CheckedChanged += new System.EventHandler(this.radioRoll_CheckedChanged);
            // 
            // ButtonOpenFolder
            // 
            this.ButtonOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOpenFolder.Animated = true;
            this.ButtonOpenFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ButtonOpenFolder.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonOpenFolder.BorderRadius = 10;
            this.ButtonOpenFolder.BorderThickness = 2;
            this.ButtonOpenFolder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonOpenFolder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonOpenFolder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonOpenFolder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonOpenFolder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ButtonOpenFolder.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.ButtonOpenFolder.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonOpenFolder.Location = new System.Drawing.Point(831, 152);
            this.ButtonOpenFolder.Name = "ButtonOpenFolder";
            this.ButtonOpenFolder.PressedColor = System.Drawing.Color.Teal;
            this.ButtonOpenFolder.Size = new System.Drawing.Size(255, 53);
            this.ButtonOpenFolder.TabIndex = 88;
            this.ButtonOpenFolder.Text = "Open Folder";
            this.ButtonOpenFolder.Click += new System.EventHandler(this.ButtonOpenFolder_Click);
            // 
            // ButtonSaveLog
            // 
            this.ButtonSaveLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSaveLog.Animated = true;
            this.ButtonSaveLog.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSaveLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonSaveLog.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonSaveLog.BorderRadius = 10;
            this.ButtonSaveLog.BorderThickness = 2;
            this.ButtonSaveLog.CustomBorderColor = System.Drawing.Color.White;
            this.ButtonSaveLog.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSaveLog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSaveLog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonSaveLog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonSaveLog.FillColor = System.Drawing.Color.Transparent;
            this.ButtonSaveLog.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.ButtonSaveLog.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonSaveLog.Location = new System.Drawing.Point(831, 92);
            this.ButtonSaveLog.Name = "ButtonSaveLog";
            this.ButtonSaveLog.PressedColor = System.Drawing.Color.Teal;
            this.ButtonSaveLog.Size = new System.Drawing.Size(255, 54);
            this.ButtonSaveLog.TabIndex = 58;
            this.ButtonSaveLog.Text = "Save Log";
            this.ButtonSaveLog.Click += new System.EventHandler(this.ButtonSaveLog_Click);
            // 
            // ButtonStartLog
            // 
            this.ButtonStartLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonStartLog.Animated = true;
            this.ButtonStartLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ButtonStartLog.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonStartLog.BorderRadius = 10;
            this.ButtonStartLog.BorderThickness = 2;
            this.ButtonStartLog.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonStartLog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonStartLog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonStartLog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonStartLog.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ButtonStartLog.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.ButtonStartLog.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonStartLog.Location = new System.Drawing.Point(831, 31);
            this.ButtonStartLog.Name = "ButtonStartLog";
            this.ButtonStartLog.PressedColor = System.Drawing.Color.Teal;
            this.ButtonStartLog.Size = new System.Drawing.Size(255, 55);
            this.ButtonStartLog.TabIndex = 56;
            this.ButtonStartLog.Text = "Start Log";
            this.ButtonStartLog.Click += new System.EventHandler(this.ButtonStartLog_Click);
            // 
            // tabPageDATA
            // 
            this.tabPageDATA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.tabPageDATA.Controls.Add(this.lblSetpoint);
            this.tabPageDATA.Controls.Add(this.lblGyro);
            this.tabPageDATA.Controls.Add(this.lblKumanda);
            this.tabPageDATA.Controls.Add(this.lblGPS);
            this.tabPageDATA.Controls.Add(this.labelYawSetpoint);
            this.tabPageDATA.Controls.Add(this.labelPitchSetpoint);
            this.tabPageDATA.Controls.Add(this.labelRollSetpoint);
            this.tabPageDATA.Controls.Add(this.lblptchstpnt);
            this.tabPageDATA.Controls.Add(this.lblywstpnt);
            this.tabPageDATA.Controls.Add(this.lblrllstpnt);
            this.tabPageDATA.Controls.Add(this.lblrv);
            this.tabPageDATA.Controls.Add(this.labelLongitude);
            this.tabPageDATA.Controls.Add(this.labelPitch);
            this.tabPageDATA.Controls.Add(this.labellngtd);
            this.tabPageDATA.Controls.Add(this.lblyaw);
            this.tabPageDATA.Controls.Add(this.labelRH);
            this.tabPageDATA.Controls.Add(this.lblroll);
            this.tabPageDATA.Controls.Add(this.labelAltitude);
            this.tabPageDATA.Controls.Add(this.lblpitch);
            this.tabPageDATA.Controls.Add(this.labelRoll);
            this.tabPageDATA.Controls.Add(this.lblaltitude);
            this.tabPageDATA.Controls.Add(this.lblrh);
            this.tabPageDATA.Controls.Add(this.labelYaw);
            this.tabPageDATA.Controls.Add(this.lbllh);
            this.tabPageDATA.Controls.Add(this.labelLH);
            this.tabPageDATA.Controls.Add(this.labelLatitude);
            this.tabPageDATA.Controls.Add(this.lbllttd);
            this.tabPageDATA.Controls.Add(this.labelRV);
            this.tabPageDATA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPageDATA.ForeColor = System.Drawing.Color.Gainsboro;
            this.tabPageDATA.Location = new System.Drawing.Point(4, 64);
            this.tabPageDATA.Name = "tabPageDATA";
            this.tabPageDATA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDATA.Size = new System.Drawing.Size(1961, 881);
            this.tabPageDATA.TabIndex = 2;
            this.tabPageDATA.Text = "DATA";
            // 
            // lblSetpoint
            // 
            this.lblSetpoint.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblSetpoint.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSetpoint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSetpoint.Location = new System.Drawing.Point(852, 25);
            this.lblSetpoint.Name = "lblSetpoint";
            this.lblSetpoint.Size = new System.Drawing.Size(248, 59);
            this.lblSetpoint.TabIndex = 80;
            this.lblSetpoint.Text = "Setpoint";
            this.lblSetpoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGyro
            // 
            this.lblGyro.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblGyro.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGyro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGyro.Location = new System.Drawing.Point(300, 21);
            this.lblGyro.Name = "lblGyro";
            this.lblGyro.Size = new System.Drawing.Size(248, 59);
            this.lblGyro.TabIndex = 79;
            this.lblGyro.Text = "GYRO";
            this.lblGyro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKumanda
            // 
            this.lblKumanda.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblKumanda.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblKumanda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblKumanda.Location = new System.Drawing.Point(299, 336);
            this.lblKumanda.Name = "lblKumanda";
            this.lblKumanda.Size = new System.Drawing.Size(217, 59);
            this.lblKumanda.TabIndex = 78;
            this.lblKumanda.Text = "RC CONTROL";
            this.lblKumanda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGPS
            // 
            this.lblGPS.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblGPS.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGPS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGPS.Location = new System.Drawing.Point(299, 632);
            this.lblGPS.Name = "lblGPS";
            this.lblGPS.Size = new System.Drawing.Size(148, 59);
            this.lblGPS.TabIndex = 77;
            this.lblGPS.Text = "GPS";
            this.lblGPS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelYawSetpoint
            // 
            this.labelYawSetpoint.BackColor = System.Drawing.Color.Transparent;
            this.labelYawSetpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYawSetpoint.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelYawSetpoint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelYawSetpoint.Location = new System.Drawing.Point(1119, 201);
            this.labelYawSetpoint.Name = "labelYawSetpoint";
            this.labelYawSetpoint.Size = new System.Drawing.Size(264, 62);
            this.labelYawSetpoint.TabIndex = 76;
            this.labelYawSetpoint.Text = "0";
            this.labelYawSetpoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPitchSetpoint
            // 
            this.labelPitchSetpoint.BackColor = System.Drawing.Color.Transparent;
            this.labelPitchSetpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPitchSetpoint.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelPitchSetpoint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPitchSetpoint.Location = new System.Drawing.Point(1119, 139);
            this.labelPitchSetpoint.Name = "labelPitchSetpoint";
            this.labelPitchSetpoint.Size = new System.Drawing.Size(264, 62);
            this.labelPitchSetpoint.TabIndex = 75;
            this.labelPitchSetpoint.Text = "0";
            this.labelPitchSetpoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRollSetpoint
            // 
            this.labelRollSetpoint.BackColor = System.Drawing.Color.Transparent;
            this.labelRollSetpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRollSetpoint.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRollSetpoint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelRollSetpoint.Location = new System.Drawing.Point(1119, 84);
            this.labelRollSetpoint.Name = "labelRollSetpoint";
            this.labelRollSetpoint.Size = new System.Drawing.Size(264, 62);
            this.labelRollSetpoint.TabIndex = 74;
            this.labelRollSetpoint.Text = "0";
            this.labelRollSetpoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblptchstpnt
            // 
            this.lblptchstpnt.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblptchstpnt.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblptchstpnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblptchstpnt.Location = new System.Drawing.Point(852, 142);
            this.lblptchstpnt.Name = "lblptchstpnt";
            this.lblptchstpnt.Size = new System.Drawing.Size(272, 59);
            this.lblptchstpnt.TabIndex = 73;
            this.lblptchstpnt.Text = "Pitch Setpoint";
            this.lblptchstpnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblywstpnt
            // 
            this.lblywstpnt.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblywstpnt.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblywstpnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblywstpnt.Location = new System.Drawing.Point(852, 204);
            this.lblywstpnt.Name = "lblywstpnt";
            this.lblywstpnt.Size = new System.Drawing.Size(261, 59);
            this.lblywstpnt.TabIndex = 72;
            this.lblywstpnt.Text = "Yaw Setpoint";
            this.lblywstpnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblrllstpnt
            // 
            this.lblrllstpnt.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrllstpnt.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblrllstpnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblrllstpnt.Location = new System.Drawing.Point(852, 84);
            this.lblrllstpnt.Name = "lblrllstpnt";
            this.lblrllstpnt.Size = new System.Drawing.Size(309, 59);
            this.lblrllstpnt.TabIndex = 49;
            this.lblrllstpnt.Text = "Roll Setpoint";
            this.lblrllstpnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPagePID
            // 
            this.tabPagePID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.tabPagePID.Controls.Add(this.btnWriteAll);
            this.tabPagePID.Controls.Add(this.btnRefreshAll);
            this.tabPagePID.Controls.Add(this.groupBoxRateNorth);
            this.tabPagePID.Controls.Add(this.groupBoxRateEast);
            this.tabPagePID.Controls.Add(this.groupBoxRateHeight);
            this.tabPagePID.Controls.Add(this.groupBoxRateYaw);
            this.tabPagePID.Controls.Add(this.groupBoxRatePitch);
            this.tabPagePID.Controls.Add(this.groupBoxRateRoll);
            this.tabPagePID.Location = new System.Drawing.Point(4, 64);
            this.tabPagePID.Name = "tabPagePID";
            this.tabPagePID.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePID.Size = new System.Drawing.Size(1961, 881);
            this.tabPagePID.TabIndex = 3;
            this.tabPagePID.Text = "PID";
            // 
            // btnWriteAll
            // 
            this.btnWriteAll.Animated = true;
            this.btnWriteAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnWriteAll.BorderRadius = 10;
            this.btnWriteAll.BorderThickness = 2;
            this.btnWriteAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWriteAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWriteAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWriteAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWriteAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.btnWriteAll.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.btnWriteAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnWriteAll.IndicateFocus = true;
            this.btnWriteAll.Location = new System.Drawing.Point(418, 770);
            this.btnWriteAll.Name = "btnWriteAll";
            this.btnWriteAll.PressedColor = System.Drawing.Color.MintCream;
            this.btnWriteAll.Size = new System.Drawing.Size(204, 81);
            this.btnWriteAll.TabIndex = 79;
            this.btnWriteAll.Text = "Write All";
            // 
            // btnRefreshAll
            // 
            this.btnRefreshAll.Animated = true;
            this.btnRefreshAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnRefreshAll.BorderRadius = 10;
            this.btnRefreshAll.BorderThickness = 2;
            this.btnRefreshAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefreshAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefreshAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.btnRefreshAll.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.btnRefreshAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnRefreshAll.IndicateFocus = true;
            this.btnRefreshAll.Location = new System.Drawing.Point(650, 770);
            this.btnRefreshAll.Name = "btnRefreshAll";
            this.btnRefreshAll.PressedColor = System.Drawing.Color.MintCream;
            this.btnRefreshAll.Size = new System.Drawing.Size(204, 81);
            this.btnRefreshAll.TabIndex = 80;
            this.btnRefreshAll.Text = "Refresh All";
            // 
            // groupBoxRateNorth
            // 
            this.groupBoxRateNorth.Controls.Add(this.ButtonNorthRefresh);
            this.groupBoxRateNorth.Controls.Add(this.ButtonNorthWrite);
            this.groupBoxRateNorth.Controls.Add(this.NumericEXTRAN);
            this.groupBoxRateNorth.Controls.Add(this.NumericPN);
            this.groupBoxRateNorth.Controls.Add(this.label6);
            this.groupBoxRateNorth.Controls.Add(this.NumericDN);
            this.groupBoxRateNorth.Controls.Add(this.label7);
            this.groupBoxRateNorth.Controls.Add(this.NumericIN);
            this.groupBoxRateNorth.Controls.Add(this.label8);
            this.groupBoxRateNorth.Controls.Add(this.label9);
            this.groupBoxRateNorth.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRateNorth.ForeColor = System.Drawing.Color.Snow;
            this.groupBoxRateNorth.Location = new System.Drawing.Point(683, 399);
            this.groupBoxRateNorth.Name = "groupBoxRateNorth";
            this.groupBoxRateNorth.Size = new System.Drawing.Size(635, 347);
            this.groupBoxRateNorth.TabIndex = 79;
            this.groupBoxRateNorth.TabStop = false;
            this.groupBoxRateNorth.Text = "Rate North";
            // 
            // ButtonNorthRefresh
            // 
            this.ButtonNorthRefresh.Animated = true;
            this.ButtonNorthRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonNorthRefresh.BorderRadius = 10;
            this.ButtonNorthRefresh.BorderThickness = 2;
            this.ButtonNorthRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonNorthRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonNorthRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonNorthRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonNorthRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ButtonNorthRefresh.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.ButtonNorthRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonNorthRefresh.IndicateFocus = true;
            this.ButtonNorthRefresh.Location = new System.Drawing.Point(412, 230);
            this.ButtonNorthRefresh.Name = "ButtonNorthRefresh";
            this.ButtonNorthRefresh.PressedColor = System.Drawing.Color.MintCream;
            this.ButtonNorthRefresh.Size = new System.Drawing.Size(204, 81);
            this.ButtonNorthRefresh.TabIndex = 78;
            this.ButtonNorthRefresh.Text = "Refresh";
            this.ButtonNorthRefresh.Click += new System.EventHandler(this.ButtonNorthRefresh_Click);
            // 
            // ButtonNorthWrite
            // 
            this.ButtonNorthWrite.Animated = true;
            this.ButtonNorthWrite.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonNorthWrite.BorderRadius = 10;
            this.ButtonNorthWrite.BorderThickness = 2;
            this.ButtonNorthWrite.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonNorthWrite.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonNorthWrite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonNorthWrite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonNorthWrite.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ButtonNorthWrite.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.ButtonNorthWrite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonNorthWrite.IndicateFocus = true;
            this.ButtonNorthWrite.Location = new System.Drawing.Point(412, 69);
            this.ButtonNorthWrite.Name = "ButtonNorthWrite";
            this.ButtonNorthWrite.PressedColor = System.Drawing.Color.MintCream;
            this.ButtonNorthWrite.Size = new System.Drawing.Size(204, 134);
            this.ButtonNorthWrite.TabIndex = 78;
            this.ButtonNorthWrite.Text = "Write Parameters";
            this.ButtonNorthWrite.Click += new System.EventHandler(this.ButtonNorthWrite_Click);
            // 
            // NumericEXTRAN
            // 
            this.NumericEXTRAN.BackColor = System.Drawing.Color.Transparent;
            this.NumericEXTRAN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericEXTRAN.FillColor = System.Drawing.Color.Snow;
            this.NumericEXTRAN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericEXTRAN.Location = new System.Drawing.Point(192, 231);
            this.NumericEXTRAN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericEXTRAN.Name = "NumericEXTRAN";
            this.NumericEXTRAN.Size = new System.Drawing.Size(139, 27);
            this.NumericEXTRAN.TabIndex = 14;
            // 
            // NumericPN
            // 
            this.NumericPN.BackColor = System.Drawing.Color.Transparent;
            this.NumericPN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericPN.FillColor = System.Drawing.Color.Snow;
            this.NumericPN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericPN.Location = new System.Drawing.Point(192, 69);
            this.NumericPN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericPN.Name = "NumericPN";
            this.NumericPN.Size = new System.Drawing.Size(139, 27);
            this.NumericPN.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(76, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "P";
            // 
            // NumericDN
            // 
            this.NumericDN.BackColor = System.Drawing.Color.Transparent;
            this.NumericDN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericDN.FillColor = System.Drawing.Color.Snow;
            this.NumericDN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericDN.Location = new System.Drawing.Point(192, 176);
            this.NumericDN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericDN.Name = "NumericDN";
            this.NumericDN.Size = new System.Drawing.Size(139, 27);
            this.NumericDN.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(76, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 28);
            this.label7.TabIndex = 2;
            this.label7.Text = "I";
            // 
            // NumericIN
            // 
            this.NumericIN.BackColor = System.Drawing.Color.Transparent;
            this.NumericIN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericIN.FillColor = System.Drawing.Color.Snow;
            this.NumericIN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericIN.Location = new System.Drawing.Point(192, 126);
            this.NumericIN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericIN.Name = "NumericIN";
            this.NumericIN.Size = new System.Drawing.Size(139, 27);
            this.NumericIN.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(76, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 28);
            this.label8.TabIndex = 1;
            this.label8.Text = "D";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(67, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 28);
            this.label9.TabIndex = 4;
            this.label9.Text = "Extra";
            // 
            // groupBoxRateEast
            // 
            this.groupBoxRateEast.Controls.Add(this.ButtonEastRefresh);
            this.groupBoxRateEast.Controls.Add(this.ButtonEastWrite);
            this.groupBoxRateEast.Controls.Add(this.NumericEXTRAE);
            this.groupBoxRateEast.Controls.Add(this.NumericPE);
            this.groupBoxRateEast.Controls.Add(this.label11);
            this.groupBoxRateEast.Controls.Add(this.NumericDE);
            this.groupBoxRateEast.Controls.Add(this.label12);
            this.groupBoxRateEast.Controls.Add(this.NumericIE);
            this.groupBoxRateEast.Controls.Add(this.label13);
            this.groupBoxRateEast.Controls.Add(this.label14);
            this.groupBoxRateEast.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRateEast.ForeColor = System.Drawing.Color.Snow;
            this.groupBoxRateEast.Location = new System.Drawing.Point(1330, 399);
            this.groupBoxRateEast.Name = "groupBoxRateEast";
            this.groupBoxRateEast.Size = new System.Drawing.Size(635, 347);
            this.groupBoxRateEast.TabIndex = 80;
            this.groupBoxRateEast.TabStop = false;
            this.groupBoxRateEast.Text = "Rate East";
            // 
            // ButtonEastRefresh
            // 
            this.ButtonEastRefresh.Animated = true;
            this.ButtonEastRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonEastRefresh.BorderRadius = 10;
            this.ButtonEastRefresh.BorderThickness = 2;
            this.ButtonEastRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonEastRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonEastRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonEastRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonEastRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ButtonEastRefresh.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.ButtonEastRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonEastRefresh.IndicateFocus = true;
            this.ButtonEastRefresh.Location = new System.Drawing.Point(412, 230);
            this.ButtonEastRefresh.Name = "ButtonEastRefresh";
            this.ButtonEastRefresh.PressedColor = System.Drawing.Color.MintCream;
            this.ButtonEastRefresh.Size = new System.Drawing.Size(204, 81);
            this.ButtonEastRefresh.TabIndex = 78;
            this.ButtonEastRefresh.Text = "Refresh";
            this.ButtonEastRefresh.Click += new System.EventHandler(this.ButtonEastRefresh_Click);
            // 
            // ButtonEastWrite
            // 
            this.ButtonEastWrite.Animated = true;
            this.ButtonEastWrite.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonEastWrite.BorderRadius = 10;
            this.ButtonEastWrite.BorderThickness = 2;
            this.ButtonEastWrite.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonEastWrite.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonEastWrite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonEastWrite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonEastWrite.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ButtonEastWrite.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.ButtonEastWrite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonEastWrite.IndicateFocus = true;
            this.ButtonEastWrite.Location = new System.Drawing.Point(412, 69);
            this.ButtonEastWrite.Name = "ButtonEastWrite";
            this.ButtonEastWrite.PressedColor = System.Drawing.Color.MintCream;
            this.ButtonEastWrite.Size = new System.Drawing.Size(204, 134);
            this.ButtonEastWrite.TabIndex = 78;
            this.ButtonEastWrite.Text = "Write Parameters";
            this.ButtonEastWrite.Click += new System.EventHandler(this.ButtonEastWrite_Click);
            // 
            // NumericEXTRAE
            // 
            this.NumericEXTRAE.BackColor = System.Drawing.Color.Transparent;
            this.NumericEXTRAE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericEXTRAE.FillColor = System.Drawing.Color.Snow;
            this.NumericEXTRAE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericEXTRAE.Location = new System.Drawing.Point(192, 231);
            this.NumericEXTRAE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericEXTRAE.Name = "NumericEXTRAE";
            this.NumericEXTRAE.Size = new System.Drawing.Size(139, 27);
            this.NumericEXTRAE.TabIndex = 14;
            // 
            // NumericPE
            // 
            this.NumericPE.BackColor = System.Drawing.Color.Transparent;
            this.NumericPE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericPE.FillColor = System.Drawing.Color.Snow;
            this.NumericPE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericPE.Location = new System.Drawing.Point(192, 69);
            this.NumericPE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericPE.Name = "NumericPE";
            this.NumericPE.Size = new System.Drawing.Size(139, 27);
            this.NumericPE.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(76, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 28);
            this.label11.TabIndex = 0;
            this.label11.Text = "P";
            // 
            // NumericDE
            // 
            this.NumericDE.BackColor = System.Drawing.Color.Transparent;
            this.NumericDE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericDE.FillColor = System.Drawing.Color.Snow;
            this.NumericDE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericDE.Location = new System.Drawing.Point(192, 176);
            this.NumericDE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericDE.Name = "NumericDE";
            this.NumericDE.Size = new System.Drawing.Size(139, 27);
            this.NumericDE.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(76, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 28);
            this.label12.TabIndex = 2;
            this.label12.Text = "I";
            // 
            // NumericIE
            // 
            this.NumericIE.BackColor = System.Drawing.Color.Transparent;
            this.NumericIE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericIE.FillColor = System.Drawing.Color.Snow;
            this.NumericIE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericIE.Location = new System.Drawing.Point(192, 126);
            this.NumericIE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericIE.Name = "NumericIE";
            this.NumericIE.Size = new System.Drawing.Size(139, 27);
            this.NumericIE.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(76, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 28);
            this.label13.TabIndex = 1;
            this.label13.Text = "D";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(67, 231);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 28);
            this.label14.TabIndex = 4;
            this.label14.Text = "Extra";
            // 
            // groupBoxRateHeight
            // 
            this.groupBoxRateHeight.Controls.Add(this.ButtonHeightRefresh);
            this.groupBoxRateHeight.Controls.Add(this.ButtonHeightWrite);
            this.groupBoxRateHeight.Controls.Add(this.NumericEXTRAH);
            this.groupBoxRateHeight.Controls.Add(this.NumericPH);
            this.groupBoxRateHeight.Controls.Add(this.label1);
            this.groupBoxRateHeight.Controls.Add(this.NumericDH);
            this.groupBoxRateHeight.Controls.Add(this.label2);
            this.groupBoxRateHeight.Controls.Add(this.NumericIH);
            this.groupBoxRateHeight.Controls.Add(this.label3);
            this.groupBoxRateHeight.Controls.Add(this.label4);
            this.groupBoxRateHeight.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRateHeight.ForeColor = System.Drawing.Color.Snow;
            this.groupBoxRateHeight.Location = new System.Drawing.Point(6, 399);
            this.groupBoxRateHeight.Name = "groupBoxRateHeight";
            this.groupBoxRateHeight.Size = new System.Drawing.Size(635, 347);
            this.groupBoxRateHeight.TabIndex = 17;
            this.groupBoxRateHeight.TabStop = false;
            this.groupBoxRateHeight.Text = "Rate Height";
            // 
            // ButtonHeightRefresh
            // 
            this.ButtonHeightRefresh.Animated = true;
            this.ButtonHeightRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonHeightRefresh.BorderRadius = 10;
            this.ButtonHeightRefresh.BorderThickness = 2;
            this.ButtonHeightRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonHeightRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonHeightRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonHeightRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonHeightRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ButtonHeightRefresh.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.ButtonHeightRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonHeightRefresh.IndicateFocus = true;
            this.ButtonHeightRefresh.Location = new System.Drawing.Point(412, 230);
            this.ButtonHeightRefresh.Name = "ButtonHeightRefresh";
            this.ButtonHeightRefresh.PressedColor = System.Drawing.Color.MintCream;
            this.ButtonHeightRefresh.Size = new System.Drawing.Size(204, 81);
            this.ButtonHeightRefresh.TabIndex = 78;
            this.ButtonHeightRefresh.Text = "Refresh";
            this.ButtonHeightRefresh.Click += new System.EventHandler(this.ButtonHeightRefresh_Click);
            // 
            // ButtonHeightWrite
            // 
            this.ButtonHeightWrite.Animated = true;
            this.ButtonHeightWrite.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonHeightWrite.BorderRadius = 10;
            this.ButtonHeightWrite.BorderThickness = 2;
            this.ButtonHeightWrite.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonHeightWrite.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonHeightWrite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonHeightWrite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonHeightWrite.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ButtonHeightWrite.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.ButtonHeightWrite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonHeightWrite.IndicateFocus = true;
            this.ButtonHeightWrite.Location = new System.Drawing.Point(412, 69);
            this.ButtonHeightWrite.Name = "ButtonHeightWrite";
            this.ButtonHeightWrite.PressedColor = System.Drawing.Color.MintCream;
            this.ButtonHeightWrite.Size = new System.Drawing.Size(204, 134);
            this.ButtonHeightWrite.TabIndex = 78;
            this.ButtonHeightWrite.Text = "Write Parameters";
            this.ButtonHeightWrite.Click += new System.EventHandler(this.ButtonHeightWrite_Click);
            // 
            // NumericEXTRAH
            // 
            this.NumericEXTRAH.BackColor = System.Drawing.Color.Transparent;
            this.NumericEXTRAH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericEXTRAH.FillColor = System.Drawing.Color.Snow;
            this.NumericEXTRAH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericEXTRAH.Location = new System.Drawing.Point(192, 231);
            this.NumericEXTRAH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericEXTRAH.Name = "NumericEXTRAH";
            this.NumericEXTRAH.Size = new System.Drawing.Size(139, 27);
            this.NumericEXTRAH.TabIndex = 14;
            // 
            // NumericPH
            // 
            this.NumericPH.BackColor = System.Drawing.Color.Transparent;
            this.NumericPH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericPH.FillColor = System.Drawing.Color.Snow;
            this.NumericPH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericPH.Location = new System.Drawing.Point(192, 69);
            this.NumericPH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericPH.Name = "NumericPH";
            this.NumericPH.Size = new System.Drawing.Size(139, 27);
            this.NumericPH.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(76, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "P";
            // 
            // NumericDH
            // 
            this.NumericDH.BackColor = System.Drawing.Color.Transparent;
            this.NumericDH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericDH.FillColor = System.Drawing.Color.Snow;
            this.NumericDH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericDH.Location = new System.Drawing.Point(192, 176);
            this.NumericDH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericDH.Name = "NumericDH";
            this.NumericDH.Size = new System.Drawing.Size(139, 27);
            this.NumericDH.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(76, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "I";
            // 
            // NumericIH
            // 
            this.NumericIH.BackColor = System.Drawing.Color.Transparent;
            this.NumericIH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericIH.FillColor = System.Drawing.Color.Snow;
            this.NumericIH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericIH.Location = new System.Drawing.Point(192, 126);
            this.NumericIH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericIH.Name = "NumericIH";
            this.NumericIH.Size = new System.Drawing.Size(139, 27);
            this.NumericIH.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(76, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "D";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(67, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Extra";
            // 
            // groupBoxRateYaw
            // 
            this.groupBoxRateYaw.Controls.Add(this.ButtonYawRefresh);
            this.groupBoxRateYaw.Controls.Add(this.ButtonYawWrite);
            this.groupBoxRateYaw.Controls.Add(this.NumericEXTRAY);
            this.groupBoxRateYaw.Controls.Add(this.NumericPY);
            this.groupBoxRateYaw.Controls.Add(this.labelPY);
            this.groupBoxRateYaw.Controls.Add(this.NumericDY);
            this.groupBoxRateYaw.Controls.Add(this.labelIY);
            this.groupBoxRateYaw.Controls.Add(this.NumericIY);
            this.groupBoxRateYaw.Controls.Add(this.labelDY);
            this.groupBoxRateYaw.Controls.Add(this.label5);
            this.groupBoxRateYaw.Controls.Add(this.labelIMAXY);
            this.groupBoxRateYaw.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRateYaw.ForeColor = System.Drawing.Color.Snow;
            this.groupBoxRateYaw.Location = new System.Drawing.Point(1330, 6);
            this.groupBoxRateYaw.Name = "groupBoxRateYaw";
            this.groupBoxRateYaw.Size = new System.Drawing.Size(635, 347);
            this.groupBoxRateYaw.TabIndex = 16;
            this.groupBoxRateYaw.TabStop = false;
            this.groupBoxRateYaw.Text = "Rate Yaw";
            // 
            // ButtonYawRefresh
            // 
            this.ButtonYawRefresh.Animated = true;
            this.ButtonYawRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonYawRefresh.BorderRadius = 10;
            this.ButtonYawRefresh.BorderThickness = 2;
            this.ButtonYawRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonYawRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonYawRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonYawRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonYawRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ButtonYawRefresh.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.ButtonYawRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonYawRefresh.IndicateFocus = true;
            this.ButtonYawRefresh.Location = new System.Drawing.Point(412, 230);
            this.ButtonYawRefresh.Name = "ButtonYawRefresh";
            this.ButtonYawRefresh.PressedColor = System.Drawing.Color.MintCream;
            this.ButtonYawRefresh.Size = new System.Drawing.Size(204, 81);
            this.ButtonYawRefresh.TabIndex = 78;
            this.ButtonYawRefresh.Text = "Refresh";
            this.ButtonYawRefresh.Click += new System.EventHandler(this.ButtonYawRefresh_Click);
            // 
            // ButtonYawWrite
            // 
            this.ButtonYawWrite.Animated = true;
            this.ButtonYawWrite.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonYawWrite.BorderRadius = 10;
            this.ButtonYawWrite.BorderThickness = 2;
            this.ButtonYawWrite.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonYawWrite.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonYawWrite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonYawWrite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonYawWrite.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ButtonYawWrite.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.ButtonYawWrite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonYawWrite.IndicateFocus = true;
            this.ButtonYawWrite.Location = new System.Drawing.Point(412, 69);
            this.ButtonYawWrite.Name = "ButtonYawWrite";
            this.ButtonYawWrite.PressedColor = System.Drawing.Color.MintCream;
            this.ButtonYawWrite.Size = new System.Drawing.Size(204, 134);
            this.ButtonYawWrite.TabIndex = 78;
            this.ButtonYawWrite.Text = "Write Parameters";
            this.ButtonYawWrite.Click += new System.EventHandler(this.ButtonYawWrite_Click);
            // 
            // NumericEXTRAY
            // 
            this.NumericEXTRAY.BackColor = System.Drawing.Color.Transparent;
            this.NumericEXTRAY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericEXTRAY.FillColor = System.Drawing.Color.Snow;
            this.NumericEXTRAY.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericEXTRAY.Location = new System.Drawing.Point(192, 231);
            this.NumericEXTRAY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericEXTRAY.Name = "NumericEXTRAY";
            this.NumericEXTRAY.Size = new System.Drawing.Size(139, 27);
            this.NumericEXTRAY.TabIndex = 14;
            // 
            // NumericPY
            // 
            this.NumericPY.BackColor = System.Drawing.Color.Transparent;
            this.NumericPY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericPY.FillColor = System.Drawing.Color.Snow;
            this.NumericPY.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericPY.Location = new System.Drawing.Point(192, 69);
            this.NumericPY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericPY.Name = "NumericPY";
            this.NumericPY.Size = new System.Drawing.Size(139, 27);
            this.NumericPY.TabIndex = 15;
            // 
            // labelPY
            // 
            this.labelPY.AutoSize = true;
            this.labelPY.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPY.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPY.Location = new System.Drawing.Point(76, 69);
            this.labelPY.Name = "labelPY";
            this.labelPY.Size = new System.Drawing.Size(23, 28);
            this.labelPY.TabIndex = 0;
            this.labelPY.Text = "P";
            // 
            // NumericDY
            // 
            this.NumericDY.BackColor = System.Drawing.Color.Transparent;
            this.NumericDY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericDY.FillColor = System.Drawing.Color.Snow;
            this.NumericDY.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericDY.Location = new System.Drawing.Point(192, 176);
            this.NumericDY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericDY.Name = "NumericDY";
            this.NumericDY.Size = new System.Drawing.Size(139, 27);
            this.NumericDY.TabIndex = 12;
            // 
            // labelIY
            // 
            this.labelIY.AutoSize = true;
            this.labelIY.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIY.ForeColor = System.Drawing.SystemColors.Control;
            this.labelIY.Location = new System.Drawing.Point(76, 126);
            this.labelIY.Name = "labelIY";
            this.labelIY.Size = new System.Drawing.Size(17, 28);
            this.labelIY.TabIndex = 2;
            this.labelIY.Text = "I";
            // 
            // NumericIY
            // 
            this.NumericIY.BackColor = System.Drawing.Color.Transparent;
            this.NumericIY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericIY.FillColor = System.Drawing.Color.Snow;
            this.NumericIY.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericIY.Location = new System.Drawing.Point(192, 126);
            this.NumericIY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericIY.Name = "NumericIY";
            this.NumericIY.Size = new System.Drawing.Size(139, 27);
            this.NumericIY.TabIndex = 11;
            // 
            // labelDY
            // 
            this.labelDY.AutoSize = true;
            this.labelDY.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDY.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDY.Location = new System.Drawing.Point(76, 176);
            this.labelDY.Name = "labelDY";
            this.labelDY.Size = new System.Drawing.Size(26, 28);
            this.labelDY.TabIndex = 1;
            this.labelDY.Text = "D";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(-1263, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Extra";
            // 
            // labelIMAXY
            // 
            this.labelIMAXY.AutoSize = true;
            this.labelIMAXY.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIMAXY.ForeColor = System.Drawing.SystemColors.Control;
            this.labelIMAXY.Location = new System.Drawing.Point(67, 231);
            this.labelIMAXY.Name = "labelIMAXY";
            this.labelIMAXY.Size = new System.Drawing.Size(54, 28);
            this.labelIMAXY.TabIndex = 4;
            this.labelIMAXY.Text = "Extra";
            // 
            // groupBoxRatePitch
            // 
            this.groupBoxRatePitch.Controls.Add(this.ButtonPitchRefresh);
            this.groupBoxRatePitch.Controls.Add(this.ButtonPitchWrite);
            this.groupBoxRatePitch.Controls.Add(this.NumericIEXTRAP);
            this.groupBoxRatePitch.Controls.Add(this.NumericPP);
            this.groupBoxRatePitch.Controls.Add(this.labelPP);
            this.groupBoxRatePitch.Controls.Add(this.NumericDP);
            this.groupBoxRatePitch.Controls.Add(this.labelIP);
            this.groupBoxRatePitch.Controls.Add(this.NumericIP);
            this.groupBoxRatePitch.Controls.Add(this.labelDP);
            this.groupBoxRatePitch.Controls.Add(this.labelIMAXP);
            this.groupBoxRatePitch.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRatePitch.ForeColor = System.Drawing.Color.Snow;
            this.groupBoxRatePitch.Location = new System.Drawing.Point(683, 6);
            this.groupBoxRatePitch.Name = "groupBoxRatePitch";
            this.groupBoxRatePitch.Size = new System.Drawing.Size(635, 347);
            this.groupBoxRatePitch.TabIndex = 11;
            this.groupBoxRatePitch.TabStop = false;
            this.groupBoxRatePitch.Text = "Rate Pitch";
            // 
            // ButtonPitchRefresh
            // 
            this.ButtonPitchRefresh.Animated = true;
            this.ButtonPitchRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonPitchRefresh.BorderRadius = 10;
            this.ButtonPitchRefresh.BorderThickness = 2;
            this.ButtonPitchRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonPitchRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonPitchRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonPitchRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonPitchRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ButtonPitchRefresh.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.ButtonPitchRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonPitchRefresh.IndicateFocus = true;
            this.ButtonPitchRefresh.Location = new System.Drawing.Point(412, 231);
            this.ButtonPitchRefresh.Name = "ButtonPitchRefresh";
            this.ButtonPitchRefresh.PressedColor = System.Drawing.Color.MintCream;
            this.ButtonPitchRefresh.Size = new System.Drawing.Size(204, 81);
            this.ButtonPitchRefresh.TabIndex = 79;
            this.ButtonPitchRefresh.Text = "Refresh";
            this.ButtonPitchRefresh.Click += new System.EventHandler(this.ButtonPitchRefresh_Click);
            // 
            // ButtonPitchWrite
            // 
            this.ButtonPitchWrite.Animated = true;
            this.ButtonPitchWrite.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonPitchWrite.BorderRadius = 10;
            this.ButtonPitchWrite.BorderThickness = 2;
            this.ButtonPitchWrite.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonPitchWrite.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonPitchWrite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonPitchWrite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonPitchWrite.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ButtonPitchWrite.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.ButtonPitchWrite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonPitchWrite.IndicateFocus = true;
            this.ButtonPitchWrite.Location = new System.Drawing.Point(412, 70);
            this.ButtonPitchWrite.Name = "ButtonPitchWrite";
            this.ButtonPitchWrite.PressedColor = System.Drawing.Color.MintCream;
            this.ButtonPitchWrite.Size = new System.Drawing.Size(204, 136);
            this.ButtonPitchWrite.TabIndex = 76;
            this.ButtonPitchWrite.Text = "Write Parameters";
            this.ButtonPitchWrite.Click += new System.EventHandler(this.ButtonPitchWrite_Click);
            // 
            // NumericIEXTRAP
            // 
            this.NumericIEXTRAP.BackColor = System.Drawing.Color.Transparent;
            this.NumericIEXTRAP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericIEXTRAP.FillColor = System.Drawing.Color.Snow;
            this.NumericIEXTRAP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericIEXTRAP.Location = new System.Drawing.Point(174, 233);
            this.NumericIEXTRAP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericIEXTRAP.Name = "NumericIEXTRAP";
            this.NumericIEXTRAP.Size = new System.Drawing.Size(139, 27);
            this.NumericIEXTRAP.TabIndex = 14;
            // 
            // NumericPP
            // 
            this.NumericPP.BackColor = System.Drawing.Color.Transparent;
            this.NumericPP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericPP.FillColor = System.Drawing.Color.Snow;
            this.NumericPP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericPP.Location = new System.Drawing.Point(174, 72);
            this.NumericPP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericPP.Name = "NumericPP";
            this.NumericPP.Size = new System.Drawing.Size(139, 27);
            this.NumericPP.TabIndex = 15;
            // 
            // labelPP
            // 
            this.labelPP.AutoSize = true;
            this.labelPP.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPP.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPP.Location = new System.Drawing.Point(60, 71);
            this.labelPP.Name = "labelPP";
            this.labelPP.Size = new System.Drawing.Size(23, 28);
            this.labelPP.TabIndex = 0;
            this.labelPP.Text = "P";
            // 
            // NumericDP
            // 
            this.NumericDP.BackColor = System.Drawing.Color.Transparent;
            this.NumericDP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericDP.FillColor = System.Drawing.Color.Snow;
            this.NumericDP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericDP.Location = new System.Drawing.Point(174, 177);
            this.NumericDP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericDP.Name = "NumericDP";
            this.NumericDP.Size = new System.Drawing.Size(139, 27);
            this.NumericDP.TabIndex = 12;
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIP.ForeColor = System.Drawing.SystemColors.Control;
            this.labelIP.Location = new System.Drawing.Point(60, 127);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(17, 28);
            this.labelIP.TabIndex = 2;
            this.labelIP.Text = "I";
            // 
            // NumericIP
            // 
            this.NumericIP.BackColor = System.Drawing.Color.Transparent;
            this.NumericIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericIP.FillColor = System.Drawing.Color.Snow;
            this.NumericIP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericIP.Location = new System.Drawing.Point(174, 127);
            this.NumericIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericIP.Name = "NumericIP";
            this.NumericIP.Size = new System.Drawing.Size(139, 27);
            this.NumericIP.TabIndex = 11;
            // 
            // labelDP
            // 
            this.labelDP.AutoSize = true;
            this.labelDP.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDP.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDP.Location = new System.Drawing.Point(60, 178);
            this.labelDP.Name = "labelDP";
            this.labelDP.Size = new System.Drawing.Size(26, 28);
            this.labelDP.TabIndex = 1;
            this.labelDP.Text = "D";
            // 
            // labelIMAXP
            // 
            this.labelIMAXP.AutoSize = true;
            this.labelIMAXP.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIMAXP.ForeColor = System.Drawing.SystemColors.Control;
            this.labelIMAXP.Location = new System.Drawing.Point(60, 232);
            this.labelIMAXP.Name = "labelIMAXP";
            this.labelIMAXP.Size = new System.Drawing.Size(54, 28);
            this.labelIMAXP.TabIndex = 4;
            this.labelIMAXP.Text = "Extra";
            // 
            // groupBoxRateRoll
            // 
            this.groupBoxRateRoll.Controls.Add(this.ButtonRollRefresh);
            this.groupBoxRateRoll.Controls.Add(this.ButtonRollWrite);
            this.groupBoxRateRoll.Controls.Add(this.NumericEXTRAR);
            this.groupBoxRateRoll.Controls.Add(this.NumericPR);
            this.groupBoxRateRoll.Controls.Add(this.labelPR);
            this.groupBoxRateRoll.Controls.Add(this.NumericDR);
            this.groupBoxRateRoll.Controls.Add(this.labelIR);
            this.groupBoxRateRoll.Controls.Add(this.NumericIR);
            this.groupBoxRateRoll.Controls.Add(this.labelDR);
            this.groupBoxRateRoll.Controls.Add(this.labelIMAXR);
            this.groupBoxRateRoll.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRateRoll.ForeColor = System.Drawing.Color.Snow;
            this.groupBoxRateRoll.Location = new System.Drawing.Point(10, 6);
            this.groupBoxRateRoll.Name = "groupBoxRateRoll";
            this.groupBoxRateRoll.Size = new System.Drawing.Size(635, 347);
            this.groupBoxRateRoll.TabIndex = 10;
            this.groupBoxRateRoll.TabStop = false;
            this.groupBoxRateRoll.Text = "Rate Roll";
            // 
            // ButtonRollRefresh
            // 
            this.ButtonRollRefresh.Animated = true;
            this.ButtonRollRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonRollRefresh.BorderRadius = 10;
            this.ButtonRollRefresh.BorderThickness = 2;
            this.ButtonRollRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRollRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRollRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonRollRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonRollRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ButtonRollRefresh.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.ButtonRollRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonRollRefresh.IndicateFocus = true;
            this.ButtonRollRefresh.Location = new System.Drawing.Point(386, 232);
            this.ButtonRollRefresh.Name = "ButtonRollRefresh";
            this.ButtonRollRefresh.PressedColor = System.Drawing.Color.MintCream;
            this.ButtonRollRefresh.Size = new System.Drawing.Size(204, 81);
            this.ButtonRollRefresh.TabIndex = 77;
            this.ButtonRollRefresh.Text = "Refresh";
            this.ButtonRollRefresh.Click += new System.EventHandler(this.ButtonRollRefresh_Click);
            // 
            // ButtonRollWrite
            // 
            this.ButtonRollWrite.Animated = true;
            this.ButtonRollWrite.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonRollWrite.BorderRadius = 10;
            this.ButtonRollWrite.BorderThickness = 2;
            this.ButtonRollWrite.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRollWrite.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRollWrite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonRollWrite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonRollWrite.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.ButtonRollWrite.Font = new System.Drawing.Font("Nirmala UI Semilight", 13.8F);
            this.ButtonRollWrite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonRollWrite.IndicateFocus = true;
            this.ButtonRollWrite.Location = new System.Drawing.Point(386, 70);
            this.ButtonRollWrite.Name = "ButtonRollWrite";
            this.ButtonRollWrite.PressedColor = System.Drawing.Color.MintCream;
            this.ButtonRollWrite.Size = new System.Drawing.Size(204, 132);
            this.ButtonRollWrite.TabIndex = 77;
            this.ButtonRollWrite.Text = "Write Parameters";
            this.ButtonRollWrite.Click += new System.EventHandler(this.ButtonRollWrite_Click);
            // 
            // NumericEXTRAR
            // 
            this.NumericEXTRAR.BackColor = System.Drawing.Color.Transparent;
            this.NumericEXTRAR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericEXTRAR.FillColor = System.Drawing.Color.Snow;
            this.NumericEXTRAR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericEXTRAR.Location = new System.Drawing.Point(183, 232);
            this.NumericEXTRAR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericEXTRAR.Name = "NumericEXTRAR";
            this.NumericEXTRAR.Size = new System.Drawing.Size(139, 27);
            this.NumericEXTRAR.TabIndex = 14;
            // 
            // NumericPR
            // 
            this.NumericPR.BackColor = System.Drawing.Color.Transparent;
            this.NumericPR.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.NumericPR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericPR.FillColor = System.Drawing.Color.Snow;
            this.NumericPR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericPR.Location = new System.Drawing.Point(183, 72);
            this.NumericPR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericPR.Name = "NumericPR";
            this.NumericPR.Size = new System.Drawing.Size(139, 27);
            this.NumericPR.TabIndex = 15;
            // 
            // labelPR
            // 
            this.labelPR.AutoSize = true;
            this.labelPR.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPR.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPR.Location = new System.Drawing.Point(57, 70);
            this.labelPR.Name = "labelPR";
            this.labelPR.Size = new System.Drawing.Size(23, 28);
            this.labelPR.TabIndex = 0;
            this.labelPR.Text = "P";
            // 
            // NumericDR
            // 
            this.NumericDR.BackColor = System.Drawing.Color.Transparent;
            this.NumericDR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericDR.FillColor = System.Drawing.Color.Snow;
            this.NumericDR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericDR.Location = new System.Drawing.Point(183, 177);
            this.NumericDR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericDR.Name = "NumericDR";
            this.NumericDR.Size = new System.Drawing.Size(139, 27);
            this.NumericDR.TabIndex = 12;
            // 
            // labelIR
            // 
            this.labelIR.AutoSize = true;
            this.labelIR.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIR.ForeColor = System.Drawing.SystemColors.Control;
            this.labelIR.Location = new System.Drawing.Point(57, 127);
            this.labelIR.Name = "labelIR";
            this.labelIR.Size = new System.Drawing.Size(17, 28);
            this.labelIR.TabIndex = 2;
            this.labelIR.Text = "I";
            // 
            // NumericIR
            // 
            this.NumericIR.BackColor = System.Drawing.Color.Transparent;
            this.NumericIR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericIR.FillColor = System.Drawing.Color.Snow;
            this.NumericIR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericIR.Location = new System.Drawing.Point(183, 127);
            this.NumericIR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericIR.Name = "NumericIR";
            this.NumericIR.Size = new System.Drawing.Size(139, 27);
            this.NumericIR.TabIndex = 11;
            // 
            // labelDR
            // 
            this.labelDR.AutoSize = true;
            this.labelDR.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDR.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDR.Location = new System.Drawing.Point(57, 178);
            this.labelDR.Name = "labelDR";
            this.labelDR.Size = new System.Drawing.Size(26, 28);
            this.labelDR.TabIndex = 1;
            this.labelDR.Text = "D";
            // 
            // labelIMAXR
            // 
            this.labelIMAXR.AutoSize = true;
            this.labelIMAXR.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIMAXR.ForeColor = System.Drawing.SystemColors.Control;
            this.labelIMAXR.Location = new System.Drawing.Point(57, 232);
            this.labelIMAXR.Name = "labelIMAXR";
            this.labelIMAXR.Size = new System.Drawing.Size(54, 28);
            this.labelIMAXR.TabIndex = 4;
            this.labelIMAXR.Text = "Extra";
            // 
            // tabPageINFO
            // 
            this.tabPageINFO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.tabPageINFO.Location = new System.Drawing.Point(4, 64);
            this.tabPageINFO.Name = "tabPageINFO";
            this.tabPageINFO.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageINFO.Size = new System.Drawing.Size(1961, 881);
            this.tabPageINFO.TabIndex = 4;
            this.tabPageINFO.Text = "MISSION";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.tabPage1.Controls.Add(this.pictureBoxMail);
            this.tabPage1.Controls.Add(this.pictureBoxInstangram);
            this.tabPage1.Controls.Add(this.pictureBoxLinkedn);
            this.tabPage1.Controls.Add(this.linkLabelSoruGorus);
            this.tabPage1.Controls.Add(this.labelHkkmzda);
            this.tabPage1.Controls.Add(this.linkLabelWebSitesi);
            this.tabPage1.ForeColor = System.Drawing.Color.Snow;
            this.tabPage1.Location = new System.Drawing.Point(4, 64);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1961, 881);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "INFO";
            // 
            // pictureBoxMail
            // 
            this.pictureBoxMail.BackColor = System.Drawing.Color.Snow;
            this.pictureBoxMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMail.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMail.Image")));
            this.pictureBoxMail.Location = new System.Drawing.Point(914, 148);
            this.pictureBoxMail.Name = "pictureBoxMail";
            this.pictureBoxMail.Size = new System.Drawing.Size(98, 90);
            this.pictureBoxMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMail.TabIndex = 81;
            this.pictureBoxMail.TabStop = false;
            this.pictureBoxMail.Click += new System.EventHandler(this.pictureBoxMail_Click);
            // 
            // pictureBoxInstangram
            // 
            this.pictureBoxInstangram.BackColor = System.Drawing.Color.Snow;
            this.pictureBoxInstangram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxInstangram.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInstangram.Image")));
            this.pictureBoxInstangram.Location = new System.Drawing.Point(783, 148);
            this.pictureBoxInstangram.Name = "pictureBoxInstangram";
            this.pictureBoxInstangram.Size = new System.Drawing.Size(98, 90);
            this.pictureBoxInstangram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInstangram.TabIndex = 80;
            this.pictureBoxInstangram.TabStop = false;
            this.pictureBoxInstangram.Click += new System.EventHandler(this.pictureBoxInstangram_Click);
            // 
            // pictureBoxLinkedn
            // 
            this.pictureBoxLinkedn.BackColor = System.Drawing.Color.Snow;
            this.pictureBoxLinkedn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLinkedn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLinkedn.Image")));
            this.pictureBoxLinkedn.Location = new System.Drawing.Point(652, 148);
            this.pictureBoxLinkedn.Name = "pictureBoxLinkedn";
            this.pictureBoxLinkedn.Size = new System.Drawing.Size(98, 90);
            this.pictureBoxLinkedn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLinkedn.TabIndex = 79;
            this.pictureBoxLinkedn.TabStop = false;
            this.pictureBoxLinkedn.Click += new System.EventHandler(this.pictureBoxLinkedn_Click);
            // 
            // linkLabelSoruGorus
            // 
            this.linkLabelSoruGorus.AutoSize = true;
            this.linkLabelSoruGorus.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.linkLabelSoruGorus.LinkColor = System.Drawing.Color.Snow;
            this.linkLabelSoruGorus.Location = new System.Drawing.Point(76, 254);
            this.linkLabelSoruGorus.Name = "linkLabelSoruGorus";
            this.linkLabelSoruGorus.Size = new System.Drawing.Size(341, 38);
            this.linkLabelSoruGorus.TabIndex = 78;
            this.linkLabelSoruGorus.TabStop = true;
            this.linkLabelSoruGorus.Text = "Soru ve Görüşleriniz İçin";
            this.linkLabelSoruGorus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSoruGorus_LinkClicked);
            // 
            // labelHkkmzda
            // 
            this.labelHkkmzda.AllowDrop = true;
            this.labelHkkmzda.AutoSize = true;
            this.labelHkkmzda.Font = new System.Drawing.Font("Nirmala UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHkkmzda.ForeColor = System.Drawing.Color.Snow;
            this.labelHkkmzda.Location = new System.Drawing.Point(70, 55);
            this.labelHkkmzda.Name = "labelHkkmzda";
            this.labelHkkmzda.Size = new System.Drawing.Size(263, 59);
            this.labelHkkmzda.TabIndex = 77;
            this.labelHkkmzda.Text = "Hakkımızda";
            // 
            // linkLabelWebSitesi
            // 
            this.linkLabelWebSitesi.AutoSize = true;
            this.linkLabelWebSitesi.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelWebSitesi.LinkColor = System.Drawing.Color.Snow;
            this.linkLabelWebSitesi.Location = new System.Drawing.Point(74, 200);
            this.linkLabelWebSitesi.Name = "linkLabelWebSitesi";
            this.linkLabelWebSitesi.Size = new System.Drawing.Size(181, 38);
            this.linkLabelWebSitesi.TabIndex = 76;
            this.linkLabelWebSitesi.TabStop = true;
            this.linkLabelWebSitesi.Text = "Web Sitemiz";
            this.linkLabelWebSitesi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelWebSitesi_LinkClicked);
            // 
            // timerGauge
            // 
            this.timerGauge.Tick += new System.EventHandler(this.timerGauge_Tick);
            // 
            // timerSerialCheck
            // 
            this.timerSerialCheck.Enabled = true;
            this.timerSerialCheck.Tick += new System.EventHandler(this.timerSerialCheck_Tick);
            // 
            // AspanGround
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1969, 1053);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.panelUpper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AspanGround";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AspanGround";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AspanGround_FormClosing);
            this.Load += new System.EventHandler(this.AspanGround_Load);
            this.panelUpper.ResumeLayout(false);
            this.panelUpper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.tabPageWATCH.ResumeLayout(false);
            this.panelMiddleAbove.ResumeLayout(false);
            this.panelBelow.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWaypoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webViewMap)).EndInit();
            this.tabPageGRAPH.ResumeLayout(false);
            this.tabPageGRAPH.PerformLayout();
            this.tabPageDATA.ResumeLayout(false);
            this.tabPagePID.ResumeLayout(false);
            this.groupBoxRateNorth.ResumeLayout(false);
            this.groupBoxRateNorth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEXTRAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericIN)).EndInit();
            this.groupBoxRateEast.ResumeLayout(false);
            this.groupBoxRateEast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEXTRAE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericIE)).EndInit();
            this.groupBoxRateHeight.ResumeLayout(false);
            this.groupBoxRateHeight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEXTRAH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericIH)).EndInit();
            this.groupBoxRateYaw.ResumeLayout(false);
            this.groupBoxRateYaw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEXTRAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericIY)).EndInit();
            this.groupBoxRatePitch.ResumeLayout(false);
            this.groupBoxRatePitch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericIEXTRAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericIP)).EndInit();
            this.groupBoxRateRoll.ResumeLayout(false);
            this.groupBoxRateRoll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEXTRAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericIR)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInstangram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLinkedn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelUpper;
        private System.Windows.Forms.Label labelNoConnection;
        private System.Windows.Forms.Label labelConnected;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.PictureBox pictureBoxGreen;
        private System.Windows.Forms.Timer timerGraphic;
        private System.Windows.Forms.PictureBox pictureBoxGrey;
        private LiveCharts.WinForms.CartesianChart ChartRollPitchYaw;
        private System.Windows.Forms.Label labelASPANGORUND;
        private System.Windows.Forms.Timer timerRCControls;
        private System.Windows.Forms.Label lblroll;
        private System.Windows.Forms.Label lblpitch;
        private System.Windows.Forms.Label lblrh;
        private System.Windows.Forms.Label lbllh;
        private System.Windows.Forms.Label labelLatitude;
        private System.Windows.Forms.Label labelRV;
        private System.Windows.Forms.Label lbllttd;
        private System.Windows.Forms.Label labelLH;
        private System.Windows.Forms.Label labelYaw;
        private System.Windows.Forms.Label lblrv;
        private System.Windows.Forms.Label lblaltitude;
        private System.Windows.Forms.Label labelRoll;
        private System.Windows.Forms.Label labelAltitude;
        private System.Windows.Forms.Label labelRH;
        private System.Windows.Forms.Label lblyaw;
        private System.Windows.Forms.Label labelPitch;
        private System.Windows.Forms.Label labelLongitude;
        private System.Windows.Forms.Label labellngtd;
        private Guna.UI2.WinForms.Guna2TabControl TabControl;
        private System.Windows.Forms.TabPage tabPageWATCH;
        private System.Windows.Forms.TabPage tabPageGRAPH;
        private System.Windows.Forms.TabPage tabPageDATA;
        private System.Windows.Forms.TabPage tabPagePID;
        private System.Windows.Forms.TabPage tabPageINFO;
        private Guna.UI2.WinForms.Guna2Button ButtonStartLog;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxBaudRates;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxPorts;
        private Guna.UI2.WinForms.Guna2Button ButtonConnect;
        private Guna.UI2.WinForms.Guna2Button ButtonDisconnect;
        private Guna.UI2.WinForms.Guna2Button ButtonSaveLog;
        private Guna.UI2.WinForms.Guna2Button ButtonOpenFolder;
        private System.Windows.Forms.TableLayoutPanel panelMiddleAbove;
        private System.Windows.Forms.Panel panelBelow;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Timer timerGauge;
        private System.Windows.Forms.Panel panelBottomLeft;
        private System.Windows.Forms.Label lblrllstpnt;
        private System.Windows.Forms.Label lblptchstpnt;
        private System.Windows.Forms.Label lblywstpnt;
        private System.Windows.Forms.Label labelYawSetpoint;
        private System.Windows.Forms.Label labelPitchSetpoint;
        private System.Windows.Forms.Label labelRollSetpoint;
        private System.Windows.Forms.Label lblSetpoint;
        private System.Windows.Forms.Label lblGyro;
        private System.Windows.Forms.Label lblKumanda;
        private System.Windows.Forms.Label lblGPS;
        private Guna.UI2.WinForms.Guna2Button ButtonDeleteWaypoint;
        private System.Windows.Forms.RadioButton radioRoll;
        private System.Windows.Forms.RadioButton radioNone;
        private System.Windows.Forms.RadioButton radioYawSetpoint;
        private System.Windows.Forms.RadioButton radioPitchSetpoint;
        private System.Windows.Forms.RadioButton radioRollSetpoint;
        private System.Windows.Forms.RadioButton radioRollPitch;
        private System.Windows.Forms.RadioButton radioYaw;
        private System.Windows.Forms.RadioButton radioPitch;
        private AvionicsInstrumentControlDemo.AttitudeIndicatorInstrumentControl attitudeIndicatorInstrumentControl1;
        private AvionicsInstrumentControlDemo.HeadingIndicatorInstrumentControl headingIndicatorInstrumentControl1;
        private System.Windows.Forms.Timer timerSerialCheck;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewWaypoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn idx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Latitude;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewMap;
        private System.Windows.Forms.Label labelIMAXR;
        private System.Windows.Forms.Label labelIR;
        private System.Windows.Forms.Label labelDR;
        private System.Windows.Forms.Label labelPR;
        private System.Windows.Forms.GroupBox groupBoxRateRoll;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericEXTRAR;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericPR;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericDR;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericIR;
        private System.Windows.Forms.GroupBox groupBoxRateYaw;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericEXTRAY;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericPY;
        private System.Windows.Forms.Label labelPY;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericDY;
        private System.Windows.Forms.Label labelIY;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericIY;
        private System.Windows.Forms.Label labelDY;
        private System.Windows.Forms.Label labelIMAXY;
        private System.Windows.Forms.GroupBox groupBoxRatePitch;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericIEXTRAP;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericPP;
        private System.Windows.Forms.Label labelPP;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericDP;
        private System.Windows.Forms.Label labelIP;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericIP;
        private System.Windows.Forms.Label labelDP;
        private System.Windows.Forms.Label labelIMAXP;
        private System.Windows.Forms.LinkLabel linkLabelWebSitesi;
        private System.Windows.Forms.Label labelHkkmzda;
        private System.Windows.Forms.LinkLabel linkLabelSoruGorus;
        private System.Windows.Forms.PictureBox pictureBoxLinkedn;
        private System.Windows.Forms.PictureBox pictureBoxInstangram;
        private System.Windows.Forms.PictureBox pictureBoxMail;
        private Guna.UI2.WinForms.Guna2Button ButtonPitchWrite;
        private Guna.UI2.WinForms.Guna2Button ButtonRollWrite;
        private Guna.UI2.WinForms.Guna2Button ButtonYawWrite;
        private Guna.UI2.WinForms.Guna2Button ButtonYawRefresh;
        private Guna.UI2.WinForms.Guna2Button ButtonPitchRefresh;
        private Guna.UI2.WinForms.Guna2Button ButtonRollRefresh;
        private System.Windows.Forms.GroupBox groupBoxRateHeight;
        private Guna.UI2.WinForms.Guna2Button ButtonHeightRefresh;
        private Guna.UI2.WinForms.Guna2Button ButtonHeightWrite;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericEXTRAH;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericPH;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericDH;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericIH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxRateEast;
        private Guna.UI2.WinForms.Guna2Button ButtonEastRefresh;
        private Guna.UI2.WinForms.Guna2Button ButtonEastWrite;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericEXTRAE;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericPE;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericDE;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericIE;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBoxRateNorth;
        private Guna.UI2.WinForms.Guna2Button ButtonNorthRefresh;
        private Guna.UI2.WinForms.Guna2Button ButtonNorthWrite;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericEXTRAN;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericPN;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericDN;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericIN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnWriteAll;
        private Guna.UI2.WinForms.Guna2Button btnRefreshAll;
    }
}

