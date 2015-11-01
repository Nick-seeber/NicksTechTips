using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NicksTechTips.Startup))]
namespace NicksTechTips
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
