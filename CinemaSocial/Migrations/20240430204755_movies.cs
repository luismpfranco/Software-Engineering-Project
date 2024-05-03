using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaSocial.Migrations
{
    /// <inheritdoc />
    public partial class movies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    IdMovie = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Link = table.Column<string>(type: "TEXT", nullable: false),
                    ImdbId = table.Column<string>(type: "TEXT", nullable: false),
                    Rank = table.Column<int>(type: "INTEGER", nullable: false),
                    Rating = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.IdMovie);
                });

            migrationBuilder.CreateTable(
                name: "diretors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    IdMovie = table.Column<Guid>(type: "TEXT", nullable: false),
                    MovieIdMovie = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diretors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_diretors_movies_MovieIdMovie",
                        column: x => x.MovieIdMovie,
                        principalTable: "movies",
                        principalColumn: "IdMovie");
                });

            migrationBuilder.CreateTable(
                name: "genres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    IdMovie = table.Column<Guid>(type: "TEXT", nullable: false),
                    MovieIdMovie = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_genres_movies_MovieIdMovie",
                        column: x => x.MovieIdMovie,
                        principalTable: "movies",
                        principalColumn: "IdMovie");
                });

            migrationBuilder.CreateTable(
                name: "images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    IdMovie = table.Column<Guid>(type: "TEXT", nullable: false),
                    MovieIdMovie = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_images_movies_MovieIdMovie",
                        column: x => x.MovieIdMovie,
                        principalTable: "movies",
                        principalColumn: "IdMovie");
                });

            migrationBuilder.CreateTable(
                name: "stars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    IdMovie = table.Column<Guid>(type: "TEXT", nullable: false),
                    MovieIdMovie = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_stars_movies_MovieIdMovie",
                        column: x => x.MovieIdMovie,
                        principalTable: "movies",
                        principalColumn: "IdMovie");
                });

            migrationBuilder.CreateTable(
                name: "writers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    IdMovie = table.Column<Guid>(type: "TEXT", nullable: false),
                    MovieIdMovie = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_writers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_writers_movies_MovieIdMovie",
                        column: x => x.MovieIdMovie,
                        principalTable: "movies",
                        principalColumn: "IdMovie");
                });

            migrationBuilder.CreateIndex(
                name: "IX_diretors_MovieIdMovie",
                table: "diretors",
                column: "MovieIdMovie");

            migrationBuilder.CreateIndex(
                name: "IX_genres_MovieIdMovie",
                table: "genres",
                column: "MovieIdMovie");

            migrationBuilder.CreateIndex(
                name: "IX_images_MovieIdMovie",
                table: "images",
                column: "MovieIdMovie");

            migrationBuilder.CreateIndex(
                name: "IX_stars_MovieIdMovie",
                table: "stars",
                column: "MovieIdMovie");

            migrationBuilder.CreateIndex(
                name: "IX_writers_MovieIdMovie",
                table: "writers",
                column: "MovieIdMovie");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "diretors");

            migrationBuilder.DropTable(
                name: "genres");

            migrationBuilder.DropTable(
                name: "images");

            migrationBuilder.DropTable(
                name: "stars");

            migrationBuilder.DropTable(
                name: "writers");

            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
