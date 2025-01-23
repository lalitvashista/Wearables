using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wearables.Web.Startup))]
namespace Wearables.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
