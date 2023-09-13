using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEntity
{
    public class BookingModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime BookingDate { get; set; }

        [ForeignKey("movie")]
        public int MovieId { get; set; }
        public MovieModel movie { get; set; }

        [ForeignKey("user")]
        public int UserId { get; set; }
        public UserModel user { get; set; }
        public string BookingStatus { get; set; }
        //create table bookingmodel(id int primary key,
        //bookingdate date,movieid int references movie(movieid))
    }
}
