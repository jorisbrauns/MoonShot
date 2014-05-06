using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonalTemplate.Startup))]
namespace PersonalTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
