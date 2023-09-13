using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieEntity.Repositories;
using MovieEntity;

namespace MovieService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingRepo _bookingrepo;
        public BookingController(IBookingRepo booking)
        {
            _bookingrepo = booking;
        }

        [HttpPost("AddBooking")]
        public IActionResult AddBooking(BookingModel booking)
        {
            object result;
            List<object> list = new List<object>();
            try
            {
                result = _bookingrepo.AddBooking(booking);
                list.Add(result);
            }
            catch (Exception ex)
            {
                return BadRequest();///400
            }
            return Ok(list);//200
        }
    }
}
