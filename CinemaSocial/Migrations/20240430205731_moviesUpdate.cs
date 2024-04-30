using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaSocial.Migrations
{
    /// <inheritdoc />
    public partial class moviesUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NumberUrl",
                table: "images",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberUrl",
                table: "images");
        }
    }
}
