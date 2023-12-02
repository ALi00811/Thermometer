using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thermometer_APP.Model;

namespace Thermometer_APP.CheckRangeSensor
{
    public class CheckRange
    {
        Form1 form = Application.OpenForms.Cast<Form1>().FirstOrDefault();

        public CheckRange(List<Sensor> data)
        {

            foreach (var item in data)
            {
                if (item.Value > item.Max)
                {
                    string error = $"Sensor {item.Name} Value Higher Of Range";
                    SetError(item.Name,error);
                }
                if (item.Value < item.Min)
                {
                    string error = $"Sensor {item.Name} Value Fewer Of Range";
                    SetError(item.Name, error);
                }
                else if (item.Value < item.Max && item.Value > item.Min)
                {
                    form.epHumidity.Clear();
                    form.epTemprature.Clear();
                    form.epWetness.Clear();

                }
                


            }
        }

        private void SetError(string name,string message)
        {

            if (name == "Humidity")
            {
                form.epHumidity.SetError(form.chartControl, message);
            }
            else if (name == "Temprture")
            {
                form.epTemprature.SetError(form.chartControl, message);
            }
            else if (name == "Wetness")
            {
                form.epWetness.SetError(form.chartControl, message);
            }

        }
        ~CheckRange()
        {
                
        }
    }


}
