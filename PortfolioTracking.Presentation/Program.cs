using PortfolioTracking.Infrastructure.DataAccess.Database;
using PortfolioTracking.Infrastructure.DataAccess.LiveStockPrice;
using PortfolioTracking.Presentation.Presenters;
using PortfolioTracking.Presentation.Views;
using PortfolioTracking.Services;
using System;
using System.Windows.Forms;

namespace PortfolioTracking.Presentation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            log4net.Config.XmlConfigurator.Configure();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainView = new MainView();
            var dbcontext = new PortfolioDbContext();
            var liveDataRepo = new LiveDataRepository();
            var mianPresenter = new MainPresenter(mainView, new UserService(dbcontext), new PortfolioService(dbcontext, liveDataRepo));
            Application.Run(mainView);
        }
    }
}
