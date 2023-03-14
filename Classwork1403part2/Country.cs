using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork1403part2
{
    internal class Country : ICountry
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int Population { get; set; } = 190000;
        public double Area { get; set; }
        public Country(string Location)
        {
            this.Location = Location;
            this.Name = Location;
            Console.WriteLine(Name);
        }
        public void PrintPopulationLocation()
        {
            Console.WriteLine(Location+Population);
        }
        

    }
}
