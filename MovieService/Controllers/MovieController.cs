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
        private readonly ILogger<MovieController> logger;
        public MovieController(IMovieRepository movieRepository,ILogger<MovieController> logger1)
        {
            _movierepo = movieRepository;
            logger = logger1;
        }

        [HttpPost("AddMovie")]
        public IActionResult AddMovie(MovieModel movie)
        {
            object result;
            List<object> list = new List<object>();
            try
            {//it s not valid json
                logger.LogInformation("Entered");
                result = _movierepo.AddMovie(movie);
                logger.LogInformation("Completed");
                list.Add(result);
            }
            catch(Exception ex)
            {
                logger.LogError("Error" + ex.ToString());
                return BadRequest();///400
            }
            return Ok(list);//200
        }
        [HttpGet("GetAll")]
        public IActionResult GetMovies()
        {
            var result = _movierepo.GetAll();
            return Ok(result);
        }

        [HttpGet("GetMovieById")]
        public IActionResult GetMoveByid(int id)
        {
            if (id == 0)
                return BadRequest();
            object result = _movierepo.GetMovieById(id);
            return result != "" ? Ok(result) : NotFound();
        }
        [HttpPut]
        public IActionResult UpdateMovie(MovieModel movie)
        {
            List<object> result = new List<object>();
            object r=_movierepo.UpdateMovie(movie);
            result.Add(r);
            return Ok(result);
        }
        [HttpDelete]
        public IActionResult DeleteMovie(int id)
        {
            object result = _movierepo.DeleteMovieById(id);
            return Ok(result);
        }
    }
}
