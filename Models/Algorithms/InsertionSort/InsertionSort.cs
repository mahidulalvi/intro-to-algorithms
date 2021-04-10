using System;
using System.Collections.Generic;

namespace intro_to_algorithms_practice.Models.Algorithms.InsertionSort
{
    class InsertionSort
    {
        public InsertionSort() {}

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

        public List<int> Execute(List<int> InputList, bool isNonIncreasingOrder = false)
        {
            List<int> OutputList = new List<int>(InputList);

            for (int startingIndex = 1; startingIndex < OutputList.Count; startingIndex++)
            {
                int referenceValue = InputList[startingIndex];
                int previousIndex = startingIndex - 1;

                while (previousIndex > -1 && ValuesComparator(OutputList[previousIndex], referenceValue, isNonIncreasingOrder))
                {
                    var valueToShiftRight = OutputList[previousIndex];

                    OutputList[previousIndex + 1] = valueToShiftRight;
                    previousIndex = previousIndex - 1;
                }


                OutputList[previousIndex + 1] = referenceValue;
            }

            Console.WriteLine("Sort successful.");

            return OutputList;
        }

        public bool GetSortingOrderFromUser()
        {
            Console.WriteLine("\nPlease select the order of sorting.\nPress 1 for nondecreasing or 2 for nonincreasing order.");

            string insertionSortOrder = Console.ReadLine();
            
            return insertionSortOrder == "2";
        }
    }
}
