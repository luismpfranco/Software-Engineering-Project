using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaSocial.Migrations
{
    /// <inheritdoc />
    public partial class AddWatchlistTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_diretors_movies_MovieIdMovie",
                table: "diretors");

            migrationBuilder.DropForeignKey(
                name: "FK_genres_movies_MovieIdMovie",
                table: "genres");

            migrationBuilder.DropForeignKey(
                name: "FK_images_movies_MovieIdMovie",
                table: "images");

            migrationBuilder.DropForeignKey(
                name: "FK_stars_movies_MovieIdMovie",
                table: "stars");

            migrationBuilder.DropForeignKey(
                name: "FK_writers_movies_MovieIdMovie",
                table: "writers");

            migrationBuilder.DropIndex(
                name: "IX_writers_MovieIdMovie",
                table: "writers");

            migrationBuilder.DropIndex(
                name: "IX_stars_MovieIdMovie",
                table: "stars");

            migrationBuilder.DropIndex(
                name: "IX_images_MovieIdMovie",
                table: "images");

            migrationBuilder.DropIndex(
                name: "IX_genres_MovieIdMovie",
                table: "genres");

            migrationBuilder.DropIndex(
                name: "IX_diretors_MovieIdMovie",
                table: "diretors");

            migrationBuilder.DropColumn(
                name: "MovieIdMovie",
                table: "writers");

            migrationBuilder.DropColumn(
                name: "MovieIdMovie",
                table: "stars");

            migrationBuilder.DropColumn(
                name: "MovieIdMovie",
                table: "images");

            migrationBuilder.DropColumn(
                name: "MovieIdMovie",
                table: "genres");

            migrationBuilder.DropColumn(
                name: "MovieIdMovie",
                table: "diretors");

            migrationBuilder.CreateTable(
                name: "WatchlistFavourites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    MovieIdMovie = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchlistFavourites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WatchlistFavourites_movies_MovieIdMovie",
                        column: x => x.MovieIdMovie,
                        principalTable: "movies",
                        principalColumn: "IdMovie",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WatchlistToWatch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    MovieIdMovie = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchlistToWatch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WatchlistToWatch_movies_MovieIdMovie",
                        column: x => x.MovieIdMovie,
                        principalTable: "movies",
                        principalColumn: "IdMovie",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WatchlistWatched",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    MovieIdMovie = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchlistWatched", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WatchlistWatched_movies_MovieIdMovie",
                        column: x => x.MovieIdMovie,
                        principalTable: "movies",
                        principalColumn: "IdMovie",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_writers_IdMovie",
                table: "writers",
                column: "IdMovie");

            migrationBuilder.CreateIndex(
                name: "IX_stars_IdMovie",
                table: "stars",
                column: "IdMovie");

            migrationBuilder.CreateIndex(
                name: "IX_images_IdMovie",
                table: "images",
                column: "IdMovie");

            migrationBuilder.CreateIndex(
                name: "IX_genres_IdMovie",
                table: "genres",
                column: "IdMovie");

            migrationBuilder.CreateIndex(
                name: "IX_diretors_IdMovie",
                table: "diretors",
                column: "IdMovie");

            migrationBuilder.CreateIndex(
                name: "IX_WatchlistFavourites_MovieIdMovie",
                table: "WatchlistFavourites",
                column: "MovieIdMovie");

            migrationBuilder.CreateIndex(
                name: "IX_WatchlistToWatch_MovieIdMovie",
                table: "WatchlistToWatch",
                column: "MovieIdMovie");

            migrationBuilder.CreateIndex(
                name: "IX_WatchlistWatched_MovieIdMovie",
                table: "WatchlistWatched",
                column: "MovieIdMovie");

            migrationBuilder.AddForeignKey(
                name: "FK_diretors_movies_IdMovie",
                table: "diretors",
                column: "IdMovie",
                principalTable: "movies",
                principalColumn: "IdMovie",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_genres_movies_IdMovie",
                table: "genres",
                column: "IdMovie",
                principalTable: "movies",
                principalColumn: "IdMovie",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_images_movies_IdMovie",
                table: "images",
                column: "IdMovie",
                principalTable: "movies",
                principalColumn: "IdMovie",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_stars_movies_IdMovie",
                table: "stars",
                column: "IdMovie",
                principalTable: "movies",
                principalColumn: "IdMovie",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_writers_movies_IdMovie",
                table: "writers",
                column: "IdMovie",
                principalTable: "movies",
                principalColumn: "IdMovie",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_diretors_movies_IdMovie",
                table: "diretors");

            migrationBuilder.DropForeignKey(
                name: "FK_genres_movies_IdMovie",
                table: "genres");

            migrationBuilder.DropForeignKey(
                name: "FK_images_movies_IdMovie",
                table: "images");

            migrationBuilder.DropForeignKey(
                name: "FK_stars_movies_IdMovie",
                table: "stars");

            migrationBuilder.DropForeignKey(
                name: "FK_writers_movies_IdMovie",
                table: "writers");

            migrationBuilder.DropTable(
                name: "WatchlistFavourites");

            migrationBuilder.DropTable(
                name: "WatchlistToWatch");

            migrationBuilder.DropTable(
                name: "WatchlistWatched");

            migrationBuilder.DropIndex(
                name: "IX_writers_IdMovie",
                table: "writers");

            migrationBuilder.DropIndex(
                name: "IX_stars_IdMovie",
                table: "stars");

            migrationBuilder.DropIndex(
                name: "IX_images_IdMovie",
                table: "images");

            migrationBuilder.DropIndex(
                name: "IX_genres_IdMovie",
                table: "genres");

            migrationBuilder.DropIndex(
                name: "IX_diretors_IdMovie",
                table: "diretors");

            migrationBuilder.AddColumn<Guid>(
                name: "MovieIdMovie",
                table: "writers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MovieIdMovie",
                table: "stars",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MovieIdMovie",
                table: "images",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MovieIdMovie",
                table: "genres",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MovieIdMovie",
                table: "diretors",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_writers_MovieIdMovie",
                table: "writers",
                column: "MovieIdMovie");

            migrationBuilder.CreateIndex(
                name: "IX_stars_MovieIdMovie",
                table: "stars",
                column: "MovieIdMovie");

            migrationBuilder.CreateIndex(
                name: "IX_images_MovieIdMovie",
                table: "images",
                column: "MovieIdMovie");

            migrationBuilder.CreateIndex(
                name: "IX_genres_MovieIdMovie",
                table: "genres",
                column: "MovieIdMovie");

            migrationBuilder.CreateIndex(
                name: "IX_diretors_MovieIdMovie",
                table: "diretors",
                column: "MovieIdMovie");

            migrationBuilder.AddForeignKey(
                name: "FK_diretors_movies_MovieIdMovie",
                table: "diretors",
                column: "MovieIdMovie",
                principalTable: "movies",
                principalColumn: "IdMovie");

            migrationBuilder.AddForeignKey(
                name: "FK_genres_movies_MovieIdMovie",
                table: "genres",
                column: "MovieIdMovie",
                principalTable: "movies",
                principalColumn: "IdMovie");

            migrationBuilder.AddForeignKey(
                name: "FK_images_movies_MovieIdMovie",
                table: "images",
                column: "MovieIdMovie",
                principalTable: "movies",
                principalColumn: "IdMovie");

            migrationBuilder.AddForeignKey(
                name: "FK_stars_movies_MovieIdMovie",
                table: "stars",
                column: "MovieIdMovie",
                principalTable: "movies",
                principalColumn: "IdMovie");

            migrationBuilder.AddForeignKey(
                name: "FK_writers_movies_MovieIdMovie",
                table: "writers",
                column: "MovieIdMovie",
                principalTable: "movies",
                principalColumn: "IdMovie");
        }
    }
}
