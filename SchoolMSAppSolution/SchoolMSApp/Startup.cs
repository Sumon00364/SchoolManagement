using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoolMSApp.Startup))]
namespace SchoolMSApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
