using CQRSConcept.Infrastructure.DbContexts.Sql.SqlServer;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CQRSConcept.Api.Registeration
{
    public static class RegisterDependency
    {
        public static void RegisterSqlServer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>((serviceProvider, options) =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SqlServer"));

            }, ServiceLifetime.Scoped);
        }


        public static void RegisterMediatR(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
                cfg.Lifetime = ServiceLifetime.Scoped;
            });
        }
    }
}
