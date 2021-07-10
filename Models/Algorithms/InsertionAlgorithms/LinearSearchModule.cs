using System;
using System.Collections.Generic;

namespace IntroToAlgorithms.Models.Algorithms.InsertionAlgorithms
{
    class LinearSearchModule
    {
        public Utils Utils { get; set; }
        public LinearSearchModule()
        {
            Utils = new Utils();
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

        public void RunLinearSearchApplication()
        {
            Console.WriteLine("\nPlease enter the integers separated by comma to form the array of searching.");

            List<int> inputList = Utils.GetParsedListFromUserInput();

            Console.WriteLine("\nYour input was parsed into the following array:");

            Utils.PrintResult(inputList);

            Console.WriteLine("\nPlease enter the value to search for.");

            string valueToSearchUserInput = Console.ReadLine();

            int valueToSearch = Convert.ToInt32(valueToSearchUserInput);

            Console.WriteLine($"\nExecuting Linear Search to find the zero-based index of {valueToSearch}.\n");

            int? indexOfValueToSearch = ExecuteLinearSearch(inputList, valueToSearch);

            string result = indexOfValueToSearch == null ? "NIL" : Convert.ToString(indexOfValueToSearch);

            Console.WriteLine($"\nResult: {result}");
        }
    }
}
