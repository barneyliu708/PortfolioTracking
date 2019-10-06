using log4net;
using Newtonsoft.Json;
using PortfolioTracking.Infrastructure.DataAccess.LiveStockPrice.Dto;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;

namespace PortfolioTracking.Infrastructure.DataAccess.LiveStockPrice
{
    public class LiveDataRepository : ILiveDataRepository
    {
        private static readonly ILog _logger = LogManager.GetLogger(typeof(LiveDataRepository));

        private string ALPHA_VANTAGE_BASE_URL = "https://www.alphavantage.co/query";
        private string GET_LATEST_PRICE_BY_TICKER = "?function=GLOBAL_QUOTE&symbol={0}&apikey=2UE2F3PIEK3EAKYP";

        private Dictionary<string, StockPriceDto> priceCache = new Dictionary<string, StockPriceDto>();

        public StockPriceDto GetLastStockPrice(string ticker)
        {
            try
            {
                // -- check if we quote the same ticker price in past 30 seconds
                if (priceCache.ContainsKey(ticker) && DateTime.Now < priceCache[ticker].QuateTime.AddSeconds(30) && priceCache[ticker].LatestPrice.ClosePrice != 0)
                {
                    _logger.Info($"price is found in the cache: {JsonConvert.SerializeObject(priceCache[ticker])}");
                    return priceCache[ticker];
                }

                string url = new Uri(ALPHA_VANTAGE_BASE_URL + string.Format(GET_LATEST_PRICE_BY_TICKER, ticker)).AbsoluteUri;
                using (HttpClient http = new HttpClient())
                {
                    HttpResponseMessage response = http.GetAsync(url).Result;
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        string jsonStr = response.Content.ReadAsStringAsync().Result;
                        StockPriceDto price = JsonConvert.DeserializeObject<StockPriceDto>(jsonStr);
                        _logger.Info($"Get response from [{url}]: status code {response.StatusCode} with result: {JsonConvert.SerializeObject(price)}");

                        // -- refresh cache
                        price.QuateTime = DateTime.Now;
                        if (priceCache.ContainsKey(ticker))
                        {
                            priceCache[ticker] = price;
                        }
                        else
                        {
                            priceCache.Add(ticker, price);
                        }
                        
                        return price;
                    }
                    _logger.Warn($"Get response from [{url}]: status code {response.StatusCode}");
                }
            }
            catch(Exception ex)
            {
                _logger.Error(ex);
            }
            return new StockPriceDto();
        }
    }
}
