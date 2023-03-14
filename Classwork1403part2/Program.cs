namespace Classwork1403part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICountry icountry = new Country("Armenia");

            icountry.PrintPopulation();


        }
    }
}