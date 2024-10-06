using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechStore.Migrations
{
    /// <inheritdoc />
    public partial class addColumEmailInUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "password_hash",
                table: "users",
                newName: "password");

            migrationBuilder.AddColumn<string>(
                name: "emails",
                table: "users",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "emails",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "users",
                newName: "password_hash");
        }
    }
}
