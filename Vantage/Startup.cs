using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vantage.Startup))]
namespace Vantage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
