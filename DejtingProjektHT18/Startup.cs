using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DejtingProjektHT18.Startup))]
namespace DejtingProjektHT18
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
