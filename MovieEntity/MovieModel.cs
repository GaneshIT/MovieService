﻿using System.ComponentModel.DataAnnotations;

namespace MovieEntity
{
    //TheatreModel
    //Id,name,address,city
    public class MovieModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
    }
}