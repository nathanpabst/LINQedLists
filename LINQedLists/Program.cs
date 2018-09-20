using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //RESTRICTION/FILTERING OPERATIONS
            //Find the words in the collection that start with the letter 'L'
            //List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            //var LFruits = from fruit in fruits
            //              where fruit.Contains("L") == true
            //              select fruit;
            //Console.WriteLine(string.Join(", ", LFruits));

            //Console.Read();

            //__________________________
            //Which of the following numbers are multiples of 4 or 6

            List<int> numbers = new List<int>() { 15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96 };

            var fourSixMultiples =
                from number in numbers
                where (number % 2 == 0) == true
                select number;
            foreach (int num in numbers)
            {
                Console.WriteLine(string.Join(", ", fourSixMultiples));
            }

            Console.Read();
        }
    }

    
}
