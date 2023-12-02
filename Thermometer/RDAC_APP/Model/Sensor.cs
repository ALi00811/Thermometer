using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thermometer_APP.Model
{
    public class Sensor
    {
        public string Name { get; set; }
        public Double Value { get; set; } = 0;
        public Double Min { get; set; } = 0;
        public Double Max { get; set; } = 0;
        public bool OverRange { get; set; } 
    }
}
