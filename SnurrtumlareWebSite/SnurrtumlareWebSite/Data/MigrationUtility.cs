using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SnurrtumlareWebSite.Data
{
    public static class MigrationUtility
    {
        public static IHost MigrateDb(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            if (host == null)
            {
                try
                {
                    context.Database.Migrate();
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                    throw;
                }
            }
            

            return host;
        }

        public static IHost MigrateSnurrtumlareDb(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<SnurrtumlareDbContext>();
            try
            {
                context.Database.Migrate();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }

            return host;
        }
    }


}
