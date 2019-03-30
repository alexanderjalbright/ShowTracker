using ShowTracker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowTracker
{
    public class ShowContext : DbContext
    {
        public DbSet<Show> Shows { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=MVPShowTracker;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
            new Genre()
            {
                GenreId = 1,
                Name = "Comedy",
                Description = "Funny"
            },
            new Genre()
            {
                GenreId = 2,
                Name = "Drama",
                Description = "Slow"
            },
            new Genre()
            {
                GenreId = 3,
                Name = "Action",
                Description = "Fast"
            }
            );

            modelBuilder.Entity<Show>().HasData(
            new Show()
            {
                ShowId = 1,
                GenreId = 1,
                Name = "Mom",
                Description = "Shenanigans of moms in AA.",
                Seasons = 6
            },
            new Show()
            {
                ShowId = 2,
                GenreId = 1,
                Name = "Simpsons",
                Description = "Life of a loving family.",
                Seasons = 30
            },
            new Show()
            {
                ShowId = 3,
                GenreId = 1,
                Name = "Impractical Jokers",
                Description = "Reality show about friends that perform practical jokes on each other.",
                Seasons = 7
            }, 
            new Show()
            {
                ShowId = 4,
                GenreId = 2,
                Name = "Man in the High Castle",
                Description = "Nazis won WWII. What now?",
                Seasons = 3
            }, 
            new Show()
            {
                ShowId = 5,
                GenreId = 2,
                Name = "Hannibal",
                Description = "How the famous cannibal got caught.",
                Seasons = 3
            }, 
            new Show()
            {
                ShowId = 6,
                GenreId = 2,
                Name = "Black Mirror",
                Description = "Independent fictional stories of potential future technology and how it affects society.",
                Seasons = 4
            }, 
            new Show()
            {
                ShowId = 7,
                GenreId = 3,
                Name = "Altered Carbon",
                Description = "Man wakes up 200 years in the future and is hired to find who killed the man who hired him.",
                Seasons = 1
            }, 
            new Show()
            {
                ShowId = 8,
                GenreId = 3,
                Name = "Travelers",
                Description = "Agents from the future come back to prevent disaster.",
                Seasons = 3
            }, 
            new Show()
            {
                ShowId = 9,
                GenreId = 3,
                Name = "The Umbrella Academy",
                Description = "A group of once child superheroes reunite after their father's death to save the world.",
                Seasons = 1
            }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
