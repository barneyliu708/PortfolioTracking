using Newtonsoft.Json;
using PortfolioTracking.Infrastructure.DataAccess.LiveStockPrice.Dto;
using System;
using System.Net;
using System.Net.Http;

namespace PortfolioTracking.Infrastructure.DataAccess.LiveStockPrice
{
    public class LiveDataRepository : ILiveDataRepository
    {
        private string ALPHA_VANTAGE_BASE_URL = "https://www.alphavantage.co/query";
        private string GET_LATEST_PRICE_BY_TICKER = "?function=GLOBAL_QUOTE&symbol={0}&apikey=2UE2F3PIEK3EAKYP";

        public StockPriceDto GetLastStockPrice(string ticker)
        {
            string url = new Uri(ALPHA_VANTAGE_BASE_URL + string.Format(GET_LATEST_PRICE_BY_TICKER, ticker)).AbsoluteUri;
            using (HttpClient http = new HttpClient())
            {
                HttpResponseMessage response = http.GetAsync(url).Result;
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string jsonStr = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<StockPriceDto>(jsonStr);
                }
            }
            return new StockPriceDto();
        }
    }
}
