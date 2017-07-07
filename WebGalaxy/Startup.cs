using Microsoft.Owin;
using Owin;

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
