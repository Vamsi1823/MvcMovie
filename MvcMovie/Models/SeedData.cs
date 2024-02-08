using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "RRR",
                    ReleaseDate = DateTime.Parse("2022-03-24"),
                    Genre = "Drama",
                    Rating = "9",
                    Price = 8M
                },
                new Movie
                {
                    Title = "KGF ",
                    ReleaseDate = DateTime.Parse("2018-12-20"),
                    Genre = "Action",
                    Rating = "8",
                    Price = 6M
                },
                new Movie
                {
                    Title = "Baahubali",
                    ReleaseDate = DateTime.Parse("2015-07-09"),
                    Genre = "Comedy",
                    Rating = "9",
                    Price = 6M
                },
                new Movie
                {
                    Title = "Saaho",
                    ReleaseDate = DateTime.Parse("2019-08-30"),
                    Genre = "Thriller",
                    Rating = "7.5",
                    Price = 2M
                },
                new Movie
                {
                    Title = "War",
                    ReleaseDate = DateTime.Parse("2019-10-02"),
                    Genre = "Action/Thriller",
                    Rating = "5",
                    Price = 5M
                }
            );
            context.SaveChanges();
        }
    }
}