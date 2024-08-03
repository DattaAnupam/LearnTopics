using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodDonationApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doners",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    BloodGroup = table.Column<string>(type: "nvarchar(3)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(150)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doners", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doners");
        }
    }
}
