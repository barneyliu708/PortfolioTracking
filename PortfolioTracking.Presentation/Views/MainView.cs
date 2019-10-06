using PortfolioTracking.Infrastructure.DataAccess.Database;
using PortfolioTracking.Infrastructure.DataAccess.LiveStockPrice;
using PortfolioTracking.Services;
using PortfolioTracking.Services.Interfaces;
using System.Windows.Forms;

namespace PortfolioTracking.Presentation.Views
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            //using(PortfolioDbContext dbcontext = new PortfolioDbContext())
            //{
            //    LiveDataRepository liveDataRepo = new LiveDataRepository();
            //    IPortfolioService portfolioService = new PortfolioService(dbcontext, liveDataRepo);
            //    var test = portfolioService.GetPortfolioReportByPortfolioID(1);
            //}

        }
    }
}
