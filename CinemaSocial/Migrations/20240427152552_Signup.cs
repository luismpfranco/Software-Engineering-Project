using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaSocial.Migrations
{
    /// <inheritdoc />
    public partial class Signup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_closed",
                table: "user_account");

            migrationBuilder.AddColumn<string>(
                name: "salt",
                table: "user_account",
                type: "TEXT",
                maxLength: 100,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "salt",
                table: "user_account");

            migrationBuilder.AddColumn<bool>(
                name: "is_closed",
                table: "user_account",
                type: "INTEGER",
                maxLength: 5,
                nullable: false,
                defaultValue: false);
        }
    }
}
