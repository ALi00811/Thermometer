using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SQLite;



namespace DataLayer.Models
{
    public class Sensors
    {
        public double temperature { get; set; }
        public double humidity { get; set; }
        public double Wetness { get; set; }
        public string DataTime { get; set; }
        
    }
}
