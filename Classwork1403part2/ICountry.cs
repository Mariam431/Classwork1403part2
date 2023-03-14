using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork1403part2
{
    internal interface ICountry
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int Population { get; set; }
        public double Area { get; set; }

        public void PrintPopulation(int p = 0)
        {
            Population += ++p;
            Console.WriteLine(Population);
        }
    }
}
