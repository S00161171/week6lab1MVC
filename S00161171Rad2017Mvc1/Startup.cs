using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(S00161171Rad2017Mvc1.Startup))]
namespace S00161171Rad2017Mvc1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
