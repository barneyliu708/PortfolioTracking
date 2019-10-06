namespace PortfolioTracking.Infrastructure.DataAccess.Database.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InsertData : DbMigration
    {
        public override void Up()
        {
            Sql(@"Insert Into UserProfile  (UserName, FirstName, LastName)
                  Values
                     ('nliu', 'Nanke', 'Liu'),
                     ('eballesteros', 'Eduardo', 'Ballesteros')");

            Sql(@"Insert Into Portfolio (PortfolioName, WhenCreated, UserProfile_UserName)
                  Values
                     ('My First Portfolio', '01/01/2019', 'nliu'),
                     ('My Second Portfolio', '01/01/2019', 'nliu'),
                     ('Test Portfolio', '01/01/2019', 'eballesteros')");

            Sql(@"Insert Into TradeHistory (Ticker, TradeDate, TradeAction, Quantity, Price, Portfolio_PortfolioID)
                  Values
                     ('MSFT', '01/02/2019', 0, 100, 85.95, 1),
                     ('GOOG', '01/02/2019', 0, 50, 1065, 1),
                     ('MSFT', '01/10/2019', 0, 150, 87.82, 1)");

        }

        public override void Down()
        {
            Sql(@"Delete TradeHistory");
            Sql(@"Delete Portfolio");
            Sql(@"Delete UserProfile");
        }
    }
}
