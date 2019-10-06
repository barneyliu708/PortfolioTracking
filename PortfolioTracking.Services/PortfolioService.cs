using PortfolioTracking.BusinessObjects;
using PortfolioTracking.Infrastructure.DataAccess.Database;
using PortfolioTracking.Infrastructure.DataAccess.Database.Models;
using PortfolioTracking.Infrastructure.DataAccess.LiveStockPrice;
using PortfolioTracking.Infrastructure.DataAccess.LiveStockPrice.Dto;
using PortfolioTracking.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PortfolioTracking.Services
{
    public class PortfolioService : IPortfolioService
    {
        private DbRepository _dbRepo;
        private ILiveDataRepository _liveDateRepo;

        public PortfolioService(DbContext dbcontext, ILiveDataRepository liveDateRepo)
        {
            _dbRepo = new DbRepository(dbcontext);
            _liveDateRepo = liveDateRepo;
        }

        public PortfolioReport GetPortfolioReportByPortfolioID(long portfolioID)
        {
            PortfolioReport reportResult = new PortfolioReport();

            Portfolio portfolio = _dbRepo.Get<Portfolio>()
                                         .Include(p => p.TradeHistories)
                                         .FirstOrDefault(p => p.PortfolioID == portfolioID);
            if (portfolio != null)
            {
                reportResult.PortfolioID = portfolio.PortfolioID;
                reportResult.PortfolioName = portfolio.PortfolioName;
                reportResult.AsOfDate = DateTime.Today;
                reportResult.ProfitReports = GroupProfitByTicker(portfolio.TradeHistories.ToList());
            }
            return reportResult;
        }

        public decimal CalculatePortfolioCost(List<TradeHistory> histories)
        {
            return histories.Sum(h => h.TradeAction == TradeAction.Buy ? h.Price * h.Quantity : -1 * h.Price * h.Quantity);
        }

        public long CalculatePortfolioQuantity(List<TradeHistory> histories)
        {
            return histories.Sum(h => h.TradeAction == TradeAction.Buy ? h.Quantity : -1 * h.Quantity);
        }

        public List<ProfitReport> GroupProfitByTicker(List<TradeHistory> histories)
        {
            return histories.GroupBy
                             (
                                 history => history.Ticker,
                                 history => history,
                                 (key, group) =>
                                 {
                                     StockPriceDto price = _liveDateRepo.GetLastStockPrice(key);
                                     ProfitReport profit = new ProfitReport
                                     {
                                         Ticker = key,
                                         AsOfDate = DateTime.Today,
                                         Cost = CalculatePortfolioCost(group.ToList()),
                                         Quantity = CalculatePortfolioQuantity(group.ToList()),
                                         CurPrice = price.LatestPrice.ClosePrice,
                                         PrePrice = price.LatestPrice.PrePrice
                                     };
                                     profit.MarketValue = profit.CurPrice * profit.Quantity;
                                     profit.DailyProfit = (profit.CurPrice - profit.PrePrice) * profit.Quantity;
                                     profit.InceptionProfit = profit.MarketValue != 0 ? profit.MarketValue - profit.Cost : 0;

                                     return profit;
                                 }

                             )
                             .OrderBy(p => p.Ticker)
                             .ToList();
        }
    }
}
