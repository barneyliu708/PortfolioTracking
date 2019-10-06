using PortfolioTracking.BusinessObjects;
using PortfolioTracking.Presentation.Views;
using PortfolioTracking.Services;
using PortfolioTracking.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioTracking.Presentation.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private IUserService userService;
        private IPortfolioService portfolioService;

        public MainPresenter(IMainView mainView, IUserService userService, IPortfolioService portfolioService)
        {
            this.mainView = mainView;
            this.userService = userService;
            this.portfolioService = portfolioService;

            LoadUserProfile();
        }

        public void LoadUserProfile()
        {
            UserDetails userProfile = userService.GetUserDetailsByUserName("nliu");
            mainView.UserDisplayName = userProfile.DisplayName;
        }
    }
}
