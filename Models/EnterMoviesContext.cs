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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<EnterMovies>().HasData(
                new EnterMovies
                {
                    MovieID = 1,
                    Title = "Avengers, The",
                    Category = "Action/Adventure",
                    Year = 2012,
                    Director = "Joss Whedon",
                    Rating = "PG-13",
                    Edited = "",
                    LentTo = "",
                    Notes = ""

                },
                new EnterMovies
                {
                    MovieID = 2,
                    Title = "Batman",
                    Category = "Action/Adventure",
                    Year = 1989,
                    Director = "Tim Burton",
                    Rating = "PG-13",
                    Edited = "",
                    LentTo = "",
                    Notes = ""

                },
                new EnterMovies
                {
                    MovieID = 3,
                    Title = "Batman & Robin",
                    Category = "Action/Adventure",
                    Year = 1997,
                    Director = "Joel Schumacher",
                    Rating = "PG-13",
                    Edited = "",
                    LentTo = "",
                    Notes = ""

                }

                ); ;
        }
    }
}