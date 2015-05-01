using Sample_Web_Application.Models;

namespace Sample_Web_Application.Areas.IdentityManagement.Models
{
    public class UserDetailsViewModel
    {
        public ApplicationUser User { get; set; }
        public LockoutViewModel Lockout { get; set; }
    }
}