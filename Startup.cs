using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Decision.Startup))]
namespace Decision
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
