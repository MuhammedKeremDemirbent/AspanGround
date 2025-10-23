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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.groupBoxRateYaw = new System.Windows.Forms.GroupBox();
            this.ButtonYawRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonYawWrite = new Guna.UI2.WinForms.Guna2Button();
            this.NumericFILTY = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.NumericIMAXY = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.NumericPY = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labelPY = new System.Windows.Forms.Label();
            this.NumericDY = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labelIY = new System.Windows.Forms.Label();
            this.NumericIY = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labelDY = new System.Windows.Forms.Label();
            this.labelIMAXY = new System.Windows.Forms.Label();
            this.labelFILTY = new System.Windows.Forms.Label();
            this.groupBoxRatePitch = new System.Windows.Forms.GroupBox();
            this.ButtonPitchRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonPitchWrite = new Guna.UI2.WinForms.Guna2Button();
            this.NumericFILTP = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.NumericIMAXP = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.NumericPP = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labelPP = new System.Windows.Forms.Label();
            this.NumericDP = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labelIP = new System.Windows.Forms.Label();
            this.NumericIP = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labelDP = new System.Windows.Forms.Label();
            this.labelIMAXP = new System.Windows.Forms.Label();
            this.labelFILTP = new System.Windows.Forms.Label();
            this.groupBoxRateRoll = new System.Windows.Forms.GroupBox();
            this.ButtonRollRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonRollWrite = new Guna.UI2.WinForms.Guna2Button();
            this.NumericFILTR = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.NumericIMAXR = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.NumericPR = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labelPR = new System.Windows.Forms.Label();
            this.NumericDR = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labelIR = new System.Windows.Forms.Label();
            this.NumericIR = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labelDR = new System.Windows.Forms.Label();
            this.labelIMAXR = new System.Windows.Forms.Label();
            this.labelFILTR = new System.Windows.Forms.Label();
            this.tabPageINFO = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBoxMail = new System.Windows.Forms.PictureBox();
            this.pictureBoxInstangram = new System.Windows.Forms.PictureBox();
            this.pictureBoxLinkedn = new System.Windows.Forms.PictureBox();
            this.linkLabelSoruGorus = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelWebSitesi = new System.Windows.Forms.LinkLabel();
            this.timerGauge = new System.Windows.Forms.Timer(this.components);
            this.timerSerialCheck = new System.Windows.Forms.Timer(this.components);
            this.headingIndicatorInstrumentControl1 = new AvionicsInstrumentControlDemo.HeadingIndicatorInstrumentControl();
            this.attitudeIndicatorInstrumentControl1 = new AvionicsInstrumentControlDemo.AttitudeIndicatorInstrumentControl();
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
            this.groupBoxRateYaw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericFILTY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericIMAXY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericIY)).BeginInit();
            this.groupBoxRatePitch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericFILTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericIMAXP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericIP)).BeginInit();
            this.groupBoxRateRoll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericFILTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericIMAXR)).BeginInit();
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
            this.panelUpper.Size = new System.Drawing.Size(1924, 104);
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
            this.ButtonDisconnect.Location = new System.Drawing.Point(1616, 19);
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
            this.ButtonConnect.Location = new System.Drawing.Point(1378, 19);
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
            this.ComboBoxPorts.Location = new System.Drawing.Point(1179, 32);
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
            this.ComboBoxBaudRates.Location = new System.Drawing.Point(959, 32);
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
            this.pictureBoxGrey.Location = new System.Drawing.Point(642, 34);
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
            this.pictureBoxGreen.Location = new System.Drawing.Point(642, 34);
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
            this.labelNoConnection.Location = new System.Drawing.Point(680, 32);
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
            this.labelConnected.Location = new System.Drawing.Point(680, 32);
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
            this.TabControl.Size = new System.Drawing.Size(1924, 951);
            this.TabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.TabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.TabControl.TabButtonHoverState.Font = new System.Drawing.Font("Nirmala UI Semilight", 16.2F);
            this.TabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.TabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.TabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabControl.TabButtonIdleState.Font = new System.Drawing.Font("Nirmala UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.TabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.TabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.TabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
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
            this.tabPageWATCH.Size = new System.Drawing.Size(1916, 883);
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
            this.panelMiddleAbove.Size = new System.Drawing.Size(1910, 877);
            this.panelMiddleAbove.TabIndex = 37;
            // 
            // panelBelow
            // 
            this.panelBelow.Controls.Add(this.panelBottomLeft);
            this.panelBelow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBelow.Location = new System.Drawing.Point(3, 660);
            this.panelBelow.Name = "panelBelow";
            this.panelBelow.Size = new System.Drawing.Size(758, 214);
            this.panelBelow.TabIndex = 40;
            // 
            // panelBottomLeft
            // 
            this.panelBottomLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottomLeft.Location = new System.Drawing.Point(0, 0);
            this.panelBottomLeft.Name = "panelBottomLeft";
            this.panelBottomLeft.Size = new System.Drawing.Size(758, 214);
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
            this.panelLeft.Size = new System.Drawing.Size(758, 651);
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
            this.ButtonDeleteWaypoint.Location = new System.Drawing.Point(573, 517);
            this.ButtonDeleteWaypoint.Name = "ButtonDeleteWaypoint";
            this.ButtonDeleteWaypoint.PressedColor = System.Drawing.Color.MintCream;
            this.ButtonDeleteWaypoint.Size = new System.Drawing.Size(160, 114);
            this.ButtonDeleteWaypoint.TabIndex = 68;
            this.ButtonDeleteWaypoint.Text = "Delete Last Point";
            this.ButtonDeleteWaypoint.Click += new System.EventHandler(this.ButtonDeleteWaypoint_Click);
            // 
            // dataGridViewWaypoints
            // 
            this.dataGridViewWaypoints.AllowUserToAddRows = false;
            this.dataGridViewWaypoints.AllowUserToDeleteRows = false;
            this.dataGridViewWaypoints.AllowUserToResizeColumns = false;
            this.dataGridViewWaypoints.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewWaypoints.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewWaypoints.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.dataGridViewWaypoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGridViewWaypoints.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewWaypoints.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewWaypoints.ColumnHeadersHeight = 35;
            this.dataGridViewWaypoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewWaypoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idx,
            this.Type,
            this.Altitude,
            this.Longitude,
            this.Latitude});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewWaypoints.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewWaypoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWaypoints.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.dataGridViewWaypoints.Location = new System.Drawing.Point(767, 660);
            this.dataGridViewWaypoints.Name = "dataGridViewWaypoints";
            this.dataGridViewWaypoints.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewWaypoints.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewWaypoints.RowHeadersVisible = false;
            this.dataGridViewWaypoints.RowHeadersWidth = 51;
            this.dataGridViewWaypoints.RowTemplate.Height = 24;
            this.dataGridViewWaypoints.Size = new System.Drawing.Size(1140, 214);
            this.dataGridViewWaypoints.TabIndex = 43;
            this.dataGridViewWaypoints.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewWaypoints.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewWaypoints.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewWaypoints.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewWaypoints.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewWaypoints.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.dataGridViewWaypoints.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.dataGridViewWaypoints.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewWaypoints.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewWaypoints.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridViewWaypoints.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.dataGridViewWaypoints.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewWaypoints.ThemeStyle.HeaderStyle.Height = 35;
            this.dataGridViewWaypoints.ThemeStyle.ReadOnly = true;
            this.dataGridViewWaypoints.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewWaypoints.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewWaypoints.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridViewWaypoints.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewWaypoints.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridViewWaypoints.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
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
            this.webViewMap.Location = new System.Drawing.Point(767, 3);
            this.webViewMap.Name = "webViewMap";
            this.webViewMap.Size = new System.Drawing.Size(1140, 651);
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
            this.tabPageGRAPH.Size = new System.Drawing.Size(1916, 883);
            this.tabPageGRAPH.TabIndex = 1;
            this.tabPageGRAPH.Text = "GRAPH";
            // 
            // radioNone
            // 
            this.radioNone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioNone.AutoSize = true;
            this.radioNone.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNone.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioNone.Location = new System.Drawing.Point(542, 76);
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
            this.radioYawSetpoint.Location = new System.Drawing.Point(297, 121);
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
            this.radioPitchSetpoint.Location = new System.Drawing.Point(300, 76);
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
            this.radioRollSetpoint.Location = new System.Drawing.Point(299, 31);
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
            this.radioRollPitch.Location = new System.Drawing.Point(554, 31);
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
            this.radioYaw.Location = new System.Drawing.Point(107, 121);
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
            this.radioPitch.Location = new System.Drawing.Point(110, 76);
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
            this.radioRoll.Location = new System.Drawing.Point(109, 31);
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
            this.ButtonOpenFolder.Location = new System.Drawing.Point(786, 152);
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
            this.ButtonSaveLog.Location = new System.Drawing.Point(786, 92);
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
            this.ButtonStartLog.Location = new System.Drawing.Point(786, 31);
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
            this.tabPageDATA.Size = new System.Drawing.Size(1916, 883);
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
            this.tabPagePID.Controls.Add(this.groupBoxRateYaw);
            this.tabPagePID.Controls.Add(this.groupBoxRatePitch);
            this.tabPagePID.Controls.Add(this.groupBoxRateRoll);
            this.tabPagePID.Location = new System.Drawing.Point(4, 64);
            this.tabPagePID.Name = "tabPagePID";
            this.tabPagePID.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePID.Size = new System.Drawing.Size(1916, 883);
            this.tabPagePID.TabIndex = 3;
            this.tabPagePID.Text = "PID";
            // 
            // groupBoxRateYaw
            // 
            this.groupBoxRateYaw.Controls.Add(this.ButtonYawRefresh);
            this.groupBoxRateYaw.Controls.Add(this.ButtonYawWrite);
            this.groupBoxRateYaw.Controls.Add(this.NumericFILTY);
            this.groupBoxRateYaw.Controls.Add(this.NumericIMAXY);
            this.groupBoxRateYaw.Controls.Add(this.NumericPY);
            this.groupBoxRateYaw.Controls.Add(this.labelPY);
            this.groupBoxRateYaw.Controls.Add(this.NumericDY);
            this.groupBoxRateYaw.Controls.Add(this.labelIY);
            this.groupBoxRateYaw.Controls.Add(this.NumericIY);
            this.groupBoxRateYaw.Controls.Add(this.labelDY);
            this.groupBoxRateYaw.Controls.Add(this.labelIMAXY);
            this.groupBoxRateYaw.Controls.Add(this.labelFILTY);
            this.groupBoxRateYaw.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRateYaw.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxRateYaw.Location = new System.Drawing.Point(763, 421);
            this.groupBoxRateYaw.Name = "groupBoxRateYaw";
            this.groupBoxRateYaw.Size = new System.Drawing.Size(709, 362);
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
            // NumericFILTY
            // 
            this.NumericFILTY.BackColor = System.Drawing.Color.Transparent;
            this.NumericFILTY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericFILTY.FillColor = System.Drawing.Color.Snow;
            this.NumericFILTY.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericFILTY.Location = new System.Drawing.Point(192, 284);
            this.NumericFILTY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericFILTY.Name = "NumericFILTY";
            this.NumericFILTY.Size = new System.Drawing.Size(139, 27);
            this.NumericFILTY.TabIndex = 13;
            // 
            // NumericIMAXY
            // 
            this.NumericIMAXY.BackColor = System.Drawing.Color.Transparent;
            this.NumericIMAXY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericIMAXY.FillColor = System.Drawing.Color.Snow;
            this.NumericIMAXY.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericIMAXY.Location = new System.Drawing.Point(192, 231);
            this.NumericIMAXY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericIMAXY.Name = "NumericIMAXY";
            this.NumericIMAXY.Size = new System.Drawing.Size(139, 27);
            this.NumericIMAXY.TabIndex = 14;
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
            // labelIMAXY
            // 
            this.labelIMAXY.AutoSize = true;
            this.labelIMAXY.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIMAXY.ForeColor = System.Drawing.SystemColors.Control;
            this.labelIMAXY.Location = new System.Drawing.Point(67, 231);
            this.labelIMAXY.Name = "labelIMAXY";
            this.labelIMAXY.Size = new System.Drawing.Size(59, 28);
            this.labelIMAXY.TabIndex = 4;
            this.labelIMAXY.Text = "IMAX";
            // 
            // labelFILTY
            // 
            this.labelFILTY.AutoSize = true;
            this.labelFILTY.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFILTY.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFILTY.Location = new System.Drawing.Point(67, 284);
            this.labelFILTY.Name = "labelFILTY";
            this.labelFILTY.Size = new System.Drawing.Size(45, 28);
            this.labelFILTY.TabIndex = 5;
            this.labelFILTY.Text = "FILT";
            // 
            // groupBoxRatePitch
            // 
            this.groupBoxRatePitch.Controls.Add(this.ButtonPitchRefresh);
            this.groupBoxRatePitch.Controls.Add(this.ButtonPitchWrite);
            this.groupBoxRatePitch.Controls.Add(this.NumericFILTP);
            this.groupBoxRatePitch.Controls.Add(this.NumericIMAXP);
            this.groupBoxRatePitch.Controls.Add(this.NumericPP);
            this.groupBoxRatePitch.Controls.Add(this.labelPP);
            this.groupBoxRatePitch.Controls.Add(this.NumericDP);
            this.groupBoxRatePitch.Controls.Add(this.labelIP);
            this.groupBoxRatePitch.Controls.Add(this.NumericIP);
            this.groupBoxRatePitch.Controls.Add(this.labelDP);
            this.groupBoxRatePitch.Controls.Add(this.labelIMAXP);
            this.groupBoxRatePitch.Controls.Add(this.labelFILTP);
            this.groupBoxRatePitch.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRatePitch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxRatePitch.Location = new System.Drawing.Point(763, 28);
            this.groupBoxRatePitch.Name = "groupBoxRatePitch";
            this.groupBoxRatePitch.Size = new System.Drawing.Size(709, 362);
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
            // NumericFILTP
            // 
            this.NumericFILTP.BackColor = System.Drawing.Color.Transparent;
            this.NumericFILTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericFILTP.FillColor = System.Drawing.Color.Snow;
            this.NumericFILTP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericFILTP.Location = new System.Drawing.Point(174, 285);
            this.NumericFILTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericFILTP.Name = "NumericFILTP";
            this.NumericFILTP.Size = new System.Drawing.Size(139, 27);
            this.NumericFILTP.TabIndex = 13;
            // 
            // NumericIMAXP
            // 
            this.NumericIMAXP.BackColor = System.Drawing.Color.Transparent;
            this.NumericIMAXP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericIMAXP.FillColor = System.Drawing.Color.Snow;
            this.NumericIMAXP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericIMAXP.Location = new System.Drawing.Point(174, 233);
            this.NumericIMAXP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericIMAXP.Name = "NumericIMAXP";
            this.NumericIMAXP.Size = new System.Drawing.Size(139, 27);
            this.NumericIMAXP.TabIndex = 14;
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
            this.labelIMAXP.Size = new System.Drawing.Size(59, 28);
            this.labelIMAXP.TabIndex = 4;
            this.labelIMAXP.Text = "IMAX";
            // 
            // labelFILTP
            // 
            this.labelFILTP.AutoSize = true;
            this.labelFILTP.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFILTP.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFILTP.Location = new System.Drawing.Point(60, 285);
            this.labelFILTP.Name = "labelFILTP";
            this.labelFILTP.Size = new System.Drawing.Size(45, 28);
            this.labelFILTP.TabIndex = 5;
            this.labelFILTP.Text = "FILT";
            // 
            // groupBoxRateRoll
            // 
            this.groupBoxRateRoll.Controls.Add(this.ButtonRollRefresh);
            this.groupBoxRateRoll.Controls.Add(this.ButtonRollWrite);
            this.groupBoxRateRoll.Controls.Add(this.NumericFILTR);
            this.groupBoxRateRoll.Controls.Add(this.NumericIMAXR);
            this.groupBoxRateRoll.Controls.Add(this.NumericPR);
            this.groupBoxRateRoll.Controls.Add(this.labelPR);
            this.groupBoxRateRoll.Controls.Add(this.NumericDR);
            this.groupBoxRateRoll.Controls.Add(this.labelIR);
            this.groupBoxRateRoll.Controls.Add(this.NumericIR);
            this.groupBoxRateRoll.Controls.Add(this.labelDR);
            this.groupBoxRateRoll.Controls.Add(this.labelIMAXR);
            this.groupBoxRateRoll.Controls.Add(this.labelFILTR);
            this.groupBoxRateRoll.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRateRoll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxRateRoll.Location = new System.Drawing.Point(34, 28);
            this.groupBoxRateRoll.Name = "groupBoxRateRoll";
            this.groupBoxRateRoll.Size = new System.Drawing.Size(709, 362);
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
            // NumericFILTR
            // 
            this.NumericFILTR.BackColor = System.Drawing.Color.Transparent;
            this.NumericFILTR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericFILTR.FillColor = System.Drawing.Color.Snow;
            this.NumericFILTR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericFILTR.Location = new System.Drawing.Point(183, 285);
            this.NumericFILTR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericFILTR.Name = "NumericFILTR";
            this.NumericFILTR.Size = new System.Drawing.Size(139, 27);
            this.NumericFILTR.TabIndex = 13;
            // 
            // NumericIMAXR
            // 
            this.NumericIMAXR.BackColor = System.Drawing.Color.Transparent;
            this.NumericIMAXR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericIMAXR.FillColor = System.Drawing.Color.Snow;
            this.NumericIMAXR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericIMAXR.Location = new System.Drawing.Point(183, 232);
            this.NumericIMAXR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericIMAXR.Name = "NumericIMAXR";
            this.NumericIMAXR.Size = new System.Drawing.Size(139, 27);
            this.NumericIMAXR.TabIndex = 14;
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
            this.labelIMAXR.Size = new System.Drawing.Size(59, 28);
            this.labelIMAXR.TabIndex = 4;
            this.labelIMAXR.Text = "IMAX";
            // 
            // labelFILTR
            // 
            this.labelFILTR.AutoSize = true;
            this.labelFILTR.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFILTR.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFILTR.Location = new System.Drawing.Point(57, 285);
            this.labelFILTR.Name = "labelFILTR";
            this.labelFILTR.Size = new System.Drawing.Size(45, 28);
            this.labelFILTR.TabIndex = 5;
            this.labelFILTR.Text = "FILT";
            // 
            // tabPageINFO
            // 
            this.tabPageINFO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.tabPageINFO.Location = new System.Drawing.Point(4, 64);
            this.tabPageINFO.Name = "tabPageINFO";
            this.tabPageINFO.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageINFO.Size = new System.Drawing.Size(1916, 883);
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
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.linkLabelWebSitesi);
            this.tabPage1.Location = new System.Drawing.Point(4, 64);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1916, 883);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "INFO";
            // 
            // pictureBoxMail
            // 
            this.pictureBoxMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMail.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMail.Image")));
            this.pictureBoxMail.Location = new System.Drawing.Point(342, 426);
            this.pictureBoxMail.Name = "pictureBoxMail";
            this.pictureBoxMail.Size = new System.Drawing.Size(98, 90);
            this.pictureBoxMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMail.TabIndex = 81;
            this.pictureBoxMail.TabStop = false;
            this.pictureBoxMail.Click += new System.EventHandler(this.pictureBoxMail_Click);
            // 
            // pictureBoxInstangram
            // 
            this.pictureBoxInstangram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxInstangram.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInstangram.Image")));
            this.pictureBoxInstangram.Location = new System.Drawing.Point(211, 426);
            this.pictureBoxInstangram.Name = "pictureBoxInstangram";
            this.pictureBoxInstangram.Size = new System.Drawing.Size(98, 90);
            this.pictureBoxInstangram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInstangram.TabIndex = 80;
            this.pictureBoxInstangram.TabStop = false;
            this.pictureBoxInstangram.Click += new System.EventHandler(this.pictureBoxInstangram_Click);
            // 
            // pictureBoxLinkedn
            // 
            this.pictureBoxLinkedn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLinkedn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLinkedn.Image")));
            this.pictureBoxLinkedn.Location = new System.Drawing.Point(80, 426);
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
            this.linkLabelSoruGorus.LinkColor = System.Drawing.Color.White;
            this.linkLabelSoruGorus.Location = new System.Drawing.Point(76, 254);
            this.linkLabelSoruGorus.Name = "linkLabelSoruGorus";
            this.linkLabelSoruGorus.Size = new System.Drawing.Size(341, 38);
            this.linkLabelSoruGorus.TabIndex = 78;
            this.linkLabelSoruGorus.TabStop = true;
            this.linkLabelSoruGorus.Text = "Soru ve Görüşleriniz İçin";
            this.linkLabelSoruGorus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSoruGorus_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(70, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 59);
            this.label1.TabIndex = 77;
            this.label1.Text = "Hakkımızda";
            // 
            // linkLabelWebSitesi
            // 
            this.linkLabelWebSitesi.AutoSize = true;
            this.linkLabelWebSitesi.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelWebSitesi.LinkColor = System.Drawing.Color.White;
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
            // AspanGround
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
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
            this.groupBoxRateYaw.ResumeLayout(false);
            this.groupBoxRateYaw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericFILTY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericIMAXY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericIY)).EndInit();
            this.groupBoxRatePitch.ResumeLayout(false);
            this.groupBoxRatePitch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericFILTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericIMAXP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericIP)).EndInit();
            this.groupBoxRateRoll.ResumeLayout(false);
            this.groupBoxRateRoll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericFILTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericIMAXR)).EndInit();
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
        private System.Windows.Forms.Label labelFILTR;
        private System.Windows.Forms.Label labelIMAXR;
        private System.Windows.Forms.Label labelIR;
        private System.Windows.Forms.Label labelDR;
        private System.Windows.Forms.Label labelPR;
        private System.Windows.Forms.GroupBox groupBoxRateRoll;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericFILTR;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericIMAXR;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericPR;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericDR;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericIR;
        private System.Windows.Forms.GroupBox groupBoxRateYaw;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericFILTY;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericIMAXY;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericPY;
        private System.Windows.Forms.Label labelPY;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericDY;
        private System.Windows.Forms.Label labelIY;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericIY;
        private System.Windows.Forms.Label labelDY;
        private System.Windows.Forms.Label labelIMAXY;
        private System.Windows.Forms.Label labelFILTY;
        private System.Windows.Forms.GroupBox groupBoxRatePitch;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericFILTP;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericIMAXP;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericPP;
        private System.Windows.Forms.Label labelPP;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericDP;
        private System.Windows.Forms.Label labelIP;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericIP;
        private System.Windows.Forms.Label labelDP;
        private System.Windows.Forms.Label labelIMAXP;
        private System.Windows.Forms.Label labelFILTP;
        private System.Windows.Forms.LinkLabel linkLabelWebSitesi;
        private System.Windows.Forms.Label label1;
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
    }
}

