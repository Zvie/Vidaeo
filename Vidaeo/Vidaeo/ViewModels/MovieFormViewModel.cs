using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using Vidaeo.Models;

namespace Vidaeo.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public int? Id { get; set; }

        [Required(ErrorMessage = "Please enter the movie's  Name.")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please select the Genre of the movie.")]
        [Display(Name = "Genre")]
        public byte? GenreId { get; set; }

        [Required(ErrorMessage = "Please specify the date the movie was added (mm/dd/yyy).")]
        public DateTime? DateAdded { get; set; }

        [Required(ErrorMessage = "Please specify the date the movie was released (mm/dd/yyy).")]
        public DateTime? ReleaseDate { get; set; }

        
        [Display(Name = "Number In Stock")]
        [Range(1, 50, ErrorMessage = "The field Number in Stock must be between 1 and 20.")]
        [Required]
        public byte? NumberInStock { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            DateAdded = movie.DateAdded;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }
}