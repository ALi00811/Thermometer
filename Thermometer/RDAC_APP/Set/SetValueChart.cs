using DataLayer.Models;
using DevComponents.DotNetBar.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thermometer_APP.Model;

namespace Thermometer_APP.Set
{
    class SetValueChart
    {
        public SetValueChart(List<Sensors> Data)
        {
            Form1 openForms = Application.OpenForms.Cast<Form1>().FirstOrDefault();
            
            openForms.chartControl.Series[0].Points.AddXY(DateTime.Now.ToString("HH:mm"), Data[0].temperature);
            openForms.chartControl.Series[1].Points.AddXY(DateTime.Now.ToString("HH:mm"), Data[0].humidity);
            openForms.chartControl.Series[2].Points.AddXY(DateTime.Now.ToString("HH:mm"), Data[0].Wetness / 10);

        }
        ~SetValueChart()
        {
                
        }

    }
}
