using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreCRUDDemo.Migrations
{
    /// <inheritdoc />
    public partial class Migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "designaetion",
                table: "Employees",
                newName: "designation");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "designation",
                table: "Employees",
                newName: "designaetion");
        }
    }
}
