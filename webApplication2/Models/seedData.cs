using Microsoft.EntityFrameworkCore;
using webApplication2.Data;

namespace webApplication2.Models
{
    public class seedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new webApplication2Context(
                serviceProvider.GetRequiredService<DbContextOptions<webApplication2Context>>()))
            {
                if (context == null || context.Movie == null)
                {
                    if (context == null || context.Movie == null)
                    {
                        throw new ArgumentException("Null webApplication2Context");
                    }
                    if (context.Movie.Any())
                    {
                        return;
                    }
                    context.Movie.AddRange(
                        new Movie
                        {
                            Title = "Jay and Silent Bob Strike Back",
                            ReleaseDate = DateTime.Parse("08-24-2001"),
                            Genre = "Comedy",
                            Price = 9.99M,
                            Rating ="R"
                        },

                         new Movie
                         {
                             Title = "Hacksaw Ridge",
                             ReleaseDate = DateTime.Parse("11-04-2016"),
                             Genre = "Drama",
                             Price = 4.99M,
                             Rating= "PG-13"
                         },
                          new Movie
                          {
                              Title = "Naruto the Movie: Guardians of the Crescent Moon Kingdom",
                              ReleaseDate = DateTime.Parse("08-05-2006"),
                              Genre = "Anime",
                              Price = 9.99M,
                              Rating="PG"
                          }
                        );
                    context.SaveChanges();
                }
            }
        }
    }
}
