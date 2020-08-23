using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Wholesale.Infrastructure;

namespace Wholesale.Web.Configuration
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<WholesaleContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("WholesaleDbContext"));
            });
        }

    }
}