using Manager.Services.Interfaces;
using Manager.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Manager.Services
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services
                .AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
