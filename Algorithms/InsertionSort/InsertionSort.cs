using System;
using System.Collections.Generic;
using System.Text;

namespace intro_to_algorithms_practice.Algorithms.InsertionSort
{
    class InsertionSort
    {
        public List<int> InputList { get; set; }
        public List<int> OutputList { get; set; }

        public InsertionSort()
        {
            InputList = new List<int>() { 5, 2, 4, 6, 1, 3 };
        }

        public void PrintStates()
        {
            Console.WriteLine(String.Join(", ", InputList));

            if (OutputList != null && OutputList.Count > 0)
            {
                Console.WriteLine(String.Join(", ", OutputList));
            }
            else
            {
                Console.WriteLine("Sort incomplete.");
            }
        }

        public void ExecuteInsertionSort()
        {
            OutputList = new List<int>(InputList);

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
        }
    }
}
