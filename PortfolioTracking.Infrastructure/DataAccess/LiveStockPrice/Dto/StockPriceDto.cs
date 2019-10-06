using Newtonsoft.Json;

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
    }
}
