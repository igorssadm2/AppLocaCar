using AppLocaCar.Domain.Entities;
using AppLocaCar.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace AppLocaCar.Infra.IoC
{
    public static class DependencyInjectionData
    {
        /// <summary>
        /// Inject the dbcontext in application
        /// </summary>
        /// <param name="services"></param>
        /// <param name="Configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration Configuration)
        {
            
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(
                    Configuration.GetConnectionString("SqLite")));
            services.AddDatabaseDeveloperPageExceptionFilter();


            services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 4;
            }).AddEntityFrameworkStores<ApplicationDbContext>(); 

            services.AddControllersWithViews();

            return services;
        }
    }
}
