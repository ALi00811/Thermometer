using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thermometer_APP.Analyzer
{
    public class GiveData : IDisposable
    {


        public Tuple<string, string, string> SplitData(string data)
        {
            string Tempreture;
            string Humidity;
            string Wetness;

            if (data == "")
            {
                //IF Data == Null => Return Null
                return new Tuple<string, string, string>(null, null, null);
            }
            else
            {
                //Recive Data AND Split
                string datas = data;
                var buffer = data.Split('%');
                // Set Value Tempreture
                Tempreture = buffer[2];
                Tempreture = Tempreture.Replace("T-", "");
                Tempreture = Tempreture.Replace("\r\r\n", "");
                // Set Value Humidity
                Humidity = buffer[1];
                Humidity = Humidity.Replace("H-", "");
                // Set Value Wetness
                Wetness = buffer[0];
                Wetness = Wetness.Replace("AV-", "");
                // Retuen Values
                return new Tuple<string, string, string>(Tempreture, Humidity, Wetness);

            }

        }

        public void Dispose()
        {
            
        }

        ~GiveData()
        {
            
        }
    }
}
