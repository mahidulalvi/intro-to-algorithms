using intro_to_algorithms_practice.Models;
using System;
using System.Collections.Generic;

namespace intro_to_algorithms_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's practise some algorithms!");

            var sort = new Sort();

            Console.WriteLine("\nPlease enter some integers separated by comma.");

            List<int> inputList = sort.GetParsedUserInput();

            Console.WriteLine("\nYour input was parsed into the following array:");
            
            sort.PrintResult(inputList);

            Console.WriteLine("\nPress 1 to select insertion sort.");

            var startSorting = Console.ReadLine();

            if (startSorting == "1")
            {
                bool isNonIncreasingOrderSelected = sort.InsertionSort.GetSortingOrderFromUser();

                string selectedOrderText = isNonIncreasingOrderSelected ? "Nonincreasing" : "Nondecreasing";

                Console.WriteLine($"\n{selectedOrderText} insertion method selected.\n");

                List<int> outputList = sort.InsertionSort.Execute(inputList, isNonIncreasingOrderSelected);

                Console.WriteLine("\nResults:");

                sort.PrintResult(inputList, outputList);
            }

        }
    }
}
