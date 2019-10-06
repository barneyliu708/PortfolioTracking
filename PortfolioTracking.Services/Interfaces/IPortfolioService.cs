using System.Collections.Generic;
using PortfolioTracking.BusinessObjects;
using PortfolioTracking.Infrastructure.DataAccess.Database.Models;

namespace PortfolioTracking.Services.Interfaces
{
    public interface IPortfolioService
    {
        decimal CalculatePortfolioCost(List<TradeHistory> histories);
        long CalculatePortfolioQuantity(List<TradeHistory> histories);
        List<PortfolioReport> GetPortfolioListByUserName(string userName);
        PortfolioReport GetPortfolioReportByPortfolioID(long portfolioID);
        List<PortfolioTradeHistory> GetTradeHistoriesByPortfolioID(long portfolioID);
        List<ProfitReport> GroupProfitByTicker(List<TradeHistory> histories);
    }
}