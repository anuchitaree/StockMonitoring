using System;
using System.Collections.Generic;

#nullable disable

namespace StockMonitoring.Models.dblocal
{
    public partial class RdHlCalibration
    {
        public int Run { get; set; }
        public string SectionCode { get; set; }
        public DateTime RegistDate { get; set; }
        public DateTime CurrentDateTime { get; set; }
        public string DayNight { get; set; }
        public string MachineId { get; set; }
        public short Chamber { get; set; }
        public double FirstBg { get; set; }
        public double SecondBg { get; set; }
        public double FirstSg { get; set; }
        public double SecondSg { get; set; }
        public double JudgeSn { get; set; }
        public double SafetyFactor { get; set; }
        public double NgsetPoint { get; set; }
        public int? AckPerson { get; set; }
        public DateTime? AckDateTime { get; set; }
    }
}
