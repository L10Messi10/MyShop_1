using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShop_1.WebUI.Startup))]
namespace MyShop_1.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
