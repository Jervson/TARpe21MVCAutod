using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCAutod.Models;

namespace MVCAutod.Data
{
    public class MVCAutodContext : DbContext
    {
        public MVCAutodContext (DbContextOptions<MVCAutodContext> options)
            : base(options)
        {
        }

        public DbSet<MVCAutod.Models.Auto> Auto { get; set; }
    }
}
