using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonalStartUp.Startup))]
namespace PersonalStartUp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
