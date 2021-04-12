using System;
using System.Collections.Generic;
using System.Linq;

namespace IntroToAlgorithms.Models.Algorithms.InsertionSort
{
    class InsertionSort
    {
        public InsertionSort() { }

        public void Initialize()
        {
            Console.WriteLine("\nPlease select an application.");
            Console.WriteLine("1. Insertion Sort");
            Console.WriteLine("2. Linear Search\n");

            string selectedApplication = Console.ReadLine();

            if (selectedApplication == "1")
            {
                RunInsertionSortApplication();
            }
            else if (selectedApplication == "2")
            {
                RunLinearSearchApplication();
            }
        }

        public void RunLinearSearchApplication()
        {
            Console.WriteLine("\nPlease enter the integers separated by comma to form the array of searching.");

            List<int> inputList = GetParsedListFromUserInput();

            Console.WriteLine("\nYour input was parsed into the following array:");

            PrintResult(inputList);

            Console.WriteLine("\nPlease enter the value to search for.");

            string valueToSearchUserInput = Console.ReadLine();

            int valueToSearch = Convert.ToInt32(valueToSearchUserInput);

            Console.WriteLine($"\nExecuting Linear Search to find the zero-based index of {valueToSearch}.\n");

            int? indexOfValueToSearch = ExecuteLinearSearch(inputList, valueToSearch);

            string result = indexOfValueToSearch == null ? "NIL" : Convert.ToString(indexOfValueToSearch);

            Console.WriteLine($"\nResult: {result}");
        }

        public void RunInsertionSortApplication()
        {
            Console.WriteLine("\nPlease enter some integers separated by comma.");

            List<int> inputList = GetParsedListFromUserInput();

            Console.WriteLine("\nYour input was parsed into the following array:");

            PrintResult(inputList);

            bool isNonIncreasingOrderSelected = GetSortingOrderFromUser();

            string selectedOrderText = isNonIncreasingOrderSelected ? "Nonincreasing" : "Nondecreasing";

            Console.WriteLine($"\nExecuting {selectedOrderText} Insertion sort.\n");

            List<int> outputList = ExecuteInsertionSort(inputList, isNonIncreasingOrderSelected);

            Console.WriteLine("\nResults:");

            PrintResult(inputList, outputList);
        }

        public void PrintResult(List<int> inputList, List<int> outputList = null)
        {
            Console.WriteLine("[{0}]", String.Join(", ", inputList));

            if (outputList != null && outputList.Count > 0)
            {
                Console.WriteLine("[{0}]", String.Join(", ", outputList));
            }
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

        public bool GetSortingOrderFromUser()
        {
            Console.WriteLine("\nPlease select the order of sorting.\nPress 1 for nondecreasing or 2 for nonincreasing order.");

            string insertionSortOrder = Console.ReadLine();

            return insertionSortOrder == "2";
        }

        public List<int> GetParsedListFromUserInput()
        {
            string userInput = Console.ReadLine();
            string[] parsedUserInputArray = userInput.Trim().Replace(" ", String.Empty).Split(',');

            List<int> parsedUserInputList = parsedUserInputArray.Select(element => Convert.ToInt32(element)).ToList();

            return parsedUserInputList;
        }

        public List<int> ExecuteInsertionSort(List<int> inputList, bool isNonIncreasingOrder = false)
        {
            List<int> OutputList = new List<int>(inputList);

            PrintResult(OutputList);

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
                PrintResult(OutputList);
            }

            Console.WriteLine("Sort successful.");

            return OutputList;
        }

        public int? ExecuteLinearSearch(List<int> inputList, int valueToSearch)
        {
            int? resultIndex = null;

            for (int index = 0; index < inputList.Count; index++)
            {
                int referenceValue = inputList[index];
                
                if (referenceValue == valueToSearch)
                {
                    resultIndex = index;
                    break;
                }
            }

            Console.WriteLine("Linear Search successful.");

            return resultIndex;
        }
    }
}
