using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAutod.Models
{
    public class Auto
    {
        public int Id { get; set; }
        public string Model { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
    }
}
