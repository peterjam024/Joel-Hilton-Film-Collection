using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Joel_Hilton_Film_Collection.Models
{
    public class Categories
    {
        [Key]
        [Required]
        public int CategoryID { get; set; }
        public string Category { get; set; }
    }
}
