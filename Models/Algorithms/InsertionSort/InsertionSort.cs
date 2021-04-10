using System;
using System.Collections.Generic;
using System.Text;

namespace intro_to_algorithms_practice.Models.Algorithms.InsertionSort
{
    class InsertionSort
    {
        public InsertionSort() {}

        public List<int> Execute(List<int> InputList)
        {
            List<int> OutputList = new List<int>(InputList);

            for (int startingIndex = 1; startingIndex < OutputList.Count; startingIndex++)
            {
                int referenceValue = InputList[startingIndex];
                int previousIndex = startingIndex - 1;

                while (previousIndex > -1 && OutputList[previousIndex] > referenceValue)
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
    }
}
