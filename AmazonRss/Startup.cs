using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AmazonRss.Startup))]
namespace AmazonRss
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
