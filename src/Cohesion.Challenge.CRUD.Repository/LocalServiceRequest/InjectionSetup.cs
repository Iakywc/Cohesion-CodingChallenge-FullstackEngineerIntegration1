using Cohesion.Challenge.CRUD.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Cohesion.Challenge.CRUD.Repository.LocalServiceRequest
{
    public static class InjectionSetup
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IServiceRequestRepository, ServiceRequestRepository>();

            return services;
        }
    }
}
