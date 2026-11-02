using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

using ASP_Databáze.Models;

namespace ASP_Databáze.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>().HasData(
                new Movie { MovieId = 1, Title = "Pulp Fiction", year = 1994, Length = 154 },
                new Movie { MovieId = 2, Title = "The Shawshank Redemption", year = 1994, Length = 142 },
                new Movie { MovieId = 3, Title = "The Godfather", year = 1972, Length = 175 },
                new Movie { MovieId = 4, Title = "The Dark Knight", year = 2008, Length = 152 },
                new Movie { MovieId = 5, Title = "Forrest Gump", year = 1994, Length = 142 }
            );
        }
    }
}
