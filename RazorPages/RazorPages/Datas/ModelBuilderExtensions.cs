using Microsoft.EntityFrameworkCore;
using RazorPages.Models;

namespace RazorPages.Datas
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasData(
                    new Product()
                    {
                        ID = Guid.Parse("9c2adeab-ef8b-4d3c-812e-f08b826a84e5"),
                        ProductName = "Carrot Cake",
                        Description = "A scrumptious carrot cake encrusted with sliced almonds",
                        Price = 150.10,
                        ImageName = "carrot-cake.jpg"
                    },
                    new Product()
                    {
                        ID = Guid.Parse("b23903e6-d6f0-4eb6-bba6-9a6f7e03e7d4"),
                        ProductName = "Lemon Tart",
                        Description = "A delicious lemon tart smothered with juicy fresh fruit",
                        Price = 20,
                        ImageName = "lemon-tart.jpg"
                    },
                    new Product()
                    {
                        ID = Guid.Parse("f3fa39bb-3ccb-4baa-9591-b3abb01e9e83"),
                        ProductName = "Cupcakes",
                        Description = "Delectable vanilla and chocolate cupcakes",
                        Price = 7.5,
                        ImageName = "cup-cakes.jpg"
                    },
                    new Product()
                    {
                        ID = Guid.Parse("9faf6ece-e557-4cb3-bfa9-311de2c0990c"),
                        ProductName = "Bread",
                        Description = "Fresh baked French-style bread, bagettes and cobs",
                        Price = 18,
                        ImageName = "bread.jpg"
                    }
                );
            return modelBuilder;
        }
    }
}
