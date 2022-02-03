using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Joel_Hilton_Film_Collection.Models
{
    public class EnterMovies
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required(ErrorMessage ="Please enter the movie name")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Please enter a category")]
        public int CategoryID { get; set; }
        public Categories Category { get; set; }
        [Required(ErrorMessage ="Please enter the year the movie came out")]
        public int Year { get; set; }
        [Required(ErrorMessage ="Please Enter a Directors Name")]
        public string Director { get; set; }
        [Required(ErrorMessage ="Please enter a rating")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public bool LentTo { get; set; }
        public string Notes { get; set; }

    }
}