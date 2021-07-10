using System;
using System.Collections.Generic;
using System.Linq;

namespace IntroToAlgorithms.Models.Algorithms.InsertionAlgorithms
{
    class Utils
    {
        public Utils() { }

        public void PrintResult(List<int> inputList, List<int> outputList = null)
        {
            Console.WriteLine("[{0}]", String.Join(", ", inputList));

            if (outputList != null && outputList.Count > 0)
            {
                Console.WriteLine("[{0}]", String.Join(", ", outputList));
            }
        }

        public List<int> GetParsedListFromUserInput()
        {
            string userInput = Console.ReadLine();
            string[] parsedUserInputArray = userInput.Trim().Replace(" ", String.Empty).Split(',');

            List<int> parsedUserInputList = parsedUserInputArray.Select(element => Convert.ToInt32(element)).ToList();

            return parsedUserInputList;
        }
    }
}
