using IdentityManagement.Web.Models;

namespace IdentityManagement.Web.Areas.IdentityManagement.Models
{
    public class UserDetailsViewModel
    {
        public ApplicationUser User { get; set; }
        public LockoutViewModel Lockout { get; set; }
    }
}