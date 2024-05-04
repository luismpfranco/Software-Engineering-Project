using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaSocial.Migrations
{
    /// <inheritdoc />
    public partial class ReviewsObjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_reviews_MovieId",
                table: "reviews",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_reviews_UserId",
                table: "reviews",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_reviews_movies_MovieId",
                table: "reviews",
                column: "MovieId",
                principalTable: "movies",
                principalColumn: "IdMovie",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_reviews_user_account_UserId",
                table: "reviews",
                column: "UserId",
                principalTable: "user_account",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_reviews_movies_MovieId",
                table: "reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_reviews_user_account_UserId",
                table: "reviews");

            migrationBuilder.DropIndex(
                name: "IX_reviews_MovieId",
                table: "reviews");

            migrationBuilder.DropIndex(
                name: "IX_reviews_UserId",
                table: "reviews");
        }
    }
}
