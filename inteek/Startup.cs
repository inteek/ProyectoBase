using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(inteek.Startup))]
namespace inteek
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
