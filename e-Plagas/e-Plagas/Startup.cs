using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(e_Plagas.Startup))]
namespace e_Plagas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
