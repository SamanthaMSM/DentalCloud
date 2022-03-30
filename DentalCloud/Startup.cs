using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DentalCloud.Startup))]
namespace DentalCloud
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
