﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShowTracker;

namespace ShowTracker.Migrations
{
    [DbContext(typeof(ShowContext))]
    [Migration("20190330180804_SeasonsAdded")]
    partial class SeasonsAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShowTracker.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new { GenreId = 1, Description = "Funny", Name = "Comedy" },
                        new { GenreId = 2, Description = "Slow", Name = "Drama" },
                        new { GenreId = 3, Description = "Fast", Name = "Action" }
                    );
                });

            modelBuilder.Entity("ShowTracker.Models.Show", b =>
                {
                    b.Property<int>("ShowId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("GenreId");

                    b.Property<string>("Name");

                    b.Property<int>("Seasons");

                    b.HasKey("ShowId");

                    b.HasIndex("GenreId");

                    b.ToTable("Shows");

                    b.HasData(
                        new { ShowId = 1, Description = "Shenanigans of moms in AA.", GenreId = 1, Name = "Mom", Seasons = 6 },
                        new { ShowId = 2, Description = "Life of a loving family.", GenreId = 1, Name = "Simpsons", Seasons = 30 },
                        new { ShowId = 3, Description = "Reality show about friends that perform practical jokes on each other.", GenreId = 1, Name = "Impractical Jokers", Seasons = 7 },
                        new { ShowId = 4, Description = "Nazis won WWII. What now?", GenreId = 2, Name = "Man in the High Castle", Seasons = 3 },
                        new { ShowId = 5, Description = "How the famous cannibal got caught.", GenreId = 2, Name = "Hannibal", Seasons = 3 },
                        new { ShowId = 6, Description = "Independent fictional stories of potential future technology and how it affects society.", GenreId = 2, Name = "Black Mirror", Seasons = 4 },
                        new { ShowId = 7, Description = "Man wakes up 200 years in the future and is hired to find who killed the man who hired him.", GenreId = 3, Name = "Altered Carbon", Seasons = 1 },
                        new { ShowId = 8, Description = "Agents from the future come back to prevent disaster.", GenreId = 3, Name = "Travelers", Seasons = 3 },
                        new { ShowId = 9, Description = "A group of once child superheroes reunite after their father's death to save the world.", GenreId = 3, Name = "The Umbrella Academy", Seasons = 1 }
                    );
                });

            modelBuilder.Entity("ShowTracker.Models.Show", b =>
                {
                    b.HasOne("ShowTracker.Models.Genre")
                        .WithMany("Shows")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
