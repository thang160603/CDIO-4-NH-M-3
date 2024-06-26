using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CDIO_4._1.Startup))]
namespace CDIO_4._1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
