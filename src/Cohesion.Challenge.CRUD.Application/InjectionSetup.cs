using Cohesion.Challenge.CRUD.Application.Commands;
using Cohesion.Challenge.CRUD.Application.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace Cohesion.Challenge.CRUD.Application
{
    public static class InjectionSetup
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<ICreateServiceRequestCommandHandler, CreateServiceRequestCommandHandler>();
            services.AddTransient<IDeleteServiceRequestCommandHandler, DeleteServiceRequestCommandHandler>();
            services.AddTransient<IUpdateServiceRequestCommandHandler, UpdateServiceRequestCommandHandler>();
            services.AddTransient<IGetAllServiceRequestQueryHandler, GetAllServiceRequestQueryHandler>();
            services.AddTransient<IGetServiceRequestByIdQueryHandler, GetServiceRequestByIdQueryHandler>();

            return services;
        }
    }
}
