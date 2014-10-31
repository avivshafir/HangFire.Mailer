using System;
using System.Threading.Tasks;
using Hangfire;
using Hangfire.SqlServer;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(HangFire.Mailer.Startup))]

namespace HangFire.Mailer
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseHangfire(config =>
            {
                // Basic setup required to process background jobs.
                config.UseSqlServerStorage("MailerDb");
                config.UseServer();
            });
        }
    }
}
