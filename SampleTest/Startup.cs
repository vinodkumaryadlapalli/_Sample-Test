using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test_2022F.Startup))]
namespace Test_2022F
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
