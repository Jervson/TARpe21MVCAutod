using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAutod.Models
{
    public class Auto
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Brand { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Range(1, 1000000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"[a-zA-Z0-9\s]+$")]
        [Required]
        [StringLength(30)]
        public string Model { get; set; }

        [Range(1, 10)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Rating { get; set; }
    }
}
