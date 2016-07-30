using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcGameCollection.Startup))]
namespace mvcGameCollection
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
