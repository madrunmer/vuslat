using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vuslat.Startup))]
namespace vuslat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
