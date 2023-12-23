using Application.Helpe;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddSingleton<MapperHelpe>();

            services.AddScoped<WorkTypeService>();
            services.AddScoped<WorkDomainService>();
            services.AddScoped<WorkService>();
            services.AddScoped<LibraryCardService>();
            services.AddScoped<BorrowingService>();
            services.AddScoped<BorrowingAlertViewService>();
            services.AddScoped<BorrowRuleService>();
            services.AddScoped<FineService>();
            services.AddScoped<PersonService>();
            
            return services;
        }
    }
}
