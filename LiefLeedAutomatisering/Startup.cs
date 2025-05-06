using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LiefLeedAutomatisering.Startup))]
namespace LiefLeedAutomatisering
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
