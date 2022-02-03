using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Joel_Hilton_Film_Collection.Models
{
    public class EnterMoviesContext : DbContext
    {
        //constructor
        public EnterMoviesContext(DbContextOptions<EnterMoviesContext> options) : base(options)
        {

        }
        public DbSet<EnterMovies> movies { get; set; }
        public DbSet<Categories> categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Categories>().HasData(
                new Categories
                {
                    CategoryID = 1,
                    Category = "Action/Adventure"
                },
                new Categories
                {
                    CategoryID = 2,
                    Category = "Comedy"
                },
                new Categories
                {
                    CategoryID = 3,
                    Category = "Drama"
                },
                new Categories
                {
                    CategoryID = 4,
                    Category = "Family"
                },
                new Categories
                {
                    CategoryID = 5,
                    Category = "Miscellaneous"
                },
                new Categories
                {
                    CategoryID = 6,
                    Category = "Television"
                },
                new Categories
                {
                    CategoryID = 7,
                    Category = "Horror/Suspense"
                },
                new Categories
                {
                    CategoryID = 8,
                    Category = "VHS"
                }

                );

            mb.Entity<EnterMovies>().HasData(
                new EnterMovies
                {
                    MovieID = 1,
                    Title = "Avengers, The",
                    CategoryID = 1,
                    Year = 2012,
                    Director = "Joss Whedon",
                    Rating = "PG-13"

                },
                new EnterMovies
                {
                    MovieID = 2,
                    Title = "Batman",
                    CategoryID = 1,
                    Year = 1989,
                    Director = "Tim Burton",
                    Rating = "PG-13"

                },
                new EnterMovies
                {
                    MovieID = 3,
                    Title = "Batman & Robin",
                    CategoryID = 1,
                    Year = 1997,
                    Director = "Joel Schumacher",
                    Rating = "PG-13"

                }

                ); ;
        }
    }
}