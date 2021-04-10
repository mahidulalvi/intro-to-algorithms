using intro_to_algorithms_practice.Algorithms.InsertionSort;
using System;

namespace intro_to_algorithms_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's practise some algorithms!");

            var insertionSort = new InsertionSort();

            insertionSort.PrintStates();

            Console.WriteLine("Press 1 to execute insertion sort.");

            var startSorting = Console.ReadLine();

            if (startSorting == "1")
            {

                insertionSort.ExecuteInsertionSort();

                insertionSort.PrintStates();
            }

        }
    }
}
