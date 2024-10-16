using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Udemy.CarBook.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class change_service : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ServicesID",
                table: "Services",
                newName: "ServiceID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ServiceID",
                table: "Services",
                newName: "ServicesID");
        }
    }
}
