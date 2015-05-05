using $rootnamespace$.Models;

namespace $rootnamespace$.Areas.IdentityManagement.Models
{
    public class UserDetailsViewModel
    {
        public ApplicationUser User { get; set; }
        public LockoutViewModel Lockout { get; set; }
    }
}