using CQRSConcept.Infrastructure.DbContexts.Mongo;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CQRSConcept.Infrastructure.Registeration
{
    public static  class RegisterMongoConfiguration
    {
        public static IServiceCollection RegisterMongo(this IServiceCollection services , IConfiguration configuration)
        {
            services.AddScoped<ICQRSConceptContext, CQRSConceptContext>(c =>
            {
                return new CQRSConceptContext(configuration);
            });

            return services;
        }
    }

}
