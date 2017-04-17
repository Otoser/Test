using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Alcogol.Web.Startup))]
namespace Alcogol.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
