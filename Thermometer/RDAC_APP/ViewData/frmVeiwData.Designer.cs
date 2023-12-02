namespace Thermometer_APP.ViewData
{
    partial class frmVeiwData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVeiwData));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnClose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnConvertToExcel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Tempreture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wetness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tempreture,
            this.humidity,
            this.Wetness,
            this.Time});
            this.dgvData.Location = new System.Drawing.Point(12, 12);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(596, 320);
            this.dgvData.TabIndex = 0;
            this.dgvData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvData_CellFormatting);
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
            this.btnClose.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.IconPadding = 10;
            this.btnClose.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnClose.IdleBorderRadius = 25;
            this.btnClose.IdleBorderThickness = 0;
            this.btnClose.IdleFillColor = System.Drawing.Color.Red;
            this.btnClose.IdleIconLeftImage = null;
            this.btnClose.IdleIconRightImage = null;
            this.btnClose.Location = new System.Drawing.Point(465, 338);
            this.btnClose.Name = "btnClose";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 25;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = global::Thermometer_APP.Properties.Resources.Broken_file;
            this.btnClose.onHoverState = stateProperties1;
            this.btnClose.Size = new System.Drawing.Size(143, 50);
            this.btnClose.TabIndex = 1;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConvertToExcel
            // 
            this.btnConvertToExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnConvertToExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConvertToExcel.BackgroundImage")));
            this.btnConvertToExcel.ButtonText = "Export To Excel";
            this.btnConvertToExcel.ButtonTextMarginLeft = 0;
            this.btnConvertToExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConvertToExcel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnConvertToExcel.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnConvertToExcel.DisabledForecolor = System.Drawing.Color.White;
            this.btnConvertToExcel.ForeColor = System.Drawing.Color.White;
            this.btnConvertToExcel.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnConvertToExcel.IconPadding = 10;
            this.btnConvertToExcel.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnConvertToExcel.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnConvertToExcel.IdleBorderRadius = 25;
            this.btnConvertToExcel.IdleBorderThickness = 0;
            this.btnConvertToExcel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnConvertToExcel.IdleIconLeftImage = null;
            this.btnConvertToExcel.IdleIconRightImage = null;
            this.btnConvertToExcel.Location = new System.Drawing.Point(316, 338);
            this.btnConvertToExcel.Name = "btnConvertToExcel";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 25;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = global::Thermometer_APP.Properties.Resources.Submit;
            this.btnConvertToExcel.onHoverState = stateProperties2;
            this.btnConvertToExcel.Size = new System.Drawing.Size(143, 50);
            this.btnConvertToExcel.TabIndex = 1;
            this.btnConvertToExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConvertToExcel.Click += new System.EventHandler(this.btnConvertToExcel_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 25;
            this.bunifuElipse2.TargetControl = this;
            // 
            // Tempreture
            // 
            this.Tempreture.DataPropertyName = "tempreture";
            this.Tempreture.HeaderText = "Tempreture";
            this.Tempreture.Name = "Tempreture";
            this.Tempreture.ReadOnly = true;
            // 
            // humidity
            // 
            this.humidity.DataPropertyName = "humidity";
            this.humidity.HeaderText = "humidity";
            this.humidity.Name = "humidity";
            this.humidity.ReadOnly = true;
            this.humidity.Width = 120;
            // 
            // Wetness
            // 
            this.Wetness.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Wetness.DataPropertyName = "Wetness";
            this.Wetness.HeaderText = "Wetness";
            this.Wetness.Name = "Wetness";
            this.Wetness.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "datetime";
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 150;
            // 
            // frmVeiwData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 400);
            this.Controls.Add(this.btnConvertToExcel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVeiwData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVeiwData";
            this.Load += new System.EventHandler(this.frmVeiwData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnConvertToExcel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClose;
        private System.Windows.Forms.DataGridView dgvData;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tempreture;
        private System.Windows.Forms.DataGridViewTextBoxColumn humidity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wetness;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
    }
}