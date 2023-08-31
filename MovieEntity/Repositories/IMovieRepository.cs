using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEntity.Repositories
{
    //DI(Dependency Injection) design patter
    public interface IMovieRepository
    {
        string AddMovie(MovieModel movie);
        string UpdateMovie(MovieModel movie);
        string DeleteMovieById(int id);
        void DeleteAll();
        MovieModel GetMovieById(int id);
        List<MovieModel> GetAll();

    }
}
