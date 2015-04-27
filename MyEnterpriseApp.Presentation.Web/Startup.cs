using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyEnterpriseApp.Presentation.Web.Startup))]
namespace MyEnterpriseApp.Presentation.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
