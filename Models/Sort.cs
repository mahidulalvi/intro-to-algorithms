using intro_to_algorithms_practice.Models.Algorithms.InsertionSort;
using System;
using System.Collections.Generic;
using System.Text;

namespace intro_to_algorithms_practice.Models
{
    class Sort
    {
        public InsertionSort InsertionSort { get; set; }

        public Sort()
        {
            InsertionSort = new InsertionSort();
        }

        public void PrintResult(List<int> InputList, List<int> OutputList)
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
    }
}
