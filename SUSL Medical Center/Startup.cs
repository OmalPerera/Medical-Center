using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SUSL_Medical_Center.Startup))]
namespace SUSL_Medical_Center
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
