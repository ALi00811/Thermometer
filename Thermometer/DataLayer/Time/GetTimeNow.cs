using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace DataLayer.Time
{
    public class GetTimeNow : IDisposable
    {

        PersianCalendar pc;
        public string GetTime()
        {
            pc = new PersianCalendar();
            return Shamsi();
            
        }
        public string Shamsi()
        {

            pc = new PersianCalendar();
            int day = pc.GetDayOfMonth(DateTime.Now);
            int month = pc.GetMonth(DateTime.Now);
            int year = pc.GetYear(DateTime.Now);
            int hour = pc.GetHour(DateTime.Now);
            int minute = pc.GetMinute(DateTime.Now);
            int second = pc.GetSecond(DateTime.Now);
            return $"{year}/{month}/{day}  {hour}:{minute}:{second}";

        }
        public void Dispose()
        {

        }
    }
}
