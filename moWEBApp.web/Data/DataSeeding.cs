using Microsoft.EntityFrameworkCore;
using moWEBApp.web.Entity;

namespace moWEBApp.web.Data
{
	public static class DataSeeding
	{
		public static void Seed(IApplicationBuilder app)
		{
			var scope = app.ApplicationServices.CreateScope();
			var context = scope.ServiceProvider.GetService<MovieContext>();

			context.Database.Migrate();

			if(context.Database.GetPendingMigrations().Count() == 0)
			{
				if(context.Movies.Count() == 0)
				{
					context.Movies.AddRange(
						new List<Movie>()
						{
							new Movie
							{
								Title = "Dunki",
								Description = "Four friends from a village in Punjab share a common dream: to go to England. Their problem is that they have neither the visa nor the ticket. A soldier promises to take them to the land of their dreams.",
								Director = "Rajkumar Hirani",
								StartDate = DateTime.Now,
								EndDate = DateTime.Now,
								ImageUrl = "dunki.jpg",
								GenreId = 3,
								TrailerLink = "https://www.youtube.com/watch?v=uOlDK7g7b-E"
							},

							new Movie
							{
								Title = "Reacher",
								Description = "Itinerant former military policeman Jack Reacher solves crimes and metes out his own brand of street justice. Based on the books by Lee Child.",
								Director = "Nick Santora",
								StartDate = DateTime.Now,
								EndDate = DateTime.Now,
								ImageUrl = "reacher.jpg" ,
								GenreId = 1,
								TrailerLink = "https://www.youtube.com/watch?v=tC-rRhQcnlI"
							},

							new Movie
							{
								Title = "Succession",
								Description = "The Roy family is known for controlling the biggest media and entertainment company in the world. However, their world changes when their father steps down from the company.",
								Director = "Jesse Armstrong",
								StartDate = DateTime.Now,
								EndDate = DateTime.Now,
								ImageUrl = "succession.jpg" ,
								GenreId = 2,
								TrailerLink = "https://www.youtube.com/watch?v=t3D3ewle7XY"
							},

							new Movie
							{
								Title = "Law & Order: Special Victims Unit",
								Description = "This series follows the Special Victims Unit, a specially trained squad of detectives in the New York City Police Department that investigate sexually related crimes.",
								Director = "Dick Wolf",
								StartDate = DateTime.Now,
								EndDate = DateTime.Now,
								ImageUrl = "lawOrder.jpg",
								GenreId = 2,
								TrailerLink = "https://www.youtube.com/watch?v=O53wYUc_fA4"
							},

							new Movie
							{
								Title = "Gen V",
								Description = "From the world of \"The Boys\" comes \"Gen V,\" which explores the first generation of superheroes to know that their super powers are from Compound V. These heroes put their physical and moral boundaries to the test competing for the school's top ranking.",
								Director = "Craig Rosenberg",
								StartDate = DateTime.Now,
								EndDate = DateTime.Now,
								ImageUrl = "gen.jpg",
								GenreId = 3,
								TrailerLink = "https://www.youtube.com/watch?v=mmkLMXN_lpI"
							},

							new Movie
							{
								Title = "Fallout",
								Description = "In a future, post-apocalyptic Los Angeles brought about by nuclear decimation, citizens must live in underground bunkers to protect themselves from radiation, mutants and bandits.",
								Director = "Geneva Robertson-Dworet",
								StartDate = DateTime.Now,
								EndDate = DateTime.Now,
								ImageUrl = "fall.jpg",
								GenreId = 1,
								TrailerLink = "https://www.youtube.com/watch?v=jfZfhpNUkGE"
							}
						}
					);
				}

				if(context.Genres.Count() == 0)
				{
					context.Genres.AddRange(
						new List<Genre>()
						{
							new Genre {Name = "Action" },
							new Genre {Name = "Drama" },
							new Genre {Name = "Comedy" },
							new Genre {Name = "War" },
							new Genre {Name = "Science Fiction" },
							new Genre {Name = "Romantic"}
						}
					);
				}

				context.SaveChanges();
			}
		}
	}
}
