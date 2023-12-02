using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thermometer_APP.Set
{
    public class SetLblText
    {
        Form1 openForms = Application.OpenForms.Cast<Form1>().FirstOrDefault();

        public SetLblText(Tuple<string,string,string> data)
        {
            openForms.lblHumidity.Text = data.Item2;
            openForms.lblTemprature.Text = data.Item1;
            openForms.lblWetness.Text = data.Item3;
        }

        ~SetLblText()
        {
             
        }
     
    }
}
