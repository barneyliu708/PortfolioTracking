using PortfolioTracking.BusinessObjects;
using PortfolioTracking.Infrastructure.DataAccess.Database;
using PortfolioTracking.Infrastructure.DataAccess.Database.Models;
using PortfolioTracking.Services.Interfaces;
using System.Data.Entity;
using System.Linq;

namespace PortfolioTracking.Services
{
    public class UserService : IUserService
    {
        private DbRepository _dbRepository;
        public UserService(DbContext dbcontext)
        {
            _dbRepository = new DbRepository(dbcontext);
        }

        public UserDetails GetUserDetailsByUserName(string userName)
        {
            UserProfile userProfile = _dbRepository.Get<UserProfile>().FirstOrDefault(u => u.UserName == userName);
            if (userProfile != null)
            {
                return new UserDetails()
                {
                    UserName = userProfile.UserName,
                    FirstName = userProfile.FirstName,
                    LastName = userProfile.LastName,
                    DisplayName = $"{userProfile.FirstName} {userProfile.LastName}"
                };
            }

            return new UserDetails()
            {
                UserName = userName,
                FirstName = "Anonymous",
                LastName = "Anonymous",
                DisplayName = "Anonymous"
            };
        }
    }
}
