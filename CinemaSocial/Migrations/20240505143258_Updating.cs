using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaSocial.Migrations
{
    /// <inheritdoc />
    public partial class Updating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_likes_reviews_ReviewId",
                table: "likes");

            migrationBuilder.DropForeignKey(
                name: "FK_likes_user_account_UserId",
                table: "likes");

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

            migrationBuilder.DropIndex(
                name: "IX_likes_ReviewId",
                table: "likes");

            migrationBuilder.DropIndex(
                name: "IX_likes_UserId",
                table: "likes");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "movies",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_reviews_MovieId",
                table: "reviews",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_reviews_UserId",
                table: "reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_likes_ReviewId",
                table: "likes",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_likes_UserId",
                table: "likes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_likes_reviews_ReviewId",
                table: "likes",
                column: "ReviewId",
                principalTable: "reviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_likes_user_account_UserId",
                table: "likes",
                column: "UserId",
                principalTable: "user_account",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

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
    }
}
