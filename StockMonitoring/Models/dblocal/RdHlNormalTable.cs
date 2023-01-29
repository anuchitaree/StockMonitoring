using System;
using System.Collections.Generic;

#nullable disable

namespace StockMonitoring.Models.dblocal
{
    public partial class RdHlNormalTable
    {
        public int Run { get; set; }
        public string SectionCode { get; set; }
        public DateTime RegistDate { get; set; }
        public DateTime CurrentDateTime { get; set; }
        public string DayNight { get; set; }
        public string MachineId { get; set; }
        public string SerialPartNumber { get; set; }
        public short Chamber { get; set; }
        public double LeakRate { get; set; }
        public short? Ngmode { get; set; }
        public string Okngpiece { get; set; }
        public double? LoadTime { get; set; }
        public double? FinishTime { get; set; }
        public string Warning { get; set; }
        public string Ack { get; set; }
    }
}
