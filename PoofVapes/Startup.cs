using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PoofVapes.Startup))]
namespace PoofVapes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
