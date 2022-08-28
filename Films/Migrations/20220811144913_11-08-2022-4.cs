using Microsoft.EntityFrameworkCore.Migrations;

namespace Films.Migrations
{
    public partial class _110820224 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieMovieList_AspNetUsers_UserId1",
                table: "MovieMovieList");

            migrationBuilder.DropIndex(
                name: "IX_MovieMovieList_UserId1",
                table: "MovieMovieList");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "MovieMovieList");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "MovieMovieList",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MovieMovieList_UserId1",
                table: "MovieMovieList",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieMovieList_AspNetUsers_UserId1",
                table: "MovieMovieList",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
