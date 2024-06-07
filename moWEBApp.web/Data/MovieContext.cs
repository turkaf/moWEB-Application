using Microsoft.EntityFrameworkCore;
using moWEBApp.web.Entity;

namespace moWEBApp.web.Data
{
	public class MovieContext: DbContext
	{
        public MovieContext(DbContextOptions<MovieContext> options):base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }
		public DbSet<Genre> Genres { get; set; }
	}
}