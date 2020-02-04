using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UnoWebApi.Startup))]
namespace UnoWebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
