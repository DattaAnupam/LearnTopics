using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodDonationApp.Migrations
{
    /// <inheritdoc />
    public partial class updatecolumnname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Doners",
                newName: "Full Name");

            migrationBuilder.RenameColumn(
                name: "BloodGroup",
                table: "Doners",
                newName: "Blood Group");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Full Name",
                table: "Doners",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "Blood Group",
                table: "Doners",
                newName: "BloodGroup");
        }
    }
}
