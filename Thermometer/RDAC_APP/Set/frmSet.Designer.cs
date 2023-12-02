namespace Thermometer_APP
{
    partial class frmSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSet));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnClose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numMaxWetness = new System.Windows.Forms.NumericUpDown();
            this.numMaxTemprature = new System.Windows.Forms.NumericUpDown();
            this.numMinWetness = new System.Windows.Forms.NumericUpDown();
            this.numMinTemprature = new System.Windows.Forms.NumericUpDown();
            this.numMaxHumidity = new System.Windows.Forms.NumericUpDown();
            this.numMinHumidity = new System.Windows.Forms.NumericUpDown();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnSetValue = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxWetness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxTemprature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinWetness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinTemprature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinHumidity)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.ButtonText = "Close";
            this.btnClose.ButtonTextMarginLeft = 0;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnClose.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnClose.DisabledForecolor = System.Drawing.Color.White;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.IconPadding = 10;
            this.btnClose.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.IdleBorderRadius = 25;
            this.btnClose.IdleBorderThickness = 0;
            this.btnClose.IdleFillColor = System.Drawing.Color.Maroon;
            this.btnClose.IdleIconLeftImage = null;
            this.btnClose.IdleIconRightImage = null;
            this.btnClose.Location = new System.Drawing.Point(303, 223);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 25;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = global::Thermometer_APP.Properties.Resources.Broken_file;
            this.btnClose.onHoverState = stateProperties2;
            this.btnClose.Size = new System.Drawing.Size(123, 51);
            this.btnClose.TabIndex = 0;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numMaxWetness);
            this.groupBox1.Controls.Add(this.numMaxTemprature);
            this.groupBox1.Controls.Add(this.numMinWetness);
            this.groupBox1.Controls.Add(this.numMinTemprature);
            this.groupBox1.Controls.Add(this.numMaxHumidity);
            this.groupBox1.Controls.Add(this.numMinHumidity);
            this.groupBox1.Controls.Add(this.bunifuLabel5);
            this.groupBox1.Controls.Add(this.bunifuLabel2);
            this.groupBox1.Controls.Add(this.btnSetValue);
            this.groupBox1.Controls.Add(this.bunifuLabel4);
            this.groupBox1.Controls.Add(this.bunifuLabel3);
            this.groupBox1.Controls.Add(this.bunifuLabel1);
            this.groupBox1.Location = new System.Drawing.Point(11, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(415, 201);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set";
            // 
            // numMaxWetness
            // 
            this.numMaxWetness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMaxWetness.Location = new System.Drawing.Point(278, 101);
            this.numMaxWetness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numMaxWetness.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numMaxWetness.Name = "numMaxWetness";
            this.numMaxWetness.Size = new System.Drawing.Size(105, 21);
            this.numMaxWetness.TabIndex = 1;
            // 
            // numMaxTemprature
            // 
            this.numMaxTemprature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMaxTemprature.Location = new System.Drawing.Point(278, 70);
            this.numMaxTemprature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numMaxTemprature.Name = "numMaxTemprature";
            this.numMaxTemprature.Size = new System.Drawing.Size(105, 21);
            this.numMaxTemprature.TabIndex = 1;
            // 
            // numMinWetness
            // 
            this.numMinWetness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMinWetness.Location = new System.Drawing.Point(122, 101);
            this.numMinWetness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numMinWetness.Name = "numMinWetness";
            this.numMinWetness.Size = new System.Drawing.Size(105, 21);
            this.numMinWetness.TabIndex = 1;
            // 
            // numMinTemprature
            // 
            this.numMinTemprature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMinTemprature.Location = new System.Drawing.Point(122, 70);
            this.numMinTemprature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numMinTemprature.Name = "numMinTemprature";
            this.numMinTemprature.Size = new System.Drawing.Size(105, 21);
            this.numMinTemprature.TabIndex = 1;
            // 
            // numMaxHumidity
            // 
            this.numMaxHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMaxHumidity.Location = new System.Drawing.Point(278, 40);
            this.numMaxHumidity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numMaxHumidity.Name = "numMaxHumidity";
            this.numMaxHumidity.Size = new System.Drawing.Size(105, 21);
            this.numMaxHumidity.TabIndex = 1;
            // 
            // numMinHumidity
            // 
            this.numMinHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMinHumidity.Location = new System.Drawing.Point(122, 40);
            this.numMinHumidity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numMinHumidity.Name = "numMinHumidity";
            this.numMinHumidity.Size = new System.Drawing.Size(105, 21);
            this.numMinHumidity.TabIndex = 1;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel5.Location = new System.Drawing.Point(43, 101);
            this.bunifuLabel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(56, 17);
            this.bunifuLabel5.TabIndex = 0;
            this.bunifuLabel5.Text = "Wetness :";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(32, 70);
            this.bunifuLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(73, 17);
            this.bunifuLabel2.TabIndex = 0;
            this.bunifuLabel2.Text = "Temprature :";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnSetValue
            // 
            this.btnSetValue.BackColor = System.Drawing.Color.Transparent;
            this.btnSetValue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetValue.BackgroundImage")));
            this.btnSetValue.ButtonText = "Set";
            this.btnSetValue.ButtonTextMarginLeft = 0;
            this.btnSetValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetValue.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSetValue.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnSetValue.DisabledForecolor = System.Drawing.Color.White;
            this.btnSetValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetValue.ForeColor = System.Drawing.Color.White;
            this.btnSetValue.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSetValue.IconPadding = 10;
            this.btnSetValue.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSetValue.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSetValue.IdleBorderRadius = 25;
            this.btnSetValue.IdleBorderThickness = 0;
            this.btnSetValue.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSetValue.IdleIconLeftImage = null;
            this.btnSetValue.IdleIconRightImage = null;
            this.btnSetValue.Location = new System.Drawing.Point(269, 137);
            this.btnSetValue.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetValue.Name = "btnSetValue";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 25;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.Green;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = global::Thermometer_APP.Properties.Resources.Data_file;
            this.btnSetValue.onHoverState = stateProperties1;
            this.btnSetValue.Size = new System.Drawing.Size(125, 47);
            this.btnSetValue.TabIndex = 0;
            this.btnSetValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSetValue.Click += new System.EventHandler(this.btnSetValue_Click);
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.Location = new System.Drawing.Point(318, 19);
            this.bunifuLabel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(27, 17);
            this.bunifuLabel4.TabIndex = 0;
            this.bunifuLabel4.Text = "Max";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.Location = new System.Drawing.Point(158, 19);
            this.bunifuLabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(24, 17);
            this.bunifuLabel3.TabIndex = 0;
            this.bunifuLabel3.Text = "Min";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(43, 40);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(57, 17);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Humidity : ";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 277);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSet";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSet";
            //this.Load += new System.EventHandler(this.frmSet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxWetness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxTemprature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinWetness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinTemprature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinHumidity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSetValue;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        public System.Windows.Forms.NumericUpDown numMinTemprature;
        public System.Windows.Forms.NumericUpDown numMinHumidity;
        public System.Windows.Forms.NumericUpDown numMaxTemprature;
        public System.Windows.Forms.NumericUpDown numMaxHumidity;
        public System.Windows.Forms.NumericUpDown numMaxWetness;
        public System.Windows.Forms.NumericUpDown numMinWetness;
    }
}