using System;
using System.Collections.Generic;

namespace IntroToAlgorithms.Algorithms.Insertion.Modules
{
    public class InsertionSortModule
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

        public List<int> ExecuteInsertionSort(List<int> inputList, bool isNonIncreasingOrder = false)
        {
            List<int> outputList = new List<int>(inputList);

            Utils.PrintResult(outputList);

            for (int startingIndex = 1; startingIndex < outputList.Count; startingIndex++)
            {
                int referenceValue = inputList[startingIndex];
                int previousIndex = startingIndex - 1;

                while (previousIndex > -1 && ValuesComparator(outputList[previousIndex], referenceValue, isNonIncreasingOrder))
                {
                    var valueToShiftRight = outputList[previousIndex];

                    outputList[previousIndex + 1] = valueToShiftRight;
                    previousIndex = previousIndex - 1;
                }


                outputList[previousIndex + 1] = referenceValue;
                Utils.PrintResult(outputList);
            }

            Console.WriteLine("Sort successful.");

            return outputList;
        }

        public void RunInsertionSortApplication()
        {
            Console.WriteLine("\nPlease enter some integers separated by comma.");

            List<int> inputList = Utils.GetParsedListFromUserInput();

            Console.WriteLine("\nYour input was parsed into the following array:");

            Utils.PrintResult(inputList);

            bool isNonIncreasingOrderSelected = Utils.GetSortingOrderFromUser() == "2";

            string selectedOrderText = isNonIncreasingOrderSelected ? "Nonincreasing" : "Nondecreasing";

            Console.WriteLine($"\nExecuting {selectedOrderText} Insertion sort.\n");

            List<int> outputList = ExecuteInsertionSort(inputList, isNonIncreasingOrderSelected);

            Console.WriteLine("\nResults:");

            Utils.PrintResult(inputList, outputList);
        }
    }
}
