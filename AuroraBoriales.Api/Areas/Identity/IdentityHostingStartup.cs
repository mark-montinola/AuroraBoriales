using System;
using AuroraBoriales.Api.Areas.Identity.Data;
using AuroraBoriales.Api.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(AuroraBoriales.Api.Areas.Identity.IdentityHostingStartup))]
namespace AuroraBoriales.Api.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AuroraBorialesApiContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AuroraBorialesApiContextConnection")));

                services.AddDefaultIdentity<AuroraBorialesApiUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<AuroraBorialesApiContext>();
            });
        }
    }
}