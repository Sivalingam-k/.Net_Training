using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReactAspCrud.Migrations
{
    /// <inheritdoc />
    public partial class dbupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Students1",
                table: "Students1");

            migrationBuilder.RenameTable(
                name: "Students1",
                newName: "Student1s");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student1s",
                table: "Student1s",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Student1s",
                table: "Student1s");

            migrationBuilder.RenameTable(
                name: "Student1s",
                newName: "Students1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students1",
                table: "Students1",
                column: "Id");
        }
    }
}
