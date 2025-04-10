using CQRSConcept.Domain.Services.BlogServices;
using Microsoft.Extensions.DependencyInjection;

namespace CQRSConcept.Domain.Registeration
{
    public static class RegisterDependency
    {
        public static IServiceCollection RegisterDomainServices(this IServiceCollection services)
        {
            services.AddScoped<IBlogDomainService, BlogDomainService>();
            return services;
        }

    }
}
