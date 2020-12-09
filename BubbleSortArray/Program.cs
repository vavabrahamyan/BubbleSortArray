using System;

namespace BubbleSortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The 5 planets closest to the sun, in order: ");
            string[] planets =
              new string[] { "Mercury", "Venus", "Earth", "Mars", "Jupiter" };

            foreach (string planet in planets)
            {
                Console.WriteLine("\t" + planet);
            }

            Console.WriteLine("\nNow listed alphabetically: ");

            string[] sortedNames = planets;
            Array.Sort(sortedNames);

            foreach (string planet in sortedNames)
            {
                Console.WriteLine("\t" + planet);
            }

            Console.WriteLine("\nList by name length - shortest first: ");

            
            int outer;  
            int inner;  

            for (outer = planets.Length - 1; outer >= 0; outer--)
            {

               
                for (inner = 1; inner <= outer; inner++)
                {

                    
                    if (planets[inner - 1].Length > planets[inner].Length)
                    {
                        string temp = planets[inner - 1];

                        planets[inner - 1] = planets[inner];

                        planets[inner] = temp;
                    }
                }
            }

            foreach (string planet in planets)
            {
                Console.WriteLine("\t" + planet);
            }

            Console.WriteLine("\nNow listed longest first: ");

            for (int i = planets.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("\t" + planets[i]);
            }

            Console.WriteLine("\nPress Enter to terminate...");
            Console.Read();
        }
    }
}
