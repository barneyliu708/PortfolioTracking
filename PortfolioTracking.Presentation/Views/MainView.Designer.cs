namespace PortfolioTracking.Presentation.Views
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PortfolioProfitGridView = new System.Windows.Forms.DataGridView();
            this.tickerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asOfDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marketValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyProfitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inceptionProfitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PortfolioTradeHistoryGridView = new System.Windows.Forms.DataGridView();
            this.tickerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradeActionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portfolioTradeHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PortfolioListBox = new System.Windows.Forms.ListBox();
            this.WelcomeLable = new System.Windows.Forms.Label();
            this.SelectedPortfolioNameLable = new System.Windows.Forms.Label();
            this.SelectedPortfolioWhenCreatedLable = new System.Windows.Forms.Label();
            this.UserDisplayNameLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PortfolioProfitGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PortfolioTradeHistoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portfolioTradeHistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PortfolioProfitGridView
            // 
            this.PortfolioProfitGridView.AllowUserToAddRows = false;
            this.PortfolioProfitGridView.AllowUserToDeleteRows = false;
            this.PortfolioProfitGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PortfolioProfitGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.PortfolioProfitGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PortfolioProfitGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tickerDataGridViewTextBoxColumn,
            this.asOfDateDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.curPriceDataGridViewTextBoxColumn,
            this.prePriceDataGridViewTextBoxColumn,
            this.marketValueDataGridViewTextBoxColumn,
            this.dailyProfitDataGridViewTextBoxColumn,
            this.inceptionProfitDataGridViewTextBoxColumn});
            this.PortfolioProfitGridView.DataSource = this.profitReportBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PortfolioProfitGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.PortfolioProfitGridView.Location = new System.Drawing.Point(202, 270);
            this.PortfolioProfitGridView.Name = "PortfolioProfitGridView";
            this.PortfolioProfitGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PortfolioProfitGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.PortfolioProfitGridView.Size = new System.Drawing.Size(948, 202);
            this.PortfolioProfitGridView.TabIndex = 0;
            // 
            // tickerDataGridViewTextBoxColumn
            // 
            this.tickerDataGridViewTextBoxColumn.DataPropertyName = "Ticker";
            this.tickerDataGridViewTextBoxColumn.HeaderText = "Ticker";
            this.tickerDataGridViewTextBoxColumn.Name = "tickerDataGridViewTextBoxColumn";
            this.tickerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asOfDateDataGridViewTextBoxColumn
            // 
            this.asOfDateDataGridViewTextBoxColumn.DataPropertyName = "AsOfDate";
            this.asOfDateDataGridViewTextBoxColumn.HeaderText = "As of Date";
            this.asOfDateDataGridViewTextBoxColumn.Name = "asOfDateDataGridViewTextBoxColumn";
            this.asOfDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // curPriceDataGridViewTextBoxColumn
            // 
            this.curPriceDataGridViewTextBoxColumn.DataPropertyName = "CurPrice";
            this.curPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.curPriceDataGridViewTextBoxColumn.Name = "curPriceDataGridViewTextBoxColumn";
            this.curPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prePriceDataGridViewTextBoxColumn
            // 
            this.prePriceDataGridViewTextBoxColumn.DataPropertyName = "PrePrice";
            this.prePriceDataGridViewTextBoxColumn.HeaderText = "Previous Price";
            this.prePriceDataGridViewTextBoxColumn.Name = "prePriceDataGridViewTextBoxColumn";
            this.prePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marketValueDataGridViewTextBoxColumn
            // 
            this.marketValueDataGridViewTextBoxColumn.DataPropertyName = "MarketValue";
            this.marketValueDataGridViewTextBoxColumn.HeaderText = "Market Value";
            this.marketValueDataGridViewTextBoxColumn.Name = "marketValueDataGridViewTextBoxColumn";
            this.marketValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dailyProfitDataGridViewTextBoxColumn
            // 
            this.dailyProfitDataGridViewTextBoxColumn.DataPropertyName = "DailyProfit";
            this.dailyProfitDataGridViewTextBoxColumn.HeaderText = "Daily Profit";
            this.dailyProfitDataGridViewTextBoxColumn.Name = "dailyProfitDataGridViewTextBoxColumn";
            this.dailyProfitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inceptionProfitDataGridViewTextBoxColumn
            // 
            this.inceptionProfitDataGridViewTextBoxColumn.DataPropertyName = "InceptionProfit";
            this.inceptionProfitDataGridViewTextBoxColumn.HeaderText = "Inception Profit";
            this.inceptionProfitDataGridViewTextBoxColumn.Name = "inceptionProfitDataGridViewTextBoxColumn";
            this.inceptionProfitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profitReportBindingSource
            // 
            this.profitReportBindingSource.DataSource = typeof(PortfolioTracking.BusinessObjects.ProfitReport);
            // 
            // PortfolioTradeHistoryGridView
            // 
            this.PortfolioTradeHistoryGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PortfolioTradeHistoryGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.PortfolioTradeHistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PortfolioTradeHistoryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tickerDataGridViewTextBoxColumn1,
            this.tradeDateDataGridViewTextBoxColumn,
            this.tradeActionDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn});
            this.PortfolioTradeHistoryGridView.DataSource = this.portfolioTradeHistoryBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PortfolioTradeHistoryGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.PortfolioTradeHistoryGridView.Location = new System.Drawing.Point(427, 65);
            this.PortfolioTradeHistoryGridView.Name = "PortfolioTradeHistoryGridView";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PortfolioTradeHistoryGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.PortfolioTradeHistoryGridView.Size = new System.Drawing.Size(723, 190);
            this.PortfolioTradeHistoryGridView.TabIndex = 1;
            // 
            // tickerDataGridViewTextBoxColumn1
            // 
            this.tickerDataGridViewTextBoxColumn1.DataPropertyName = "Ticker";
            this.tickerDataGridViewTextBoxColumn1.HeaderText = "Ticker";
            this.tickerDataGridViewTextBoxColumn1.Name = "tickerDataGridViewTextBoxColumn1";
            // 
            // tradeDateDataGridViewTextBoxColumn
            // 
            this.tradeDateDataGridViewTextBoxColumn.DataPropertyName = "TradeDate";
            this.tradeDateDataGridViewTextBoxColumn.HeaderText = "TradeDate";
            this.tradeDateDataGridViewTextBoxColumn.Name = "tradeDateDataGridViewTextBoxColumn";
            // 
            // tradeActionDataGridViewTextBoxColumn
            // 
            this.tradeActionDataGridViewTextBoxColumn.DataPropertyName = "TradeAction";
            this.tradeActionDataGridViewTextBoxColumn.HeaderText = "TradeAction";
            this.tradeActionDataGridViewTextBoxColumn.Name = "tradeActionDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            this.quantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // portfolioTradeHistoryBindingSource
            // 
            this.portfolioTradeHistoryBindingSource.DataSource = typeof(PortfolioTracking.BusinessObjects.PortfolioTradeHistory);
            // 
            // PortfolioListBox
            // 
            this.PortfolioListBox.FormattingEnabled = true;
            this.PortfolioListBox.Location = new System.Drawing.Point(13, 65);
            this.PortfolioListBox.Name = "PortfolioListBox";
            this.PortfolioListBox.Size = new System.Drawing.Size(167, 407);
            this.PortfolioListBox.TabIndex = 2;
            // 
            // WelcomeLable
            // 
            this.WelcomeLable.AutoSize = true;
            this.WelcomeLable.Location = new System.Drawing.Point(13, 23);
            this.WelcomeLable.Name = "WelcomeLable";
            this.WelcomeLable.Size = new System.Drawing.Size(52, 13);
            this.WelcomeLable.TabIndex = 3;
            this.WelcomeLable.Text = "Welcome";
            // 
            // SelectedPortfolioNameLable
            // 
            this.SelectedPortfolioNameLable.AutoSize = true;
            this.SelectedPortfolioNameLable.Location = new System.Drawing.Point(295, 75);
            this.SelectedPortfolioNameLable.Name = "SelectedPortfolioNameLable";
            this.SelectedPortfolioNameLable.Size = new System.Drawing.Size(0, 13);
            this.SelectedPortfolioNameLable.TabIndex = 4;
            // 
            // SelectedPortfolioWhenCreatedLable
            // 
            this.SelectedPortfolioWhenCreatedLable.AutoSize = true;
            this.SelectedPortfolioWhenCreatedLable.Location = new System.Drawing.Point(295, 100);
            this.SelectedPortfolioWhenCreatedLable.Name = "SelectedPortfolioWhenCreatedLable";
            this.SelectedPortfolioWhenCreatedLable.Size = new System.Drawing.Size(0, 13);
            this.SelectedPortfolioWhenCreatedLable.TabIndex = 5;
            // 
            // UserDisplayNameLable
            // 
            this.UserDisplayNameLable.AutoSize = true;
            this.UserDisplayNameLable.Location = new System.Drawing.Point(62, 23);
            this.UserDisplayNameLable.Name = "UserDisplayNameLable";
            this.UserDisplayNameLable.Size = new System.Drawing.Size(0, 13);
            this.UserDisplayNameLable.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Portfolio Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Created:";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 497);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserDisplayNameLable);
            this.Controls.Add(this.SelectedPortfolioWhenCreatedLable);
            this.Controls.Add(this.SelectedPortfolioNameLable);
            this.Controls.Add(this.WelcomeLable);
            this.Controls.Add(this.PortfolioListBox);
            this.Controls.Add(this.PortfolioTradeHistoryGridView);
            this.Controls.Add(this.PortfolioProfitGridView);
            this.Name = "MainView";
            this.Text = "MainView";
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PortfolioProfitGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PortfolioTradeHistoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portfolioTradeHistoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PortfolioProfitGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn tickerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asOfDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marketValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyProfitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inceptionProfitDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource profitReportBindingSource;
        private System.Windows.Forms.DataGridView PortfolioTradeHistoryGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn tickerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeActionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource portfolioTradeHistoryBindingSource;
        private System.Windows.Forms.ListBox PortfolioListBox;
        private System.Windows.Forms.Label WelcomeLable;
        private System.Windows.Forms.Label SelectedPortfolioNameLable;
        private System.Windows.Forms.Label SelectedPortfolioWhenCreatedLable;
        private System.Windows.Forms.Label UserDisplayNameLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}