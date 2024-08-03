using BloodDonationApp.Contexts;
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
            
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Add services to the container.
            services.AddDbContext<BloodDonationDBContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString(""));
            });
        }
    }
}
