using Microsoft.EntityFrameworkCore;
using RazorPages.Models;

namespace RazorPages.Contexts
{
    public class BackeryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
