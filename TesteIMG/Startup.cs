using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TesteIMG.Startup))]
namespace TesteIMG
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
