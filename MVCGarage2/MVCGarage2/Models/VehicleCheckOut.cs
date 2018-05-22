using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCGarage2.Models
{
    public class VehicleCheckOut
    {
        public VehicleCheckOut(int id, string regnr, DateTime parkedTime, DateTime nowTime)
        {
            Id = id;
            Regnr = regnr;
            ParkedTime = parkedTime;
            NowTime = nowTime;
        }

        public int Id { get; set; }
        public string Regnr { get; set; }
        public DateTime ParkedTime { get; set; }
        public DateTime NowTime { get; set; }
    }
}