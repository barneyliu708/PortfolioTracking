namespace PortfolioTracking.Infrastructure.DataAccess.Database
{
    using System.Data.Entity;
    using PortfolioTracking.Infrastructure.DataAccess.Database.Models;

    public partial class PortfolioDbContext : DbContext
    {
        public PortfolioDbContext()
            : base("name=PortfolioDbContext")
        {
        }

        public virtual DbSet<UserProfile> UserProfiles { get; set; }
        public virtual DbSet<Portfolio> Portfolios { get; set; }
        public virtual DbSet<TradeHistory> TradeHistories { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
