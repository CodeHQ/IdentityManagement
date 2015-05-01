using System.Web.Mvc;

namespace Sample_Web_Application.Areas.IdentityManagement
{
    public class IdentityManagementAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "IdentityManagement";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "IdentityManagement_default",
                "IdentityManagement/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}