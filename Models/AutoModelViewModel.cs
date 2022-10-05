using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAutod.Models
{
    public class AutoModelViewModel
    {
        public List<Auto> Autos{ get; set; }
        public SelectList Brand{ get; set; }
        public string AutoBrand { get; set; }
        public string SearchString { get; set; }
    }
}
