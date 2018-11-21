using System;
using System.Collections.Generic;

namespace list_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "La Pinta", "La nina", "La Santa Maria" };
            int counter = 1;
            foreach (var name in names)
            {
                Console.WriteLine($"Ship #{counter}: {name.ToUpper()}!");
                counter ++;
            }
        }
    }
}
