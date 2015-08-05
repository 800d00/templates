using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MWA.Startup))]
namespace MWA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
