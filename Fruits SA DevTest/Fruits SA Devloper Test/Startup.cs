using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fruits_SA_Devloper_Test.Startup))]
namespace Fruits_SA_Devloper_Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
