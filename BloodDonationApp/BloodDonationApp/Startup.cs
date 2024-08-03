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
            // Add services to the container.

        }

        public void ConfigureServices(IServiceCollection services)
        {

        }
    }
}
