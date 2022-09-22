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
                        Price = 7.99M
                    },

                    new Auto
                    {
                        Model = "Golf mk2 ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Brand = "Volkswagen",
                        Price = 8.99M
                    },

                    new Auto
                    {
                        Model = "sf90",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Brand = "Ferrari",
                        Price = 9.99M
                    },

                    new Auto
                    {
                        Model = "i10",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Brand = "Hyundai",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
