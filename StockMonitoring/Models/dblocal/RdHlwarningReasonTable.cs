using System;
using System.Collections.Generic;

#nullable disable

namespace StockMonitoring.Models.dblocal
{
    public partial class RdHlwarningReasonTable
    {
        public int? RdHlrun { get; set; }
        public string WarningType { get; set; }
        public int? WhoAck { get; set; }
        public DateTime? RecordDateTime { get; set; }
        public string Analysis { get; set; }
    }
}
