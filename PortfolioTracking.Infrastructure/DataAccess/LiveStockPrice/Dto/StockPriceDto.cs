using Newtonsoft.Json;
using System;

namespace PortfolioTracking.Infrastructure.DataAccess.LiveStockPrice.Dto
{
    public class StockPriceDto
    {
        public StockPriceDto()
        {
            LatestPrice = new GlobalQuoteDto();
        }

        [JsonProperty("Global Quote")]
        public GlobalQuoteDto LatestPrice { get; set; }

        public DateTime QuateTime { get; set; }
    }
}
