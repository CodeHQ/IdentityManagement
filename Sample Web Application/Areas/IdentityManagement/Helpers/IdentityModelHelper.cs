using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using Sample_Web_Application.Areas.IdentityManagement.Models;
using Sample_Web_Application.Models;

namespace Sample_Web_Application.Areas.IdentityManagement.Helpers
{
    public class IdentityModelHelper
    {
        private readonly ApplicationUserManager _userManager;
        private ApplicationRoleManager _roleManager;
        public IdentityModelHelper(ApplicationUserManager userManager, ApplicationRoleManager roleManager)
        {
            Contract.Assert(null != userManager);
            Contract.Assert(null != roleManager);
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<UserDetailsViewModel> GetUserDetailsViewModel(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            var detailsModel = new UserDetailsViewModel() { User = user, Lockout = new LockoutViewModel() };
            var isLocked = await _userManager.IsLockedOutAsync(user.Id);
            detailsModel.Lockout.Status = isLocked ? LockoutStatus.Locked : LockoutStatus.Unlocked;
            if (detailsModel.Lockout.Status == LockoutStatus.Locked)
            {
                detailsModel.Lockout.LockoutEndDate = (await _userManager.GetLockoutEndDateAsync(user.Id)).DateTime;
            }
            return detailsModel;
        }
    }
}