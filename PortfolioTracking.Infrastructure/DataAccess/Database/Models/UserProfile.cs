using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortfolioTracking.Infrastructure.DataAccess.Database.Models
{
    [Table("UserProfile")]
    public class UserProfile
    {
        public UserProfile()
        {
            Portfolios = new HashSet<Portfolio>();
        }

        [Key]
        [StringLength(150)]
        [Index(IsUnique = true)]
        public string UserName { get; set; }
        [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }

        public ICollection<Portfolio> Portfolios { get; set; }
    }
}
