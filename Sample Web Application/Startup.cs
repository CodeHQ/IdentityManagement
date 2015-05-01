using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sample_Web_Application.Startup))]
namespace Sample_Web_Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
