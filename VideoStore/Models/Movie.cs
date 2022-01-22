using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoStore.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public Genre Genres { get; set; }

        [Display(Name="Genre")]
        [Required]
        public Byte GenreId { get; set; }

        [Display(Name="Released Date")]
        public DateTime ReleasedDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Range(1, 20)]
        [Display(Name="Number in Stock")]
        public int NumberInStock { get; set; }
    }
}