using System;
using System.Collections.Generic;

#nullable disable

namespace StockMonitoring.Models.dblocal
{
    public partial class StockListLog
    {
        public int Run { get; set; }
        public string SectionCode { get; set; }
        public DateTime Registdatetime { get; set; }
        public string PartNumber { get; set; }
        public int Balance { get; set; }
    }
}
