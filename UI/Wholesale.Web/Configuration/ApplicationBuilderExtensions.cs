using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Wholesale.Domain.Common.DataInitializer;
using Wholesale.Domain.Common.Utilities;
using Wholesale.Infrastructure;

namespace Wholesale.Web.Configuration
{
    public static class ApplicationBuilderExtensions
    {
        public static void IntializeDatabase(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetService<WholesaleContext>(); 

                dbContext.Database.Migrate();

                var dataInitializers = scope.ServiceProvider.GetServices<IDataInitializer>();
                foreach (var dataInitializer in dataInitializers)
                    dataInitializer.InitializeData();
            }
        }
    }
}