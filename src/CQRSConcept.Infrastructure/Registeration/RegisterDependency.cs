using CQRSConcept.Domain.DataAccess.Repositories.Blog;
using CQRSConcept.Infrastructure.DataAccess.Repositories.Blog;
using CQRSConcept.Infrastructure.DbContexts.Mongo;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CQRSConcept.Infrastructure.Registeration
{
    public static class RegisterDependency
    {
        public static IServiceCollection RegisterMongo(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICQRSConceptContext, CQRSConceptContext>(c =>
            {
                return new CQRSConceptContext(configuration);
            });

            return services;
        }


        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBlogSqlRepository, BlogSqlRepository>();
            services.AddScoped<IBlogMongoRepository, BlogMongoRepository>();

            return services;
        }

    }
}
