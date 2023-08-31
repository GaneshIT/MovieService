using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEntity.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieDbContext _db;
        public MovieRepository(MovieDbContext movieDbContext)
        {
            _db = movieDbContext;
        }
        public string AddMovie(MovieModel movie)
        {
            _db.movie.Add(movie);//insert statment created
            _db.SaveChanges();// executed
            return "Inserted";
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public string DeleteMovieById(int id)
        {   //select * from movie where id=value;
            var movie = _db.movie.Find(id);
            //delete from movie where id=movieid;
            _db.movie.Remove(movie);
            _db.SaveChanges();
            return "Deleted";
        }

        public List<MovieModel> GetAll()
        {
            var movielist = _db.movie.ToList(); //select * from movie
            return movielist;
        }

        public MovieModel GetMovieById(int id)
        {
            MovieModel movie = _db.movie.Find(id);
            return movie;
        }

        public string UpdateMovie(MovieModel movie)
        {
            _db.Entry(movie).State=EntityState.Modified;//update statment
            _db.SaveChanges();//execute statment
            return "Updated";
        }
    }
}
