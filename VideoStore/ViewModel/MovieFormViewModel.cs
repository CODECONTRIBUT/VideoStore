using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VideoStore.Models;

namespace VideoStore.ViewModel
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        //create pure viewModel, for removing default values of ReleaseDate and NumberInStock in Views.
        public int? Id { get; set; }

        [Required(ErrorMessage ="Please enter a name.")]
        public string Name { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage = "Please choose a genre type.")]
        public Byte? GenreId { get; set; }

        [Display(Name = "Released Date")]
        [Required(ErrorMessage = "Please enter a released date.")]
        public DateTime? ReleasedDate { get; set; }

        [Range(1, 20)]
        [Display(Name = "Number in Stock")]
        [Required(ErrorMessage = "Please enter numbers in stock.")]
        public int? NumberInStock { get; set; }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            GenreId = movie.GenreId;
            ReleasedDate = movie.ReleasedDate;
            NumberInStock = movie.NumberInStock;
        }

        public string Title
        {
            get
            {
                if ((Id != 0))
                        return "Edit Movie";

                return "New Movie";
            }
        }
    }
}