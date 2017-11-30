using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BucksSafePlaceSite2.Startup))]
namespace BucksSafePlaceSite2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
