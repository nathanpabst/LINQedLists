using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQedLists
{
    class Program
    {
        static void Main(string[] args)
        {



            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            var LFruits = from fruit in fruits
                          where fruit.Contains("L") == true
                          select fruit;
            Console.WriteLine(string.Join(", ", LFruits));
            //foreach (var ellls in LFruits)
            //{

            //}

            Console.Read();
                        

        }
    }

    
}
