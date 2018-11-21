using System;
using System.Collections.Generic;

namespace list_tutorial
{
    class Program
    {

        static void Main(string[] args)
        {
            WorkingWithShips();
        }


        public static void WorkingWithShips()
        {
            // Lists are very useful as they can grow or shring
            var ships = new List<string> { "La Pinta", "La Nina", "La Santa Maria" };
    
            ships.Add("Battlestar Gallactica");
            ships.Remove("La Nina");
            
            int counter = 1;
            foreach (var ship in ships)
            {
                Console.WriteLine($"Ship #{counter}: {ship.ToUpper()}!");
                counter ++;
            }

            // We can access list elements by referencing their index.
            Console.WriteLine($"My favourite ship is {ships[0]}");
            Console.WriteLine($"But {ships[2]} is also pretty cool");
            Console.WriteLine($"The list has {ships.Count} ships in it");


            //We can use IndexOf to search for a particular item. 
            var index = ships.IndexOf("La Pinta");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            } else
            {
                Console.WriteLine($"The ship {ships[index]} is at index {index}");
            }

            index = ships.IndexOf("Not Found");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            } else
            {
                Console.WriteLine($"The ship {ships[index]} is at index {index}");

            }

            //And we can also Sort our list
            ships.Sort();
            foreach (var ship in ships)
            {
                Console.WriteLine($"Hello {ship.ToUpper()}!");
            }
        }

    }
}
