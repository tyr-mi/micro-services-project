using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using platformservice.Models;
using System;
using System.Linq;

namespace platformservice.Data
{
    public static class PrebDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            if (!context.Platforms.Any())
            {
                Console.WriteLine("Seeding data");

                context.Platforms.AddRange(
                    new Platform() { Name="Dot Net", Publisher="Microsoft", Cost="Free"},
                    new Platform() { Name="Sql Server Express", Publisher="Microsoft", Cost="Free"},
                    new Platform() { Name="Kubernetes", Publisher="Microsoft", Cost="Free"}
                );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("We already have data");
            }
        }
    }
}
