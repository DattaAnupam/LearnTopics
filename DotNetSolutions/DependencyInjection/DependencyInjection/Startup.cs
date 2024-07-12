using DependencyInjection.Service;
using System.Diagnostics.CodeAnalysis;

namespace DependencyInjection
{
    [ExcludeFromCodeCoverage]
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            // Register other services
            services.RegisterServices(Configuration);
        }

        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            // Enable Swagger UI
            app.UseSwagger();
            app.UseSwaggerUI(options => {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                options.RoutePrefix = string.Empty;
            });

            // Specify endpoint so that can be used as an api
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
