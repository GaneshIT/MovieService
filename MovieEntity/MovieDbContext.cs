using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEntity
{
    public class MovieDbContext:DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options) 
        {
        }
        public DbSet<MovieModel> movie { get; set; }
        public DbSet<BookingModel> booking { get; set; }
        public DbSet<UserModel> user { get; set; }
    }
}
