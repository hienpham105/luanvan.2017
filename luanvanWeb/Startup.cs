using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(luanvanWeb.Startup))]
namespace luanvanWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
