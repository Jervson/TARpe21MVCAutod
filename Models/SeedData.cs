using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCAutod.Data;
using MVCAutod.Models;
using System;
using System.Linq;

namespace MvcAutod.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCAutodContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MVCAutodContext>>()))
            {

                if (context.Auto.Any())
                {
                    return;  
                }

                context.Auto.AddRange(
                    new Auto
                    {
                        Model = "R8",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Brand = "Audi",
                        Rating = 4,
                        Price = 70000
                    },

                    new Auto
                    {
                        Model = "Golf mk2 ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Brand = "Volkswagen",
                        Rating = 4,
                        Price = 800
                    },

                    new Auto
                    {
                        Model = "sf90",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Brand = "Ferrari",
                        Rating = 4,
                        Price = 120000
                    },

                    new Auto
                    {
                        Model = "i10",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Brand = "Hyundai",
                        Rating = 4,
                        Price = 3000
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
