using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Services;

namespace PL
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UniverseService universe = new UniverseService())
            {
                universe.AddPlanet("Earth", "Milky Way");
                foreach (var galaxy in universe.GetGalaxies())
                {
                    Console.WriteLine($"{galaxy.Name}");
                    foreach (var planet in universe.GetPlanets(galaxy.Name))
                    {
                        Console.WriteLine($"{galaxy.Name} / {planet.Name}");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
