namespace PortfolioTracking.Infrastructure.DataAccess.Database.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Portfolio",
                c => new
                    {
                        PortfolioID = c.Long(nullable: false, identity: true),
                        PortfolioName = c.String(nullable: false, maxLength: 150),
                        WhenCreated = c.DateTime(nullable: false),
                        UserProfile_UserName = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.PortfolioID)
                .ForeignKey("dbo.UserProfile", t => t.UserProfile_UserName)
                .Index(t => t.UserProfile_UserName);
            
            CreateTable(
                "dbo.TradeHistory",
                c => new
                    {
                        TradeHistoryID = c.Long(nullable: false, identity: true),
                        Ticker = c.String(nullable: false, maxLength: 50),
                        TradeDate = c.DateTime(nullable: false),
                        TradeAction = c.Int(nullable: false),
                        Quantity = c.Long(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Portfolio_PortfolioID = c.Long(),
                    })
                .PrimaryKey(t => t.TradeHistoryID)
                .ForeignKey("dbo.Portfolio", t => t.Portfolio_PortfolioID)
                .Index(t => t.Portfolio_PortfolioID);
            
            CreateTable(
                "dbo.UserProfile",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 150),
                        FirstName = c.String(maxLength: 100),
                        LastName = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.UserName)
                .Index(t => t.UserName, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Portfolio", "UserProfile_UserName", "dbo.UserProfile");
            DropForeignKey("dbo.TradeHistory", "Portfolio_PortfolioID", "dbo.Portfolio");
            DropIndex("dbo.UserProfile", new[] { "UserName" });
            DropIndex("dbo.TradeHistory", new[] { "Portfolio_PortfolioID" });
            DropIndex("dbo.Portfolio", new[] { "UserProfile_UserName" });
            DropTable("dbo.UserProfile");
            DropTable("dbo.TradeHistory");
            DropTable("dbo.Portfolio");
        }
    }
}
