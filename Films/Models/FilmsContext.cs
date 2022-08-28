using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Films.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Films.Models
{
    public class FilmsContext : IdentityDbContext<IdentityUser>
    {
        public FilmsContext (DbContextOptions<FilmsContext> options)
            : base(options)
        {

        }

        public DbSet<Films.Models.Movies> Movies { get; set; }
        public DbSet <Films.Models.MovieList> MovieList { get; set; }
        public DbSet<Films.Models.MovieMovieList> MovieMovieList { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieList>()
                .HasMany<Movies>(m =>m.MoviesInList)
                .WithMany(b => b.Movies)
                .Map(mb => 
                           {
                               mb.MapLeftKey("MovieListRefId");
                               mb.MapRightKey("MoviesRefId");
                               mb.ToTable("MoviesMovieList");
                           });
        }*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MovieMovieList>()
                .HasKey(ml => new { ml.MovieMovieListID });

            modelBuilder.Entity<MovieMovieList>()
                .HasOne(ml => ml.Movie)
                .WithMany(m => m.MoviesMovieLists)
                .HasForeignKey(ml => ml.MovieID);

            modelBuilder.Entity<MovieMovieList>()
                .HasOne(ml => ml.MovieLists)
                .WithMany(l => l.MoviesMovieLists)
                .HasForeignKey(ml => ml.MovieListID);
        }

    }
}
