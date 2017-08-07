using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRUDFunctionality.Startup))]
namespace CRUDFunctionality
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
