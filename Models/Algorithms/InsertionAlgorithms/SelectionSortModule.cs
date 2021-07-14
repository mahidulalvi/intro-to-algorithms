using System;
using System.Collections.Generic;

namespace IntroToAlgorithms.Models.Algorithms.InsertionAlgorithms
{
    class SelectionSortModule
    {
        public Utils Utils { get; set; }
        public SelectionSortModule()
        {
            Utils = new Utils();
        }

        private bool ValuesComparator(int comparingValue, int referenceValue, bool nonIncreasingOrder)
        {
            if (!nonIncreasingOrder)
            {
                return comparingValue < referenceValue;
            }
            else
            {
                return comparingValue > referenceValue;
            }
        }

        public List<int> ExecuteSelectionSort(List<int> inputList, bool isNonIncreasingOrder = false)
        {
            List<int> outputList = new List<int>(inputList);

            Utils.PrintResult(outputList);

            for (int startingIndex = 0; startingIndex < outputList.Count; startingIndex++)
            {
                int smallestValue = outputList[startingIndex];
                int smallestValueIndex = startingIndex;
                int nextIndex = startingIndex + 1;

                for (int innerStartingIndex = nextIndex; innerStartingIndex < outputList.Count; innerStartingIndex++)
                {
                    int nextValue = outputList[nextIndex];
                    
                    if (ValuesComparator(nextValue, smallestValue, isNonIncreasingOrder))
                    {
                        smallestValue = nextValue;
                        smallestValueIndex = nextIndex;
                    }

                    nextIndex++;
                }

                outputList.RemoveAt(smallestValueIndex);
                outputList.Insert(startingIndex, smallestValue);
                Utils.PrintResult(outputList);
            }

            Console.WriteLine("Selection sort successful.");

            return outputList;
        }

        public void RunSelectionSortApplication()
        {
            Console.WriteLine("\nPlease enter some integers separated by comma.");

            List<int> inputList = Utils.GetParsedListFromUserInput();

            Console.WriteLine("\nYour input was parsed into the following array:");

            Utils.PrintResult(inputList);

            bool isNonIncreasingOrderSelected = Utils.GetSortingOrderFromUser() == "2";

            string selectedOrderText = isNonIncreasingOrderSelected ? "Nonincreasing" : "Nondecreasing";

            Console.WriteLine($"\nExecuting {selectedOrderText} Selection sort.\n");

            List<int> outputList = ExecuteSelectionSort(inputList, isNonIncreasingOrderSelected);

            Console.WriteLine("\nResults:");

            Utils.PrintResult(inputList, outputList);
        }
    }
}
