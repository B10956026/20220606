using Microsoft.EntityFrameworkCore;

namespace _20220606.Models.MovieDB
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
        }
        public DbSet<Movie> Movie { get; set; }
    }
}
