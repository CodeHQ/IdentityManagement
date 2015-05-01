using System.ComponentModel.DataAnnotations;

namespace Sample_Web_Application.Areas.IdentityManagement.Models
{
    public class RoleViewModel
    {
        public string Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "RoleName")]
        public string Name { get; set; }
    }
}