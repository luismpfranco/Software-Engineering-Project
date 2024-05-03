using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaSocial.Migrations
{
    /// <inheritdoc />
    public partial class AddMovieId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WatchlistFavourites_movies_MovieIdMovie",
                table: "WatchlistFavourites");

            migrationBuilder.DropForeignKey(
                name: "FK_WatchlistToWatch_movies_MovieIdMovie",
                table: "WatchlistToWatch");

            migrationBuilder.DropForeignKey(
                name: "FK_WatchlistWatched_movies_MovieIdMovie",
                table: "WatchlistWatched");

            migrationBuilder.RenameColumn(
                name: "MovieIdMovie",
                table: "WatchlistWatched",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_WatchlistWatched_MovieIdMovie",
                table: "WatchlistWatched",
                newName: "IX_WatchlistWatched_MovieId");

            migrationBuilder.RenameColumn(
                name: "MovieIdMovie",
                table: "WatchlistToWatch",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_WatchlistToWatch_MovieIdMovie",
                table: "WatchlistToWatch",
                newName: "IX_WatchlistToWatch_MovieId");

            migrationBuilder.RenameColumn(
                name: "MovieIdMovie",
                table: "WatchlistFavourites",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_WatchlistFavourites_MovieIdMovie",
                table: "WatchlistFavourites",
                newName: "IX_WatchlistFavourites_MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_WatchlistFavourites_movies_MovieId",
                table: "WatchlistFavourites",
                column: "MovieId",
                principalTable: "movies",
                principalColumn: "IdMovie",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WatchlistToWatch_movies_MovieId",
                table: "WatchlistToWatch",
                column: "MovieId",
                principalTable: "movies",
                principalColumn: "IdMovie",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WatchlistWatched_movies_MovieId",
                table: "WatchlistWatched",
                column: "MovieId",
                principalTable: "movies",
                principalColumn: "IdMovie",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WatchlistFavourites_movies_MovieId",
                table: "WatchlistFavourites");

            migrationBuilder.DropForeignKey(
                name: "FK_WatchlistToWatch_movies_MovieId",
                table: "WatchlistToWatch");

            migrationBuilder.DropForeignKey(
                name: "FK_WatchlistWatched_movies_MovieId",
                table: "WatchlistWatched");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "WatchlistWatched",
                newName: "MovieIdMovie");

            migrationBuilder.RenameIndex(
                name: "IX_WatchlistWatched_MovieId",
                table: "WatchlistWatched",
                newName: "IX_WatchlistWatched_MovieIdMovie");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "WatchlistToWatch",
                newName: "MovieIdMovie");

            migrationBuilder.RenameIndex(
                name: "IX_WatchlistToWatch_MovieId",
                table: "WatchlistToWatch",
                newName: "IX_WatchlistToWatch_MovieIdMovie");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "WatchlistFavourites",
                newName: "MovieIdMovie");

            migrationBuilder.RenameIndex(
                name: "IX_WatchlistFavourites_MovieId",
                table: "WatchlistFavourites",
                newName: "IX_WatchlistFavourites_MovieIdMovie");

            migrationBuilder.AddForeignKey(
                name: "FK_WatchlistFavourites_movies_MovieIdMovie",
                table: "WatchlistFavourites",
                column: "MovieIdMovie",
                principalTable: "movies",
                principalColumn: "IdMovie",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WatchlistToWatch_movies_MovieIdMovie",
                table: "WatchlistToWatch",
                column: "MovieIdMovie",
                principalTable: "movies",
                principalColumn: "IdMovie",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WatchlistWatched_movies_MovieIdMovie",
                table: "WatchlistWatched",
                column: "MovieIdMovie",
                principalTable: "movies",
                principalColumn: "IdMovie",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
