using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReviewDate { get; set; }
        public int MovieId { get; set; }

        [ForeignKey("MovieId")]
        public virtual Movie Movie { get; set; }


    }
}