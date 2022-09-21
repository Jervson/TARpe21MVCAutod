using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCAutod.Data;
using MVCAutod.Models;
using System;
using System.Linq;

namespace MvcMovie.Models
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
                        Model = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Brand = "Romantic Comedy",
                        Price = 7.99M
                    },

                    new Auto
                    {
                        Model = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Brand = "Comedy",
                        Price = 8.99M
                    },

                    new Auto
                    {
                        Model = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Brand = "Comedy",
                        Price = 9.99M
                    },

                    new Auto
                    {
                        Model = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Brand = "Western",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
