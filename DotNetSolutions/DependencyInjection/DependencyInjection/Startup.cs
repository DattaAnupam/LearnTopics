using DependencyInjection.Models;
using DependencyInjection.Models.Interfaces;

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
            // Register all three types
            services.AddSingleton<IAddSingleTon, DiOperations>();
            services.AddScoped<IAddScoped,  DiOperations>();
            services.AddTransient<IAddTransient, DiOperations>()
        }

        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}