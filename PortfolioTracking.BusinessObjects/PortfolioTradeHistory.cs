using System;

namespace PortfolioTracking.BusinessObjects
{
    public class PortfolioTradeHistory
    {
        public string Ticker { get; set; }
        public DateTime TradeDate { get; set; }
        public string TradeAction { get; set; }
        public long Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
