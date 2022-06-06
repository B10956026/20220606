using _20220606.Service;
using Microsoft.AspNetCore.Mvc;

namespace _20220606.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        
        public IActionResult Index()
        {
            var movieList = _movieService.GetMovies();
            return View(movieList);
        }
    }
}
