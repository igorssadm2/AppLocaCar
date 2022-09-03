using AppLocaCar.Application.Interfaces.Services;
using AppLocaCar.Application.Mappings.DomainToDto;
using AppLocaCar.Application.Mappings.DtoToDomain;
using AppLocaCar.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLocaCar.Infra.IoC
{
    public static class DependencyInjectionServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IUserServices, UserService>();


            services.AddAutoMapper(typeof(DomainToDtoMappingProfile),
                typeof(DtoToDomainMappingProfile));

            return services;
        }
    }
}
