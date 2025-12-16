using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Single_Dimensional_Array_in_Procedural_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cities = new string[5];

            Console.WriteLine("Enter at least 5  Name of Cities in Cebu.\n");

            // INPUT USING FOR LOOP
            for (int x = 0; x < cities.Length; x++)
            {
                Console.Write("Enter city name {0} : " , x +1);
                cities[x] = Console.ReadLine(); 
            }

            Array.Sort(cities);

            Console.WriteLine("\n === The cities in alphabetical order are: ===");

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

            Console.ReadKey();
            
        }
        
    }
}
