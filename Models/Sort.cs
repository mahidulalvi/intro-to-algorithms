using IntroToAlgorithms.Models.Algorithms.InsertionSort;
using System;
using System.Collections.Generic;

namespace IntroToAlgorithms.Models
{
    class Sort
    {
        public InsertionSort InsertionSort { get; set; }

        public Sort()
        {
            InsertionSort = new InsertionSort();
        }
    }
}
