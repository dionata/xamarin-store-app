using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lungXrayBoneRemover.Startup))]
namespace lungXrayBoneRemover
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
