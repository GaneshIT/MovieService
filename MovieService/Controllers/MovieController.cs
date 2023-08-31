using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieEntity;
using MovieEntity.Repositories;

namespace MovieService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
       private readonly IMovieRepository _movierepo;
        public MovieController(IMovieRepository movieRepository) 
        {
            _movierepo = movieRepository;
        }
        [HttpPost]
        public IActionResult AddMovie(MovieModel movie) 
        {
            string result=_movierepo.AddMovie(movie);
            return Ok(result);
        }
        [HttpGet]
        public IActionResult GetMovies()
        {
            var result = _movierepo.GetAll();
            return Ok(result);
        }
    }
}
