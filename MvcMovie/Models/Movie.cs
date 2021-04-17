using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class Movie
    {
        public Movie()
        {
            this.Reviews = new HashSet<Review>();
        }
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public int Rating { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }

    }
}