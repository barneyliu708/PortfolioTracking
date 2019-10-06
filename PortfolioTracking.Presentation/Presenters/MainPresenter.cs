﻿using log4net;
using PortfolioTracking.BusinessObjects;
using PortfolioTracking.Presentation.Views;
using PortfolioTracking.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace PortfolioTracking.Presentation.Presenters
{
    public class MainPresenter
    {
        private static readonly ILog _logger = LogManager.GetLogger(typeof(MainPresenter));

        private IMainView _mainView;
        private IUserService _userService;
        private IPortfolioService _portfolioService;

        public MainPresenter(IMainView mainView, IUserService userService, IPortfolioService portfolioService)
        {
            this._mainView = mainView;
            this._userService = userService;
            this._portfolioService = portfolioService;

            this._mainView.OnPortfolioSelected += OnPortfolioSelected;

            LoadUserProfile();

            _logger.Info($"Main page load successfully");
        }

        public void LoadUserProfile()
        {
            UserDetails userProfile = _userService.GetUserDetailsByUserName("nliu");
            List<PortfolioReport> portfolios = _portfolioService.GetPortfolioListByUserName(userProfile.UserName);

            _mainView.UserDisplayName = userProfile.DisplayName;
            _mainView.LoadPortfolioList(portfolios);
        }

        public void OnPortfolioSelected(object sender, EventArgs e)
        {
            PortfolioReport portfolioReport = _portfolioService.GetPortfolioReportByPortfolioID(_mainView.SeletedPortfolio.PortfolioID);
            List<PortfolioTradeHistory> tradeHistories = _portfolioService.GetTradeHistoriesByPortfolioID(_mainView.SeletedPortfolio.PortfolioID);

            _mainView.SelectedPortfolioName = portfolioReport.PortfolioName;
            _mainView.SelectedPortfolioWhenCreated = portfolioReport.WhenCreated;
            _mainView.LoadSelectedPortfolioProfits(portfolioReport.ProfitReports);
            _mainView.LoadSelectedPortfolioTradeHistories(tradeHistories);
        }
    }
}
