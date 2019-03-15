using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(M32COM_Group_G.Startup))]
namespace M32COM_Group_G
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
