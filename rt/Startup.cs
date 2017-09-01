using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(rt.Startup))]
namespace rt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
