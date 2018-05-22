using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCGarage2.Models
{
    public class VehicleReceipt
    {
        public VehicleReceipt(int id, string regnr, DateTime parkedTime, DateTime nowTime)
        {
            Id = id;
            Regnr = regnr;
            ParkedTime = parkedTime;
            NowTime = nowTime;
            TimeSpan ts = NowTime - ParkedTime;
            TotalTime = $"{Math.Floor(ts.TotalDays)} days, {ts.Hours} hours and {ts.Minutes} minutes.";
            Price = $"{((ts.TotalMinutes + 1) * 5):C2} kr";
        }

        public int Id { get; set; }
        public string Regnr { get; set; }
        public DateTime ParkedTime { get; set; }
        public DateTime NowTime { get; set; }
        public string TotalTime { get; set; }
        public string Price { get; set; }
    }
}