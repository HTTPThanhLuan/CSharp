using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Part_56.Overloading_Indexers.Startup))]
namespace Part_56.Overloading_Indexers
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
