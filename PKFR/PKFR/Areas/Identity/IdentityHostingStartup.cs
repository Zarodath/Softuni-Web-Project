using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PKFR.Web.Areas.Identity.Data;
using PKFR.Web.Models;

[assembly: HostingStartup(typeof(PKFR.Web.Areas.Identity.IdentityHostingStartup))]
namespace PKFR.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<PKFRContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("PKFRContextConnection")));

                services.AddDefaultIdentity<PKFRUser>()
                    .AddEntityFrameworkStores<PKFRContext>();
            });
        }
    }
}