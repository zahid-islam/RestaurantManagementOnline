using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestaurantMng.Startup))]
namespace RestaurantMng
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
