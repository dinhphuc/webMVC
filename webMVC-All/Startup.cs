using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webMVC_All.Startup))]
namespace webMVC_All
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
