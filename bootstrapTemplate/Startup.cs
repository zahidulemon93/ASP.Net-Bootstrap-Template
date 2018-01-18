using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bootstrapTemplate.Startup))]
namespace bootstrapTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
