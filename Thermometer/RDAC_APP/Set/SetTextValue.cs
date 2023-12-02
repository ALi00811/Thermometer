using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thermometer_APP.Set
{
    class SetTextValue
    {
        public SetTextValue(string Data)
        {
            Form1 FormMain = Application.OpenForms.Cast<Form1>().FirstOrDefault();
            FormMain.txtData.Text = Data;
        }
        ~SetTextValue()
        {
                
        }
    }
}
