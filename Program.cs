using IntroToAlgorithms.Models;
using System;

namespace IntroToAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's practise some algorithms!");

            var sort = new Sort();

            Console.WriteLine("\nPress 1 to select insertion sort.");

            var selectedAlgorithm = Console.ReadLine();

            if (selectedAlgorithm == "1")
            {
                sort.InsertionAlgorithms.Initialize();
            }

        }
    }
}
