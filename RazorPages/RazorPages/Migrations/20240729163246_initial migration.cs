using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorPages.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "ImageFileName", "Price", "ProductName" },
                values: new object[,]
                {
                    { new Guid("9c2adeab-ef8b-4d3c-812e-f08b826a84e5"), "A scrumptious carrot cake encrusted with sliced almonds", "carrot-cake.jpg", 150.09999999999999, "Carrot Cake" },
                    { new Guid("9faf6ece-e557-4cb3-bfa9-311de2c0990c"), "Fresh baked French-style bread, bagettes and cobs", "bread.jpg", 18.0, "Bread" },
                    { new Guid("b23903e6-d6f0-4eb6-bba6-9a6f7e03e7d4"), "A delicious lemon tart smothered with juicy fresh fruit", "lemon-tart.jpg", 20.0, "Lemon Tart" },
                    { new Guid("f3fa39bb-3ccb-4baa-9591-b3abb01e9e83"), "Delectable vanilla and chocolate cupcakes", "cup-cakes.jpg", 7.5, "Cupcakes" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
