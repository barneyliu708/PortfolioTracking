namespace PortfolioTracking.Infrastructure.DataAccess.Database.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<PortfolioTracking.Infrastructure.DataAccess.Database.PortfolioDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"DataAccess\Database\Migrations";
        }

        protected override void Seed(PortfolioTracking.Infrastructure.DataAccess.Database.PortfolioDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
