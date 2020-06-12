using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nguentanthuan_lab456.Startup))]
namespace nguentanthuan_lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
