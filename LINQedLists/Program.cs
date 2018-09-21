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

            //QUERY SYNTAX
            //var LFruits = from fruit in fruits
            //              where fruit.Contains("L") == true
            //              select fruit;

            //Console.WriteLine(string.Join(", ", LFruits));
            //Console.Read();
            //-------END E1-----------

            //Which of the following numbers are multiples of 4 or 6
            //List<int> numbers = new List<int>() { 15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96 };

            //QUERY SYNTAX
            //var fourSixMultiples =
            //    from number in numbers
            //    where (number % 4 == 0 || number % 6 == 0) == true
            //    select number;

            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(string.Join(", ", fourSixMultiples));
            //}

            //Console.Read();
            //-------------END E2-------------

            //ORDERING OPERATIONS
            //Order these student names alphabetically, in descending order(Z to A)

            //List<string> names = new List<string>()
            //{
            //    "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
            //    "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
            //    "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
            //    "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
            //    "Francisco", "Tre"
            //};

            //var sortList =
            //    from name in names
            //    orderby name descending
            //    select name;

            //foreach (string nombre in sortList)
            //{
            //    Console.WriteLine(nombre);
            //}

            //Console.Read();
            //----------------END E3--------------

            //Build a collection of these numbers sorted in ascending order

            //List<int> numbers = new List<int>()
            //{
            //    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            //};

            //var sortNums =
            //    from num in numbers
            //    orderby num ascending
            //    select num;

            //foreach (int digits in sortNums)
            //{
            //    Console.WriteLine(digits);
            //}

            //Console.Read();
            //------------END E4----------------

            //AGGREGATE OPERATIONS
            //Output how many numbers are in this list

            //List<int> numbers = new List<int>()
            //{
            //    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            //};

            //var getCount = numbers.Count();
            //    {
            //      Console.WriteLine($"{getCount} in the collection");
            //    }

            //Console.Read();
            //----------------END OF E5--------------

            //How much money have we made?
            //List<double> purchases = new List<double>()
            //{
            //    2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            //};
            //var cashInflow = purchases.Sum();
            //{
            //    Console.WriteLine($"{cashInflow}");
            //}

            //Console.Read();
            //------------END OF E6---------------

            //What is our most expensive product?
            //List<double> prices = new List<double>()
            //{
            //    879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            //};

            //var mostExpensive = prices.Max();
            //{
            //    Console.WriteLine($"our highest priced item is: {mostExpensive}");
            //}

            //Console.Read();
            //---------END E7--------------

            //        //PARTITIONING OPERATIONS 
            //          Store each number in the following List until a perfect square
            //is detected.

            //List<int> wheresSquaredo = new List<int>()
            //    {
            //        66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            //    };

            //List<int> findSquares = wheresSquaredo.Where(n => Math.Sqrt(n) % 1 == 0).ToList();
            //foreach (var num in findSquares)
            //{
            //    Console.WriteLine(num.ToString());
            //}

            //Console.Read();
            //------------END E8------------------

            // Build a collection of customers who are millionaires

            List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };

            var richPeeps = from cust in customers
                            where cust.Balance >= 1000000
                            select cust.Name;
            Console.WriteLine("Millionaires club:");
            Console.WriteLine(string.Join(", ", richPeeps));
            Console.WriteLine();

            //how many millionaires per bank?

            var millPerBank = customers.Where(c => c.Balance >= 1000000).GroupBy(
                c => c.Bank,
                c => c.Name
                ).ToList();


            Console.WriteLine("Millionaires per bank:");
            foreach (var cust in millPerBank)
            {
            Console.WriteLine();

            }
                
            Console.Read();


        }
        public class Customer
        {
            public string Name { get; set; }
            public double Balance { get; set; }
            public string Bank { get; set; }
        }
    }


    }

