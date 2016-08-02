using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gestion_HojasdeVida.Startup))]
namespace Gestion_HojasdeVida
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
