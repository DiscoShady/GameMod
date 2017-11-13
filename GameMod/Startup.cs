using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameMod.Startup))]
namespace GameMod
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
