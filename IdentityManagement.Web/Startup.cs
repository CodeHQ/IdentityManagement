using IdentityManagement.Web;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace IdentityManagement.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
