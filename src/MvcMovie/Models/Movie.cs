using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name = "Release Date")]  
        [DataType(DataType.Date)]  //creates calendar
        public DateTime ReleaseDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\-0-9\s]*$")] 
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        [Range(1,100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\-0-9\s]*$")]  //changed to accept PG-13
        [StringLength(5)]
        public string Rating { get; set; }

        public string Opinion { get; set; }
        
    }
}
