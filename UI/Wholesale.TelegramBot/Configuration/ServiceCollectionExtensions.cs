using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Wholesale.Infrastructure;

namespace Wholesale.TelegramBot.Configuration
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