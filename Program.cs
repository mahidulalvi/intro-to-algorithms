using intro_to_algorithms_practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace intro_to_algorithms_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's practise some algorithms!");

            var sort = new Sort();

            Console.WriteLine("Press 1 to execute insertion sort.");

            var startSorting = Console.ReadLine();

            if (startSorting == "1")
            {
                Console.WriteLine("Insertion sort selected.");
                Console.WriteLine("Please enter some numbers separated by comma.");

                string userInput = Console.ReadLine();
                string[] userInputArray = userInput.Trim().Replace(" ", String.Empty).Split(',');

                List<int> inputList = userInputArray.Select(element => Convert.ToInt32(element)).ToList();

                List<int> outputList = sort.InsertionSort.Execute(inputList);

                sort.PrintResult(inputList, outputList);
            }

        }
    }
}
