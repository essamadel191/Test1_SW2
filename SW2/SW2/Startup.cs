using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SW2.Startup))]
namespace SW2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
