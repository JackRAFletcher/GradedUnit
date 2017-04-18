using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Property.Web.Startup))]
namespace Property.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
