using Newtonsoft.Json;

namespace PortfolioTracking.Infrastructure.DataAccess.LiveStockPrice.Dto
{
    public class GlobalQuoteDto
    {
        [JsonProperty("01. symbol")]
        public string Symbol { get; set; }

        [JsonProperty("05. price")]
        public decimal ClosePrice { get; set; }

        [JsonProperty("07. latest trading day")]
        public string TradeDate { get; set; }

        [JsonProperty("08. previous close")]
        public decimal PrePrice { get; set; }
    }
}
