namespace Thermometer_APP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnExit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSet = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnDisconnect = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnConnect = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbLoad = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCondition = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.chartControl = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnExportData = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.statusInfoValue = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTemprature = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel10 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel11 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHumidity = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel13 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblWetness = new System.Windows.Forms.ToolStripStatusLabel();
            this.epHumidity = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTemprature = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWetness = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            this.statusInfoValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTemprature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWetness)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.ButtonText = "Exit";
            this.btnExit.ButtonTextMarginLeft = 0;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnExit.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnExit.DisabledForecolor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("AntsyPants", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.IconPadding = 10;
            this.btnExit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnExit.IdleBorderRadius = 15;
            this.btnExit.IdleBorderThickness = 0;
            this.btnExit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.IdleIconLeftImage = null;
            this.btnExit.IdleIconRightImage = null;
            this.btnExit.Location = new System.Drawing.Point(1, 232);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 15;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            stateProperties2.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("stateProperties2.IconLeftImage")));
            stateProperties2.IconRightImage = ((System.Drawing.Image)(resources.GetObject("stateProperties2.IconRightImage")));
            this.btnExit.onHoverState = stateProperties2;
            this.btnExit.Size = new System.Drawing.Size(200, 55);
            this.btnExit.TabIndex = 0;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.Transparent;
            this.btnSet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSet.BackgroundImage")));
            this.btnSet.ButtonText = "Set";
            this.btnSet.ButtonTextMarginLeft = 0;
            this.btnSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSet.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSet.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnSet.DisabledForecolor = System.Drawing.Color.White;
            this.btnSet.Font = new System.Drawing.Font("AntsyPants", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.ForeColor = System.Drawing.Color.White;
            this.btnSet.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSet.IconPadding = 10;
            this.btnSet.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSet.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSet.IdleBorderRadius = 15;
            this.btnSet.IdleBorderThickness = 0;
            this.btnSet.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSet.IdleIconLeftImage = null;
            this.btnSet.IdleIconRightImage = null;
            this.btnSet.Location = new System.Drawing.Point(1, 116);
            this.btnSet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSet.Name = "btnSet";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.BorderRadius = 15;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            stateProperties3.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("stateProperties3.IconLeftImage")));
            stateProperties3.IconRightImage = global::Thermometer_APP.Properties.Resources.Edit_file;
            this.btnSet.onHoverState = stateProperties3;
            this.btnSet.Size = new System.Drawing.Size(200, 55);
            this.btnSet.TabIndex = 0;
            this.btnSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.Transparent;
            this.btnDisconnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDisconnect.BackgroundImage")));
            this.btnDisconnect.ButtonText = "Disconnect";
            this.btnDisconnect.ButtonTextMarginLeft = 0;
            this.btnDisconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisconnect.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnDisconnect.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnDisconnect.DisabledForecolor = System.Drawing.Color.White;
            this.btnDisconnect.Font = new System.Drawing.Font("AntsyPants", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.ForeColor = System.Drawing.Color.White;
            this.btnDisconnect.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDisconnect.IconPadding = 10;
            this.btnDisconnect.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDisconnect.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnDisconnect.IdleBorderRadius = 15;
            this.btnDisconnect.IdleBorderThickness = 0;
            this.btnDisconnect.IdleFillColor = System.Drawing.Color.Green;
            this.btnDisconnect.IdleIconLeftImage = null;
            this.btnDisconnect.IdleIconRightImage = null;
            this.btnDisconnect.Location = new System.Drawing.Point(1, 58);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDisconnect.Name = "btnDisconnect";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties5.BorderRadius = 15;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.Maroon;
            stateProperties5.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("stateProperties5.IconLeftImage")));
            stateProperties5.IconRightImage = global::Thermometer_APP.Properties.Resources.Restricted_file;
            this.btnDisconnect.onHoverState = stateProperties5;
            this.btnDisconnect.Size = new System.Drawing.Size(200, 55);
            this.btnDisconnect.TabIndex = 0;
            this.btnDisconnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Transparent;
            this.btnConnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConnect.BackgroundImage")));
            this.btnConnect.ButtonText = "Connect";
            this.btnConnect.ButtonTextMarginLeft = 0;
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnConnect.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnConnect.DisabledForecolor = System.Drawing.Color.White;
            this.btnConnect.Font = new System.Drawing.Font("AntsyPants", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnConnect.IconPadding = 10;
            this.btnConnect.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnConnect.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnConnect.IdleBorderRadius = 15;
            this.btnConnect.IdleBorderThickness = 0;
            this.btnConnect.IdleFillColor = System.Drawing.Color.Green;
            this.btnConnect.IdleIconLeftImage = null;
            this.btnConnect.IdleIconRightImage = null;
            this.btnConnect.Location = new System.Drawing.Point(1, 2);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConnect.Name = "btnConnect";
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 15;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.Teal;
            stateProperties4.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("stateProperties4.IconLeftImage")));
            stateProperties4.IconRightImage = global::Thermometer_APP.Properties.Resources.File_security;
            this.btnConnect.onHoverState = stateProperties4;
            this.btnConnect.Size = new System.Drawing.Size(200, 55);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Thermometer_APP.Properties.Resources.download_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(340, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM3";
            // 
            // statusStrip
            // 
            this.statusStrip.AutoSize = false;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel4,
            this.pbLoad,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel1,
            this.lblCondition,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel5,
            this.lblTime,
            this.lblDate,
            this.toolStripStatusLabel6});
            this.statusStrip.Location = new System.Drawing.Point(0, 434);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(750, 26);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(10, 21);
            this.toolStripStatusLabel4.Text = "|";
            // 
            // pbLoad
            // 
            this.pbLoad.Name = "pbLoad";
            this.pbLoad.Size = new System.Drawing.Size(100, 20);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(10, 21);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 21);
            this.toolStripStatusLabel1.Text = "Condition : ";
            // 
            // lblCondition
            // 
            this.lblCondition.BackColor = System.Drawing.Color.Transparent;
            this.lblCondition.ForeColor = System.Drawing.Color.IndianRed;
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.RightToLeftAutoMirrorImage = true;
            this.lblCondition.Size = new System.Drawing.Size(66, 21);
            this.lblCondition.Text = "Disconnect";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 21);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(43, 21);
            this.toolStripStatusLabel5.Text = "Time : ";
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(67, 21);
            this.lblTime.Text = "Time           ";
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 21);
            this.lblDate.Text = "Date       ";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(10, 21);
            this.toolStripStatusLabel6.Text = "|";
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // chartControl
            // 
            chartArea1.Name = "ChartArea1";
            this.chartControl.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartControl.Legends.Add(legend1);
            this.chartControl.Location = new System.Drawing.Point(188, 12);
            this.chartControl.Name = "chartControl";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "temperature";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Humidity";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Wetness";
            this.chartControl.Series.Add(series1);
            this.chartControl.Series.Add(series2);
            this.chartControl.Series.Add(series3);
            this.chartControl.Size = new System.Drawing.Size(538, 331);
            this.chartControl.TabIndex = 5;
            this.chartControl.Text = "chart1";
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(188, 347);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData.Size = new System.Drawing.Size(538, 47);
            this.txtData.TabIndex = 6;
            // 
            // btnExportData
            // 
            this.btnExportData.BackColor = System.Drawing.Color.Transparent;
            this.btnExportData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportData.BackgroundImage")));
            this.btnExportData.ButtonText = "ExportData";
            this.btnExportData.ButtonTextMarginLeft = 0;
            this.btnExportData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportData.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnExportData.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnExportData.DisabledForecolor = System.Drawing.Color.White;
            this.btnExportData.Font = new System.Drawing.Font("AntsyPants", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportData.ForeColor = System.Drawing.Color.White;
            this.btnExportData.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExportData.IconPadding = 10;
            this.btnExportData.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExportData.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnExportData.IdleBorderRadius = 15;
            this.btnExportData.IdleBorderThickness = 0;
            this.btnExportData.IdleFillColor = System.Drawing.Color.Blue;
            this.btnExportData.IdleIconLeftImage = null;
            this.btnExportData.IdleIconRightImage = null;
            this.btnExportData.Location = new System.Drawing.Point(1, 174);
            this.btnExportData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportData.Name = "btnExportData";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 15;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            stateProperties1.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("stateProperties1.IconLeftImage")));
            stateProperties1.IconRightImage = global::Thermometer_APP.Properties.Resources.Stats_file;
            this.btnExportData.onHoverState = stateProperties1;
            this.btnExportData.Size = new System.Drawing.Size(200, 55);
            this.btnExportData.TabIndex = 0;
            this.btnExportData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExportData.Click += new System.EventHandler(this.btnExportData_Click);
            // 
            // statusInfoValue
            // 
            this.statusInfoValue.AutoSize = false;
            this.statusInfoValue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel8,
            this.lblTemprature,
            this.toolStripStatusLabel10,
            this.toolStripStatusLabel11,
            this.lblHumidity,
            this.toolStripStatusLabel13,
            this.toolStripStatusLabel9,
            this.lblWetness});
            this.statusInfoValue.Location = new System.Drawing.Point(0, 408);
            this.statusInfoValue.Name = "statusInfoValue";
            this.statusInfoValue.Size = new System.Drawing.Size(750, 26);
            this.statusInfoValue.TabIndex = 7;
            this.statusInfoValue.Text = "statusStrip1";
            this.statusInfoValue.Visible = false;
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(10, 21);
            this.toolStripStatusLabel7.Text = "|";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel8.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(75, 21);
            this.toolStripStatusLabel8.Text = "Temprature :";
            // 
            // lblTemprature
            // 
            this.lblTemprature.BackColor = System.Drawing.Color.Transparent;
            this.lblTemprature.ForeColor = System.Drawing.Color.Blue;
            this.lblTemprature.Name = "lblTemprature";
            this.lblTemprature.Size = new System.Drawing.Size(25, 21);
            this.lblTemprature.Text = "222";
            // 
            // toolStripStatusLabel10
            // 
            this.toolStripStatusLabel10.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel10.Name = "toolStripStatusLabel10";
            this.toolStripStatusLabel10.Size = new System.Drawing.Size(10, 21);
            this.toolStripStatusLabel10.Text = "|";
            // 
            // toolStripStatusLabel11
            // 
            this.toolStripStatusLabel11.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripStatusLabel11.Name = "toolStripStatusLabel11";
            this.toolStripStatusLabel11.Size = new System.Drawing.Size(63, 21);
            this.toolStripStatusLabel11.Text = "Humidity :";
            // 
            // lblHumidity
            // 
            this.lblHumidity.BackColor = System.Drawing.Color.Transparent;
            this.lblHumidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(25, 21);
            this.lblHumidity.Text = "222";
            // 
            // toolStripStatusLabel13
            // 
            this.toolStripStatusLabel13.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel13.Name = "toolStripStatusLabel13";
            this.toolStripStatusLabel13.Size = new System.Drawing.Size(10, 21);
            this.toolStripStatusLabel13.Text = "|";
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel9.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            this.toolStripStatusLabel9.Size = new System.Drawing.Size(57, 21);
            this.toolStripStatusLabel9.Text = "Wetness :";
            // 
            // lblWetness
            // 
            this.lblWetness.BackColor = System.Drawing.Color.Transparent;
            this.lblWetness.ForeColor = System.Drawing.Color.Red;
            this.lblWetness.Name = "lblWetness";
            this.lblWetness.Size = new System.Drawing.Size(31, 21);
            this.lblWetness.Text = "1000";
            // 
            // epHumidity
            // 
            this.epHumidity.ContainerControl = this;
            // 
            // epTemprature
            // 
            this.epTemprature.ContainerControl = this;
            // 
            // epWetness
            // 
            this.epWetness.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(750, 460);
            this.Controls.Add(this.statusInfoValue);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.chartControl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnExportData);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnDisconnect);
            this.Font = new System.Drawing.Font("Star Jedi Outline", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            this.statusInfoValue.ResumeLayout(false);
            this.statusInfoValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTemprature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWetness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnConnect;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSet;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDisconnect;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblCondition;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripProgressBar pbLoad;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartControl;
        public System.Windows.Forms.TextBox txtData;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExportData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel10;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel11;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel13;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
        public System.Windows.Forms.StatusStrip statusInfoValue;
        public System.Windows.Forms.ToolStripStatusLabel lblTemprature;
        public System.Windows.Forms.ToolStripStatusLabel lblHumidity;
        public System.Windows.Forms.ToolStripStatusLabel lblWetness;
        public System.Windows.Forms.ErrorProvider epHumidity;
        public System.Windows.Forms.ErrorProvider epTemprature;
        public System.Windows.Forms.ErrorProvider epWetness;
    }
}

