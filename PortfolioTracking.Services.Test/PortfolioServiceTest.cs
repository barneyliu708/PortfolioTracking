using Moq;
using NUnit.Framework;
using PortfolioTracking.BusinessObjects;
using PortfolioTracking.Infrastructure.DataAccess.Database;
using PortfolioTracking.Infrastructure.DataAccess.Database.Models;
using PortfolioTracking.Infrastructure.DataAccess.LiveStockPrice;
using PortfolioTracking.Infrastructure.DataAccess.LiveStockPrice.Dto;
using System;
using System.Collections.Generic;

namespace PortfolioTracking.Services.Test
{
    [TestFixture]
    public class PortfolioServiceTest
    {
        Mock<PortfolioDbContext> _dbcontext;
        Mock<ILiveDataRepository> _liveDataRepo;

        PortfolioService portfolioService;

        [SetUp]
        public void Init()
        {
            _dbcontext = new Mock<PortfolioDbContext>();
            _liveDataRepo = new Mock<ILiveDataRepository>();

            portfolioService = new PortfolioService(_dbcontext.Object, _liveDataRepo.Object);
        }

        [Test]
        public void TestCalculatePortfolioCost()
        {
            {
                // -- case 1: mutiple buy trade records
                List<TradeHistory> histories = new List<TradeHistory>()
                {
                    new TradeHistory { Ticker = "MSFT", TradeAction = TradeAction.Buy, Price = 85.95m, Quantity = 100},
                    new TradeHistory { Ticker = "MSFT", TradeAction = TradeAction.Buy, Price = 87.82m, Quantity = 150}
                };
                var result = portfolioService.CalculatePortfolioCost(histories);

                Assert.AreEqual(21768m, result);
            }
            Init();
            {
                // -- case 2: mutiple buy and sell trade records
                List<TradeHistory> histories = new List<TradeHistory>()
                {
                    new TradeHistory { Ticker = "MSFT", TradeAction = TradeAction.Buy, Price = 85.95m, Quantity = 100},
                    new TradeHistory { Ticker = "MSFT", TradeAction = TradeAction.Buy, Price = 87.82m, Quantity = 150},
                    new TradeHistory { Ticker = "MSFT", TradeAction = TradeAction.Sell, Price = 100.00m, Quantity = 100}
                };
                var result = portfolioService.CalculatePortfolioCost(histories);

                Assert.AreEqual(11768m, result);
            }
            Init();
            {
                // -- case 3: mutiple buy and sell trade records for mutiple tickers
                List<TradeHistory> histories = new List<TradeHistory>()
                {
                    new TradeHistory { Ticker = "MSFT", TradeAction = TradeAction.Buy, Price = 85.95m, Quantity = 100},
                    new TradeHistory { Ticker = "MSFT", TradeAction = TradeAction.Buy, Price = 87.82m, Quantity = 150},
                    new TradeHistory { Ticker = "GOOG", TradeAction = TradeAction.Buy, Price = 1065.00m, Quantity = 50},
                };
                var result = portfolioService.CalculatePortfolioCost(histories);

                Assert.AreEqual(75018m, result, "Should return total cost for all records");
            }
        }

        [Test]
        public void TestCalculatePortfolioQuantity()
        {
            {
                // -- case 1: mutiple buy trade records
                List<TradeHistory> histories = new List<TradeHistory>()
                {
                    new TradeHistory { Ticker = "MSFT", TradeAction = TradeAction.Buy, Price = 85.95m, Quantity = 100},
                    new TradeHistory { Ticker = "MSFT", TradeAction = TradeAction.Buy, Price = 87.82m, Quantity = 150}
                };
                var result = portfolioService.CalculatePortfolioQuantity(histories);

                Assert.AreEqual(250, result);
            }
            Init();
            {
                // -- case 2: mutiple buy and sell trade records
                List<TradeHistory> histories = new List<TradeHistory>()
                {
                    new TradeHistory { Ticker = "MSFT", TradeAction = TradeAction.Buy, Price = 85.95m, Quantity = 100},
                    new TradeHistory { Ticker = "MSFT", TradeAction = TradeAction.Buy, Price = 87.82m, Quantity = 150},
                    new TradeHistory { Ticker = "MSFT", TradeAction = TradeAction.Sell, Price = 100.00m, Quantity = 100}
                };
                var result = portfolioService.CalculatePortfolioQuantity(histories);

                Assert.AreEqual(150, result);
            }
            Init();
            {
                // -- case 3: mutiple buy and sell trade records for mutiple tickers
                List<TradeHistory> histories = new List<TradeHistory>()
                {
                    new TradeHistory { Ticker = "MSFT", TradeAction = TradeAction.Buy, Price = 85.95m, Quantity = 100},
                    new TradeHistory { Ticker = "MSFT", TradeAction = TradeAction.Buy, Price = 87.82m, Quantity = 150},
                    new TradeHistory { Ticker = "GOOG", TradeAction = TradeAction.Buy, Price = 1065.00m, Quantity = 50},
                };
                var result = portfolioService.CalculatePortfolioQuantity(histories);

                Assert.AreEqual(300, result, "Should return total quantity for all records");
            }
        }

