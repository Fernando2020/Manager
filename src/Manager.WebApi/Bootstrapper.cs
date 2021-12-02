using AutoMapper;
using Manager.Domain.Entities;
using Manager.Services.DTO;
using Manager.WebApi.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace Manager.WebApi
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddMapping(this IServiceCollection services)
        {
            var autoMapperConfigura = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDTO>().ReverseMap();
                cfg.CreateMap<CreateUserViewModel, UserDTO>().ReverseMap();
            });

            services
                .AddSingleton(autoMapperConfigura.CreateMapper());

            return services;
        }
    }
}
