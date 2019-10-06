using PortfolioTracking.BusinessObjects;
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
        }

        public event EventHandler OnPortfolioSelected;

        private void MainView_Load(object sender, EventArgs e)
        {

        }
        private void PortfolioListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (SeletedPortfolio != null)
            {
                OnPortfolioSelected(sender, e);
            }
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
    }
}
