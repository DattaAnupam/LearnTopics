using Microsoft.EntityFrameworkCore;
using RazorPages.Configurations;
using RazorPages.Models;

namespace RazorPages.Contexts
{
    public class BackeryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Product>(new ProductConfiguration());
        }
    }
}
