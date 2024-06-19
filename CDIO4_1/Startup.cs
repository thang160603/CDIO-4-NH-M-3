using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CDIO4_1.Startup))]
namespace CDIO4_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
