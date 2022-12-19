using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ASP.StartupOwin))]

namespace ASP
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
