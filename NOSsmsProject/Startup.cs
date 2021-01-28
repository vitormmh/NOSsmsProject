using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NOSsmsProject.Startup))]
namespace NOSsmsProject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
