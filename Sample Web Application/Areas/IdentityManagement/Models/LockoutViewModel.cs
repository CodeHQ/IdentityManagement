using System;

namespace Sample_Web_Application.Areas.IdentityManagement.Models
{
    public class LockoutViewModel
    {
        public LockoutStatus Status { get; set; }
        public DateTime? LockoutEndDate { get; set; }
    }
}