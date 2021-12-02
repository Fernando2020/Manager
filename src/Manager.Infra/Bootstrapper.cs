using Manager.Infra.Interfaces;
using Manager.Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Manager.Infra
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddInfra(this IServiceCollection services)
        {
            services
                .AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
