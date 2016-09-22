using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleDemo.Startup))]
namespace SimpleDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
