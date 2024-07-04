using DependencyInjection.DiDemo.Interfaces;
using DependencyInjection.DiDemo;
using Microsoft.OpenApi.Models;

namespace DependencyInjection.Service
{
    public static class ServiceExtensions
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Add Swagger service
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc(configuration.GetValue<string>("SwaggerApiConfig:version"), new OpenApiInfo
                {
                    Title = configuration.GetValue<string>("SwaggerApiConfig:Title") ?? "v1",
                    Description = configuration.GetValue<string>("SwaggerApiConfig:Description") ?? "Dependecy Injection",
                });
            });

            // inject main service class
            services.AddScoped<IDiDemo, DIDemo>();

            return services;
        }
    }
}
