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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PortfolioProfitGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PortfolioProfitGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.PortfolioProfitGridView.Location = new System.Drawing.Point(172, 126);
            this.PortfolioProfitGridView.Name = "PortfolioProfitGridView";
            this.PortfolioProfitGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PortfolioProfitGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.PortfolioProfitGridView.Size = new System.Drawing.Size(989, 173);
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
            this.inceptionProfitDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.inceptionProfitDataGridViewTextBoxColumn.Name = "inceptionProfitDataGridViewTextBoxColumn";
            this.inceptionProfitDataGridViewTextBoxColumn.ReadOnly = true;
            this.inceptionProfitDataGridViewTextBoxColumn.Width = 5;
            // 
            // profitReportBindingSource
            // 
            this.profitReportBindingSource.DataSource = typeof(PortfolioTracking.BusinessObjects.ProfitReport);
            // 
            // PortfolioTradeHistoryGridView
            // 
            this.PortfolioTradeHistoryGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PortfolioTradeHistoryGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.PortfolioTradeHistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PortfolioTradeHistoryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tickerDataGridViewTextBoxColumn1,
            this.tradeDateDataGridViewTextBoxColumn,
            this.tradeActionDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn});
            this.PortfolioTradeHistoryGridView.DataSource = this.portfolioTradeHistoryBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PortfolioTradeHistoryGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.PortfolioTradeHistoryGridView.Location = new System.Drawing.Point(616, 342);
            this.PortfolioTradeHistoryGridView.Name = "PortfolioTradeHistoryGridView";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PortfolioTradeHistoryGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.PortfolioTradeHistoryGridView.Size = new System.Drawing.Size(545, 184);
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
            this.PortfolioListBox.Location = new System.Drawing.Point(13, 104);
            this.PortfolioListBox.Name = "PortfolioListBox";
            this.PortfolioListBox.Size = new System.Drawing.Size(139, 433);
            this.PortfolioListBox.TabIndex = 2;
            this.PortfolioListBox.SelectedValueChanged += new System.EventHandler(this.PortfolioListBox_SelectedValueChanged);
            // 
            // WelcomeLable
            // 
            this.WelcomeLable.AutoSize = true;
            this.WelcomeLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLable.Location = new System.Drawing.Point(15, 59);
            this.WelcomeLable.Name = "WelcomeLable";
            this.WelcomeLable.Size = new System.Drawing.Size(108, 17);
            this.WelcomeLable.TabIndex = 3;
            this.WelcomeLable.Text = "Welcome back, ";
            // 
            // SelectedPortfolioNameLable
            // 
            this.SelectedPortfolioNameLable.AutoSize = true;
            this.SelectedPortfolioNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedPortfolioNameLable.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SelectedPortfolioNameLable.Location = new System.Drawing.Point(280, 342);
            this.SelectedPortfolioNameLable.Name = "SelectedPortfolioNameLable";
            this.SelectedPortfolioNameLable.Size = new System.Drawing.Size(187, 17);
            this.SelectedPortfolioNameLable.TabIndex = 4;
            this.SelectedPortfolioNameLable.Text = "SelectedPortfolioNameLable";
            this.SelectedPortfolioNameLable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SelectedPortfolioWhenCreatedLable
            // 
            this.SelectedPortfolioWhenCreatedLable.AutoSize = true;
            this.SelectedPortfolioWhenCreatedLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedPortfolioWhenCreatedLable.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SelectedPortfolioWhenCreatedLable.Location = new System.Drawing.Point(237, 390);
            this.SelectedPortfolioWhenCreatedLable.Name = "SelectedPortfolioWhenCreatedLable";
            this.SelectedPortfolioWhenCreatedLable.Size = new System.Drawing.Size(237, 17);
            this.SelectedPortfolioWhenCreatedLable.TabIndex = 5;
            this.SelectedPortfolioWhenCreatedLable.Text = "SelectedPortfolioWhenCreatedLable";
            this.SelectedPortfolioWhenCreatedLable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // UserDisplayNameLable
            // 
            this.UserDisplayNameLable.AutoSize = true;
            this.UserDisplayNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDisplayNameLable.Location = new System.Drawing.Point(114, 59);
            this.UserDisplayNameLable.Name = "UserDisplayNameLable";
            this.UserDisplayNameLable.Size = new System.Drawing.Size(156, 17);
            this.UserDisplayNameLable.TabIndex = 6;
            this.UserDisplayNameLable.Text = "UserDisplayNameLable";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Portfolio Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Created:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Portfolio Tracking Dashboard";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Profit Report";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(613, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Trade Histories";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 558);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}