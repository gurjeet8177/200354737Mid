using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DotNetMidtermB.Startup))]
namespace DotNetMidtermB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
