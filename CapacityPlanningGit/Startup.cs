using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CapacityPlanningGit.Startup))]
namespace CapacityPlanningGit
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
