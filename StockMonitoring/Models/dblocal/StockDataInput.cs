using System;
using System.Collections.Generic;

#nullable disable

namespace StockMonitoring.Models.dblocal
{
    public partial class StockDataInput
    {
        public int Run { get; set; }
        public string SectionCode { get; set; }
        public DateTime RegistDateTime { get; set; }
        public string PartNumber { get; set; }
        public int PiecePerKanban { get; set; }
        public int UserId { get; set; }
        public bool Status { get; set; }
    }
}
