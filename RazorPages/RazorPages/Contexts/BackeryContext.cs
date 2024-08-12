﻿using Microsoft.EntityFrameworkCore;
using RazorPages.Configurations;
using RazorPages.Datas;
using RazorPages.Models;

namespace RazorPages.Contexts
{
    public class BackeryContext : DbContext
    {

        public BackeryContext(DbContextOptions<BackeryContext> options):base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Product>(new ProductConfiguration()).Seed();
        }
    }
}