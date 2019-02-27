using System;
using BoomGaming.Areas.Identity.Data;
using BoomGaming.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(BoomGaming.Areas.Identity.IdentityHostingStartup))]
namespace BoomGaming.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<BoomGamingContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("BoomGamingContextConnection")));

                services.AddDefaultIdentity<BoomGamingUser>()
                    .AddEntityFrameworkStores<BoomGamingContext>();
            });
        }
    }
}