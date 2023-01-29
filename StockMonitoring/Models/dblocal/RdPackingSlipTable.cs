using System;
using System.Collections.Generic;

#nullable disable

namespace StockMonitoring.Models.dblocal
{
    public partial class RdPackingSlipTable
    {
        public int Run { get; set; }
        public string SectionCode { get; set; }
        public DateTime RegistDate { get; set; }
        public DateTime CurrentDateTime { get; set; }
        public string DayNight { get; set; }
        public string MachineId { get; set; }
        public string PartNumber { get; set; }
        public double MaxLeftTop { get; set; }
        public double MinLeftTop { get; set; }
        public double MaxRightTop { get; set; }
        public double MinRightTop { get; set; }
        public double MaxLeftBottom { get; set; }
        public double MinLeftBottom { get; set; }
        public double MaxRightBottom { get; set; }
        public double MinRightBottom { get; set; }
        public string JudgeResult { get; set; }
        public short? ModeResult { get; set; }
        public int NumberDataTop { get; set; }
        public int NumberDataBottom { get; set; }
    }
}
