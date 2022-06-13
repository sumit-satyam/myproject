using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Actors { get; set; }
        public string Producer { get; set; }
        public string Director { get; set; }
        public string Summary { get; set; }
    }
}