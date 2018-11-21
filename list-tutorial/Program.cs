using System;
using System.Collections.Generic;

namespace list_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lists are very useful as they can grow or shring
            var names = new List<string> { "La Pinta", "La Nina", "La Santa Maria" };
    
            names.Add("Battlestar Gallactica");
            names.Remove("La Nina");
            
            int counter = 1;
            foreach (var name in names)
            {
                Console.WriteLine($"Ship #{counter}: {name.ToUpper()}!");
                counter ++;
            }


        }
    }
}
