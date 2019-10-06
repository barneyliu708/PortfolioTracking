using PortfolioTracking.BusinessObjects;

namespace PortfolioTracking.Services.Interfaces
{
    public interface IUserService
    {
        UserDetails GetUserDetailsByUserName(string userName);
    }
}