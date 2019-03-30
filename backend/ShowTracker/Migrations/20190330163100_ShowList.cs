using Microsoft.EntityFrameworkCore.Migrations;

namespace ShowTracker.Migrations
{
    public partial class ShowList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Shows_GenreId",
                table: "Shows",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shows_Genres_GenreId",
                table: "Shows",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shows_Genres_GenreId",
                table: "Shows");

            migrationBuilder.DropIndex(
                name: "IX_Shows_GenreId",
                table: "Shows");
        }
    }
}
