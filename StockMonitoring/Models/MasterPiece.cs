using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StockMonitoring.Models
{
    public class MasterPiece
    {
        [Key]
        public string PartNumberId { get; set; }
        public int PiecePerKanban { get; set; }
    }
}
