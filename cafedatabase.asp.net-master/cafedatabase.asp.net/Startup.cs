using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cafedatabase.asp.net.Startup))]
namespace cafedatabase.asp.net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
