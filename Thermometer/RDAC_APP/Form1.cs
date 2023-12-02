using Bunifu.UI.WinForms.BunifuButton;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using Thermometer_APP.Analyzer;
using Thermometer_APP.Set;
using Thermometer_APP.ViewData;
using Thermometer_APP.InsertData;
using DataLayer.Models;
using DataLayer.Time;
using Thermometer_APP.Model;
using Thermometer_APP.CheckRangeSensor;

namespace Thermometer_APP
{
    public partial class Form1 : Form
    {
        bool PermisionChange = false;
        List<string> reciveDeta = new List<string>();

        public Form1()
        {
            InitializeComponent();
            var Font = Properties.Settings.Default.Font; //Set Font
            this.Font = Font;
            // Defult Setting
            chartControl.Visible = false;
            txtData.Visible = false;
            
        }

        /// <summary>
        /// Funk
        /// For Hover And Leave In Margin Button
        public void Hover(BunifuButton button)
        {
            button.Width = 230;
        }
        public void LeaveHover(BunifuButton button)
        {
            button.Width = 190;
        }
        // If Application Connect to device This Function's Run
        // This Function For Change Width Buttons
        public void ChangeLocation()
        {
            if (PermisionChange == false)
            {
                btnConnect.Width = 150;
                btnDisconnect.Width = 150;
                btnSet.Width = 150;
                btnExit.Width = 150;
                btnExportData.Width = 150;
                PermisionChange = true;
            }

        }

        //Exit Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            pbLoad.Style = ProgressBarStyle.Marquee;
            pbLoad.Value = 100;

            if (MessageBox.Show("Are You Sure ?", "!! Exit !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
            {
                Application.Exit();
            }
            else
            {
                pbLoad.Style = ProgressBarStyle.Blocks;
                pbLoad.Value = 0;
            }
        }

        public void Connect()
        {
            // If Serial Port is connecting Function Analize's Run 
            if (serialPort.IsOpen)
            {
                Analize();
            }

        }
        //Connect Button
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {

                pbLoad.Value = 25;
                serialPort.Open(); // Connecting To Device
                Connect();
                
                pbLoad.Value = 50;
                ChangeLocation();
                pbLoad.Value = 75;
                statusStrip.Visible = true;
                lblCondition.Text = "Connect";
                lblCondition.ForeColor = Color.Green;
                pbLoad.Value = 100;
                statusInfoValue.Visible = true;
                chartControl.Visible = true;
                txtData.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("There is a problem connecting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pbLoad.Value = 0;
        }

        //AnaliziData
        public string AllData { get; set; }
        List<string> DataFile = new List<string>();
        List<Sensors> setdata = new List<Sensors>();
        public void Analize()
        {
            using (GiveData givedata = new GiveData())
            {
                try
                {
                    // Get Data as Serial_Port AND Set Value Property
                    AllData = serialPort.ReadLine() + Environment.NewLine;
                    DataFile.Add(AllData);

                    GetTimeNow Time = new GetTimeNow();
                    
                    // Object Split Data
                    SetTextValue set = new SetTextValue(AllData);
                    var result = givedata.SplitData(AllData);
                    SetLblText lbl = new SetLblText(result);
                    sensors[0].Value = Convert.ToDouble(result.Item1);
                    
                    sensors[1].Value = Convert.ToDouble(result.Item2);
                    
                    sensors[2].Value = Convert.ToInt16(result.Item3);

                    frmSet fms = new frmSet();
                    fms.UpdateSensour();

                    // Check Range Value Sensor
                    CheckRange check = new CheckRange(sensors);
                    //Clear Data List For Prevent sending old data
                    Sensors Data = new Sensors { temperature = sensors[0].Value , humidity = sensors[1].Value, Wetness = sensors[2].Value, DataTime = Time.Shamsi() };
                    InsertDataToDb DataBase = new InsertDataToDb(Data);
                    setdata.Clear();
                    setdata.Add(Data);
                    // Charts
                    SetValueChart chart = new SetValueChart(setdata);
                    fms.Dispose();
                    
                }

                catch (Exception ex)
                {
                    string str = ex.Message;
                    // Braeke
                    DisConnect();
                    MessageBox.Show("Eror Inilize Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        // Set Button
        private void btnSet_Click(object sender, EventArgs e)
        {
            new frmSet().ShowDialog();
        }
        public List<Sensor> sensors = new List<Sensor>();
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set Time 
            DateTime dt = DateTime.Now;
            PersianCalendar PC = new PersianCalendar();
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = PC.GetYear(dt) + "/" + PC.GetMonth(dt) + "/" + PC.GetDayOfMonth(dt);
            sensors.Add(new Sensor { Name = "Temprture" });
            sensors.Add(new Sensor { Name = "Humidity" });
            sensors.Add(new Sensor { Name = "Wetnesss" });

        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            Connect();
        }

        // Disconnect
        public void DisConnect()
        {
            serialPort.Close();
            pbLoad.Value = 25;

            chartControl.Visible = false;
            txtData.Visible = false;
            statusInfoValue.Visible = false;

            pbLoad.Value = 50;
            pbLoad.Value = 75;
            lblCondition.Text = "Disconnect";
            lblCondition.ForeColor = Color.Red;
            pbLoad.Value = 100;
            pbLoad.Value = 0;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            DisConnect();
        }

        private void btnExportData_Click(object sender, EventArgs e)
        {
            new frmVeiwData().ShowDialog();
        }
    }
}
