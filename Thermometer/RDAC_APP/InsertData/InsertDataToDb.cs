using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Models;
using DataLayer.Time;

namespace Thermometer_APP.InsertData
{
    
    public class InsertDataToDb
    {
        GetTimeNow dt;
        public string Time { get; set; }
        public InsertDataToDb(Sensors data)
        {
            GetTime();
            
            DbContext db = new DbContext();
         
            db.insertData(data);
            db.Dispose();
            dt.Dispose();
        }
        public void GetTime()
        {
            dt = new GetTimeNow();
            Time = dt.GetTime();
        }
        ~InsertDataToDb()
        {
                
        }
    }

}
