using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShowTracker.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    GenreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Shows",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Seasons = table.Column<int>(nullable: false),
                    ShowId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shows", x => x.ShowId);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Funny", "Comedy" },
                    { 2, "Slow", "Drama" },
                    { 3, "Fast", "Action" }
                });

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "ShowId", "Description", "GenreId", "Name", "Seasons" },
                values: new object[,]
                {
                    { 1, "Shenanigans of moms in AA.", 1, "Mom", 0 },
                    { 2, "Life of a loving family.", 1, "Simpsons", 0 },
                    { 3, "Reality show about friends that perform practical jokes on each other.", 1, "Impractical Jokers", 0 },
                    { 4, "Nazis won WWII. What now?", 2, "Man in the High Castle", 0 },
                    { 5, "How the famous cannibal got caught.", 2, "Hannibal", 0 },
                    { 6, "Independent fictional stories of potential future technology and how it affects society.", 2, "Black Mirror", 0 },
                    { 7, "Man wakes up 200 years in the future and is hired to find who killed the man who hired him.", 3, "Altered Carbon", 0 },
                    { 8, "Agents from the future come back to prevent disaster.", 3, "Travelers", 0 },
                    { 9, "A group of once child superheroes reunite after their father's death to save the world.", 3, "The Umbrella Academy", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Shows");
        }
    }
}
