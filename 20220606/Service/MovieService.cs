using _20220606.Models.MovieDB;

namespace _20220606.Service
{
    public class MovieService : IMovieService
    {
        private readonly MovieContext _context;
        public MovieService(MovieContext context)
        {
            _context = context;
        }

        public List<Movie> GetMovies()
        {
            return _context.Movie.ToList();
        }
    }
}
