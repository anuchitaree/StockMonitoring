using System;
using System.Collections.Generic;

#nullable disable

namespace StockMonitoring.Models.dblocal
{
    public partial class StockList
    {
        public string SectionCode { get; set; }
        public string PartNumber { get; set; }
        public int Balance { get; set; }
        public int PiecePerKanban { get; set; }
        public int Hhlimit { get; set; }
        public int Hlimit { get; set; }
        public int Llimit { get; set; }
        public int Lllimt { get; set; }
        public bool ActivePn { get; set; }
    }
}
