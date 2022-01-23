using platformservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace platformservice.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _context;

        public PlatformRepo(AppDbContext context)
        {
            _context = context;
        }

        public void CreatePlatfrom(Platform plat)
        {
            if (plat == null)
            {
                throw new ArgumentNullException();
            }

            _context.Platforms.Add(plat);
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _context.Platforms.ToList();
        }

        public Platform GetPlatfromById(int Id)
        {
            return _context.Platforms.FirstOrDefault(p => p.Id == Id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }

    }
}
