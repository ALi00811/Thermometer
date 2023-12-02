using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class SetValueSensors
    {
        public Decimal MaxTemperature { get; set; }
        public Decimal MinTemperature { get; set; }
        public Decimal MaxHumidity { get; set; }
        public Decimal MinHumidity { get; set; }
        public Decimal MaxWetness { get; set; }
        public Decimal MinWetness { get; set; }
    }
}
