using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab3_LaTrungHoa.Startup))]
namespace lab3_LaTrungHoa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
