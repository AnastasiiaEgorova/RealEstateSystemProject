using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RealEstateSystem.Startup))]
namespace RealEstateSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
