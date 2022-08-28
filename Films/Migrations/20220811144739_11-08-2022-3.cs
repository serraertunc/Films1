using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Films.Migrations
{
    public partial class _110820223 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "MovieMovieList",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieMovieList_AspNetUsers_UserId1",
                table: "MovieMovieList");

            migrationBuilder.DropIndex(
                name: "IX_MovieMovieList_UserId1",
                table: "MovieMovieList");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "MovieMovieList");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "MovieMovieList");
        }
    }
}
