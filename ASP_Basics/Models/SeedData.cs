using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ASP_Basics.Data;
using System;
using System.Linq;

namespace ASP_Basics.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ASP_BasicsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ASP_BasicsContext>>()))
            {
                //look for any movies

                if(context.Movie.Any())
                {
                    return; //DB has been seeded
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Lord of the Rings: The Fellowship of the Ring",
                        ReleaseDate = DateTime.Parse("2001-2-12"),
                        Genre = "Fantasy Epic",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Serenity",
                        ReleaseDate = DateTime.Parse("2005-9-30"),
                        Genre = "Space Western",
                        Price = 3.99M
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
