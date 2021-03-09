using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FashionPlace.Startup))]
namespace FashionPlace
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
