using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieReview.Startup))]
namespace MovieReview
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