        [Test]
        public void TestGroupProfitByTicker()
        {
            {
                // -- case 1: mutiple buy and sell trade records for mutiple tickers
                List<TradeHistory> histories = new List<TradeHistory>()
                {
                    new TradeHistory { Ticker = "MSFT", TradeAction = TradeAction.Buy, Price = 85.95m, Quantity = 100},
                    new TradeHistory { Ticker = "MSFT", TradeAction = TradeAction.Buy, Price = 87.82m, Quantity = 150},
                    new TradeHistory { Ticker = "GOOG", TradeAction = TradeAction.Buy, Price = 1065.00m, Quantity = 50},
                };
                _liveDataRepo.Setup(repo => repo.GetLastStockPrice("MSFT")).Returns(new StockPriceDto() { LatestPrice = new GlobalQuoteDto() { ClosePrice = 92.64m, PrePrice =  90.77m, } });
                _liveDataRepo.Setup(repo => repo.GetLastStockPrice("GOOG")).Returns(new StockPriceDto() { LatestPrice = new GlobalQuoteDto() { ClosePrice = 1024.61m, PrePrice = 1015.45m, } });

                List<ProfitReport> result = portfolioService.GroupProfitByTicker(histories);

                Assert.AreEqual(2, result.Count, "There should be two group based on tickers");
                Assert.AreEqual("GOOG", result[0].Ticker, "GOOG should be the first as results are ordered by the name");
                Assert.AreEqual(50, result[0].Quantity);
                Assert.AreEqual(53250, result[0].Cost);
                Assert.AreEqual(DateTime.Today, result[0].AsOfDate);
                Assert.AreEqual(51230.50m, result[0].MarketValue);
                Assert.AreEqual(458m, result[0].DailyProfit);
                Assert.AreEqual(-2019.5m, result[0].InceptionProfit);

                Assert.AreEqual("MSFT", result[1].Ticker);
                Assert.AreEqual(250, result[1].Quantity);
                Assert.AreEqual(21768, result[1].Cost);
                Assert.AreEqual(DateTime.Today, result[1].AsOfDate);
                Assert.AreEqual(23160m, result[1].MarketValue);
                Assert.AreEqual(467.5m, result[1].DailyProfit);
                Assert.AreEqual(1392m, result[1].InceptionProfit);
            }
            Init();
            {
                // -- negetive test: failed to get live date for MSFT
                List<TradeHistory> histories = new List<TradeHistory>()
                {
                    new TradeHistory { Ticker = "MSFT", TradeAction = TradeAction.Buy, Price = 85.95m, Quantity = 100},
                    new TradeHistory { Ticker = "MSFT", TradeAction = TradeAction.Buy, Price = 87.82m, Quantity = 150},
                    new TradeHistory { Ticker = "GOOG", TradeAction = TradeAction.Buy, Price = 1065.00m, Quantity = 50},
                };
                _liveDataRepo.Setup(repo => repo.GetLastStockPrice("MSFT")).Returns(new StockPriceDto());
                _liveDataRepo.Setup(repo => repo.GetLastStockPrice("GOOG")).Returns(new StockPriceDto() { LatestPrice = new GlobalQuoteDto() { ClosePrice = 1024.61m, PrePrice = 1015.45m, } });

                List<ProfitReport> result = portfolioService.GroupProfitByTicker(histories);

                Assert.AreEqual(2, result.Count, "There should be two group based on tickers");
                Assert.AreEqual("GOOG", result[0].Ticker);
                Assert.AreEqual(50, result[0].Quantity);
                Assert.AreEqual(53250, result[0].Cost);
                Assert.AreEqual(DateTime.Today, result[0].AsOfDate);
                Assert.AreEqual(51230.50m, result[0].MarketValue);
                Assert.AreEqual(458m, result[0].DailyProfit);
                Assert.AreEqual(-2019.5m, result[0].InceptionProfit);

                Assert.AreEqual("MSFT", result[1].Ticker);
                Assert.AreEqual(250, result[1].Quantity);
                Assert.AreEqual(21768, result[1].Cost);
                Assert.AreEqual(DateTime.Today, result[1].AsOfDate);
                Assert.AreEqual(0m, result[1].MarketValue, "should return 0 as latest price is unavailable");
                Assert.AreEqual(0m, result[1].DailyProfit, "should return 0 as latest price is unavailable");
                Assert.AreEqual(0m, result[1].InceptionProfit, "should return 0 as latest price is unavailable");
            }
        }
    }
}
