using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaSocial.Migrations
{
    /// <inheritdoc />
    public partial class LikesReviewId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_likes_movies_MovieId",
                table: "likes");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "likes",
                newName: "ReviewId");

            migrationBuilder.RenameIndex(
                name: "IX_likes_MovieId",
                table: "likes",
                newName: "IX_likes_ReviewId");

            migrationBuilder.AddForeignKey(
                name: "FK_likes_reviews_ReviewId",
                table: "likes",
                column: "ReviewId",
                principalTable: "reviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_likes_reviews_ReviewId",
                table: "likes");

            migrationBuilder.RenameColumn(
                name: "ReviewId",
                table: "likes",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_likes_ReviewId",
                table: "likes",
                newName: "IX_likes_MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_likes_movies_MovieId",
                table: "likes",
                column: "MovieId",
                principalTable: "movies",
                principalColumn: "IdMovie",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
