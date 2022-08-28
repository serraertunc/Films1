using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
//using Films.Data;

namespace Films.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FilmsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FilmsContext>>()))
            {
                // Look for any movies.
                if (context.Movies.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movies.AddRange(
                    new Movies
                    {
                        Title = "When Harry Met Sally",
                        InMovieList = false,
                        Genre = "Romantic Comedy",
                        Director = "Rob Reiner",
                        Score = 8.9,
                        ReleaseDate = DateTime.Parse("1989-2-12")
                    },

                    new Movies
                    {
                        Title = "Ghostbusters ",
                        InMovieList = false,
                        Genre = "Comedy",
                        Director = "Ican Reitman",
                        Score = 7.0,
                        ReleaseDate = DateTime.Parse("1984-3-13")
                    },

                    new Movies
                    {
                        Title = "Ghostbusters 2",
                        InMovieList = false,
                        Genre = "Comedy",
                        Director = "Ivan Reitman",
                        Score = 7.2,
                        ReleaseDate = DateTime.Parse("1986-2-23")
                    },

                    new Movies
                    {
                        Title = "Rio Bravo",
                        InMovieList = false,
                        Genre = "Western",
                        Director = "abc",
                        Score = 6.2,
                        ReleaseDate = DateTime.Parse("1959-4-15")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
