using DataLayer.Context;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thermometer_APP
{
    public partial class frmSet : Form
    {
        public frmSet()
        {
            InitializeComponent();
            Load();
        }
        public void Load()
        {
            DbContext db = new DbContext();
            var data = db.GetAllDataValue();
            foreach (var item in data)
            {
                numMaxHumidity.Value = item.MaxHumidity;
                numMaxTemprature.Value = item.MaxTemperature;
                numMaxWetness.Value = item.MaxWetness;
                numMinHumidity.Value = item.MinHumidity;
                numMinTemprature.Value = item.MinHumidity;
                numMinWetness.Value = item.MinWetness;
            }
        }

        //Close Button
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateDatabase()
        {
            DbContext db = new DbContext();
            SetValueSensors dbset = new SetValueSensors { MaxHumidity = numMaxHumidity.Value, MaxTemperature = numMaxTemprature.Value, MaxWetness = numMaxWetness.Value, MinHumidity = numMinHumidity.Value, MinTemperature = numMinTemprature.Value, MinWetness = numMinWetness.Value };
            db.update(dbset);
            db.Dispose();


        }
        private void btnSetValue_Click(object sender, EventArgs e)
        {
            updateDatabase();
            UpdateSensour();
            Close();

        }
        Form1 openForms = Application.OpenForms.Cast<Form1>().FirstOrDefault();
        public void UpdateSensour()
        {
            openForms.sensors[0].Max = Convert.ToDouble(numMaxTemprature.Value);
            openForms.sensors[0].Min = Convert.ToDouble(numMinTemprature.Value);
            
            openForms.sensors[1].Max = Convert.ToDouble(numMaxHumidity.Value);
            openForms.sensors[1].Min = Convert.ToDouble(numMaxTemprature.Value);
            
            openForms.sensors[2].Max = Convert.ToDouble(numMaxWetness.Value);
            openForms.sensors[2].Min = Convert.ToDouble(numMinWetness.Value);


        }

        private void frmSet_Load(object sender, EventArgs e)
        {
            Load();
        }
    }
}
