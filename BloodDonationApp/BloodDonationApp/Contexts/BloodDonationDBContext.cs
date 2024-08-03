using BloodDonationApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BloodDonationApp.Contexts
{
    public class BloodDonationDBContext : DbContext
    {
        public BloodDonationDBContext(DbContextOptions<BloodDonationDBContext> options) : base(options) { }

        public DbSet<Doners> Doners{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
