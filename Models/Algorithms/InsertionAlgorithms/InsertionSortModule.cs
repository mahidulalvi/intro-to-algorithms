using System;
using System.Collections.Generic;

namespace IntroToAlgorithms.Models.Algorithms.InsertionAlgorithms
{
    class InsertionSortModule
    {
        public Utils Utils { get; set; }
        public InsertionSortModule()
        {
            Utils = new Utils();
        }

        private bool ValuesComparator(int comparingValue, int referenceValue, bool nonIncreasingOrder)
        {
            if (!nonIncreasingOrder)
            {
                return comparingValue > referenceValue;
            }
            else
            {
                return comparingValue < referenceValue;
            }
        }

        public string GetSortingOrderFromUser()
        {
            Console.WriteLine("\nPlease select the order of sorting.\nPress 1 for nondecreasing or 2 for nonincreasing order.");

            string insertionSortOrder = Console.ReadLine();

            return insertionSortOrder;
        }

        public List<int> ExecuteInsertionSort(List<int> inputList, bool isNonIncreasingOrder = false)
        {
            List<int> OutputList = new List<int>(inputList);

            Utils.PrintResult(OutputList);

            for (int startingIndex = 1; startingIndex < OutputList.Count; startingIndex++)
            {
                int referenceValue = inputList[startingIndex];
                int previousIndex = startingIndex - 1;

                while (previousIndex > -1 && ValuesComparator(OutputList[previousIndex], referenceValue, isNonIncreasingOrder))
                {
                    var valueToShiftRight = OutputList[previousIndex];

                    OutputList[previousIndex + 1] = valueToShiftRight;
                    previousIndex = previousIndex - 1;
                }


                OutputList[previousIndex + 1] = referenceValue;
                Utils.PrintResult(OutputList);
            }

            Console.WriteLine("Sort successful.");

            return OutputList;
        }

        public void RunInsertionSortApplication()
        {
            Console.WriteLine("\nPlease enter some integers separated by comma.");

            List<int> inputList = Utils.GetParsedListFromUserInput();

            Console.WriteLine("\nYour input was parsed into the following array:");

            Utils.PrintResult(inputList);

            bool isNonIncreasingOrderSelected = GetSortingOrderFromUser() == "2";

            string selectedOrderText = isNonIncreasingOrderSelected ? "Nonincreasing" : "Nondecreasing";

            Console.WriteLine($"\nExecuting {selectedOrderText} Insertion sort.\n");

            List<int> outputList = ExecuteInsertionSort(inputList, isNonIncreasingOrderSelected);

            Console.WriteLine("\nResults:");

            Utils.PrintResult(inputList, outputList);
        }
    }
}
