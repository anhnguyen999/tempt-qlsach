using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuanLySachDatabaseFirst.Startup))]
namespace QuanLySachDatabaseFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
