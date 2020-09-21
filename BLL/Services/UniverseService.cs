using DAL.EF6.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF6.Models;

namespace BLL.Services
{
    public class UniverseService : IDisposable
    {
        private readonly TLAContext db = new TLAContext();

        public IEnumerable<Galaxy> GetGalaxies()
        {
            return db.Galaxies;
        }

        public IEnumerable<Planet> GetPlanets(string galaxyName)
        {
            return db.Planets.Where((p) => p.Galaxy.Name.Equals(galaxyName));
        }

        public Galaxy AddGalaxy(string name)
        {
            if (GetGalaxies().Any((g) => g.Name.Equals(name)))
            {
                return GetGalaxies().Where((g) => g.Name.Equals(name)).First();
            }
            else
            {
                var galaxy = new Galaxy { Name = name };
                db.Galaxies.Add(galaxy);
                db.SaveChanges();
                return galaxy;
            }
        }

        public Planet AddPlanet(string planetName, string galaxyName)
        {
            var galaxy = AddGalaxy(galaxyName);
            if (GetPlanets(galaxyName).Any((p) => p.Name.Equals(planetName)))
            {
                return GetPlanets(galaxyName).Where((p) => p.Name.Equals(planetName)).First();
            }
            else
            {
                var planet = new Planet {Galaxy = galaxy, Name = planetName};
                db.Planets.Add(planet);
                db.SaveChanges();
                return planet;
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
