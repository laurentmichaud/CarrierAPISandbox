using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarrierAPISandbox.Startup))]
namespace CarrierAPISandbox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
