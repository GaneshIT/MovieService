using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEntity.Repositories
{
    public interface IBookingRepo
    {
        object AddBooking(BookingModel booking);
    }
}
