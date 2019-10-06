using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortfolioTracking.Infrastructure.DataAccess.Database.Models
{
    [Table("Portfolio")]
    public class Portfolio
    {
        public Portfolio()
        {
            TradeHistories = new HashSet<TradeHistory>();
        }

        [Key]
        public long PortfolioID { get; set; }
        [StringLength(150)]
        public string PortfolioName { get; set; }
        public DateTime WhenCreated { get; set; }

        public ICollection<TradeHistory> TradeHistories { get; set; }

        public UserProfile UserProfile { get; set; }
    }
}
