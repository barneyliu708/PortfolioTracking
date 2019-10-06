using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortfolioTracking.Infrastructure.DataAccess.Database.Models
{
    [Table("TradeHistory")]
    public class TradeHistory
    {
        [Key]
        public long TradeHistoryID { get; set; }
        [StringLength(50)]
        public string Ticker { get; set; }
        public DateTime TradeDate { get; set; }
        public TradeAction TradeAction { get; set; }
        public long Quantity { get; set; }
        public decimal Price { get; set; }

        public Portfolio Portfolio { get; set; }
    }
}
