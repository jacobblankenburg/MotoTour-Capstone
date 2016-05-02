using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MotoTour_Capstone.Startup))]
namespace MotoTour_Capstone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
