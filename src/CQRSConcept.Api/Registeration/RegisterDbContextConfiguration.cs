using CQRSConcept.Infrastructure.DbContexts.Sql.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace CQRSConcept.Api.Registeration
{
    public static class RegisterDbContextConfiguration
    {
        public static void RegisterSqlServer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>((serviceProvider, options) =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SqlServer"));

            }, ServiceLifetime.Scoped);
        }
    }
}
