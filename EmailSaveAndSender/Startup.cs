using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmailSaveAndSender.Startup))]
namespace EmailSaveAndSender
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
