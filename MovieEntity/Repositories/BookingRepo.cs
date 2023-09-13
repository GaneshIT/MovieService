using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEntity.Repositories
{
    public class BookingRepo:IBookingRepo
    {
        private readonly MovieDbContext _db;
        public BookingRepo(MovieDbContext movieDbContext)
        {
            _db = movieDbContext;
        }
        public object AddBooking(BookingModel booking)
        {
            _db.booking.Add(booking);//insert statment created
            _db.SaveChanges();// executed
            return "Inserted";
        }

    }
}
