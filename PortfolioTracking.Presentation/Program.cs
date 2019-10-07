using Autofac;
using PortfolioTracking.Infrastructure.DataAccess.Database;
using PortfolioTracking.Infrastructure.DataAccess.LiveStockPrice;
using PortfolioTracking.Presentation.Presenters;
using PortfolioTracking.Presentation.Views;
using PortfolioTracking.Services;
using PortfolioTracking.Services.Interfaces;
using System;
using System.Data.Entity;
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
            // -- config logger
            log4net.Config.XmlConfigurator.Configure();

            // -- config container
            var builder = new ContainerBuilder();
            // -- repositoy
            builder.RegisterType<PortfolioDbContext>().As<DbContext>();
            builder.RegisterType<LiveDataRepository>().As<ILiveDataRepository>();
            // -- service
            builder.RegisterType<PortfolioService>().As<IPortfolioService>();
            builder.RegisterType<UserService>().As<IUserService>();
            // -- presentation
            builder.RegisterType<MainView>().As<IMainView>();
            builder.RegisterType<MainPresenter>().As<IMainPresenter>();
            var container = builder.Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IMainPresenter mainPresenter = container.Resolve<IMainPresenter>();
            IMainView mainView = mainPresenter.GetMainView();
            Application.Run((MainView)mainView);
        }
    }
}
