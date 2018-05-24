using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace MVCGarage2.Models
{
    public class VehicleReceipt
    {
        public VehicleReceipt(int id, string regnr, string type, DateTime parkedTime, DateTime nowTime)
        {
            Id = id;
            Regnr = regnr;
            Type = type;
            ParkedTime = parkedTime;
            NowTime = nowTime;
            TimeSpan ts = NowTime - ParkedTime;
            TotalTime = $"{Math.Floor(ts.TotalDays)} days, {ts.Hours} hours and {ts.Minutes} minutes.";

            var cultureInfo = CultureInfo.GetCultureInfo("sv-SE");
            Price = String.Format(cultureInfo, "{0:C}", $"{((ts.TotalMinutes + 1) * 5)}");
        }

        public int Id { get; set; }
        public string Regnr { get; set; }
        public string Type { get; set; }
        public DateTime ParkedTime { get; set; }
        public DateTime NowTime { get; set; }
        public string TotalTime { get; set; }
        public string Price { get; set; }
    }
}

