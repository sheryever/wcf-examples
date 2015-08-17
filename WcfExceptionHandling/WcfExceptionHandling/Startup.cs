using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WcfExceptionHandling.Startup))]
namespace WcfExceptionHandling
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
