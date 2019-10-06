using System;

namespace PortfolioTracking.BusinessObjects
{
    public class ProfitReport
    {
        public string Ticker { get; set; }
        public DateTime AsOfDate { get; set; }
        public decimal Cost { get; set; }
        public long Quantity { get; set; }
        public decimal CurPrice { get; set; }
        public decimal PrePrice { get; set; }
        public decimal MarketValue { get; set; }
        public decimal DailyProfit { get; set; }
        public decimal InceptionProfit { get; set; }
    }
}
