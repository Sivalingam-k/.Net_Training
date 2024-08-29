using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend_app.Migrations
{
    /// <inheritdoc />
    public partial class Updatedlogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "username",
                table: "Login",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Login",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Login",
                newName: "PasswordHash");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Login",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Login",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "Login",
                newName: "password");
        }
    }
}
