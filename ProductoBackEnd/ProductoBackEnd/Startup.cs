using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductoBackEnd.Startup))]
namespace ProductoBackEnd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
