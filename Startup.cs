using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LabCodeFirst.Startup))]
namespace LabCodeFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
