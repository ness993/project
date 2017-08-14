using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MySQL_identity_demo.Startup))]
namespace MySQL_identity_demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
