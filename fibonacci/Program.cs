using System;
using System.Collections.Generic;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            getFibonacci(21);
        }

        public static void getFibonacci(int elements){
            var fibonacci = new List<int> {1, 1};
            while (fibonacci.Count<elements)
            {
                var previous = fibonacci[fibonacci.Count - 1];
                var previous2 = fibonacci[fibonacci.Count - 2];
                fibonacci.Add(previous + previous2);
            }        

            int counter = 1;
            foreach(var item in fibonacci){
                Console.WriteLine($"Fibonacci({counter}): {item}");
                counter++;
            }
        }


    }
}
