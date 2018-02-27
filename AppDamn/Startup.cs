using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppDamn.Startup))]
namespace AppDamn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
