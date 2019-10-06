using System;
using System.Collections.Generic;
using PortfolioTracking.BusinessObjects;

namespace PortfolioTracking.Presentation.Views
{
    public interface IMainView
    {
        string SelectedPortfolioName { get; set; }
        DateTime SelectedPortfolioWhenCreated { get; set; }
        PortfolioReport SeletedPortfolio { get; set; }
        string UserDisplayName { get; set; }

        event EventHandler OnPortfolioSelected;

        void LoadPortfolioList(List<PortfolioReport> portfolios);
        void LoadSelectedPortfolioProfits(List<ProfitReport> profits);
        void LoadSelectedPortfolioTradeHistories(List<PortfolioTradeHistory> tradeHistories);
    }
}