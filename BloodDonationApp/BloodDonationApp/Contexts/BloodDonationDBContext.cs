using Microsoft.EntityFrameworkCore;

namespace BloodDonationApp.Contexts
{
    public class BloodDonationDBContext : DbContext
    {
        public BloodDonationDBContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
