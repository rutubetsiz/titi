using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MadamRozikaOOP.Startup))]
namespace MadamRozikaOOP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
