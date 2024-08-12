using BloodDonationApp.Contexts;
using BloodDonationApp.Utilitis;
using Microsoft.EntityFrameworkCore;

namespace BloodDonationApp
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Add services to the container.
            services.AddDbContext<BloodDonationDBContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString(StringConstants.BloodDonationDBConnString));
            });

            services.AddControllers();
        }
    }
}
