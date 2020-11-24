using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eShopIMF.Startup))]
namespace eShopIMF
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
