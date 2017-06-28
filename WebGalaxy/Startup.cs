using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebGalaxy.Startup))]
namespace WebGalaxy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
