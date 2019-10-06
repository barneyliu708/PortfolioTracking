using PortfolioTracking.BusinessObjects;
using PortfolioTracking.Infrastructure.DataAccess.Database;
using PortfolioTracking.Infrastructure.DataAccess.LiveStockPrice;
using PortfolioTracking.Services;
using PortfolioTracking.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PortfolioTracking.Presentation.Views
{
    public partial class MainView : Form, IMainView
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

        public event EventHandler OnPortfolioSelected;

        private void MainView_Load(object sender, EventArgs e)
        {

        }

        public string UserDisplayName
        {
            get { return UserDisplayNameLable.Text; }
            set { UserDisplayNameLable.Text = value; }
        }

        public void LoadPortfolioList(List<PortfolioReport> portfolios)
        {
            PortfolioListBox.DataSource = portfolios;
            PortfolioListBox.DisplayMember = "PortfolioName";
            PortfolioListBox.ValueMember = "PortfolioID";
        }

        public PortfolioReport SeletedPortfolio
        {
            get { return (PortfolioReport)PortfolioListBox.SelectedItem; }
            set { PortfolioListBox.SelectedItem = value; }
        }

        public string SelectedPortfolioName
        {
            get { return SelectedPortfolioNameLable.Text; }
            set { SelectedPortfolioNameLable.Text = value; }
        }

        public DateTime SelectedPortfolioWhenCreated
        {
            get { return DateTime.Parse(SelectedPortfolioWhenCreatedLable.Text); }
            set { SelectedPortfolioWhenCreatedLable.Text = value.ToString("dddd, dd MMMM yyyy"); }
        }

        public void LoadSelectedPortfolioProfits(List<ProfitReport> profits)
        {
            PortfolioProfitGridView.DataSource = profits;
        }

        public void LoadSelectedPortfolioTradeHistories(List<PortfolioTradeHistory> tradeHistories)
        {
            PortfolioTradeHistoryGridView.DataSource = tradeHistories;
        }

        private void PortfolioListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (SeletedPortfolio != null)
            {
                OnPortfolioSelected(sender, e);
            }
        }
    }
}
