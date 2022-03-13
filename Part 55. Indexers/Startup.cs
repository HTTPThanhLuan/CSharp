using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Part_55.Indexers.Startup))]
namespace Part_55.Indexers
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
