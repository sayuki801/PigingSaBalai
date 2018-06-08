using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyProject1.Startup))]
namespace MyProject1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
