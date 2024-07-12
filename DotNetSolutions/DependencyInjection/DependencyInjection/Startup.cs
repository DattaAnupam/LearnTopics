using DependencyInjection.Models;
using DependencyInjection.Models.Interfaces;

namespace DependencyInjection
{
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

            // Mapping of SingleTon Model
            services.AddSingleton<IAddSingleTon, AddSingleTon>();
            // Mapping of AddScoped Model
            services.AddScoped<IAddScoped, AddScopedModel>();
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
