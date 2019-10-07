using System;
using PortfolioTracking.Presentation.Views;

namespace PortfolioTracking.Presentation.Presenters
{
    public interface IMainPresenter
    {
        IMainView GetMainView();
        void LoadUserProfile();
        void OnPortfolioSelected(object sender, EventArgs e);
    }
}