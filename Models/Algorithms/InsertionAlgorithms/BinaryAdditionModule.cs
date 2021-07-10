using System;
using System.Collections.Generic;
using System.Linq;

namespace IntroToAlgorithms.Models.Algorithms.InsertionAlgorithms
{
    class BinaryAdditionModule
    {
        public BinaryAdditionModule() { }

        public List<List<string>> GetParsedListsContainingTheBinaryNumbersFromUser()
        {
            string userInput = Console.ReadLine();

            string[] parsedUserInputArray = userInput.Trim().Replace(" ", String.Empty).Split(',');

            List<List<string>> parsedUserInputLists = parsedUserInputArray.Select(element => element.ToCharArray().Select(element => element.ToString()).ToList()).ToList();

            return parsedUserInputLists;
        }

        private string AddBinaryNumbers(string binaryOne, string binaryTwo, string carry)
        {
            string binarySummation = Convert.ToString((Convert.ToInt32(binaryOne, 2) + Convert.ToInt32(binaryTwo, 2)), 2);

            if (!string.IsNullOrEmpty(carry))
            {
                binarySummation = Convert.ToString((Convert.ToInt32(binarySummation, 2) + Convert.ToInt32(carry, 2)), 2);
            }

            return binarySummation;
        }

        public List<string> ExecuteBinaryAddition(List<List<string>> inputList)
        {
            List<string> firstList = inputList[0];
            List<string> secondList = inputList[1];
            List<string> resultList = new List<string>();
            string carry = "";



            for (int startingIndex = firstList.Count - 1; startingIndex > -1; startingIndex--)
            {
                string currentBinaryDigitOfFirstList = firstList[startingIndex];
                string currentBinaryDigitOfSecondList = secondList[startingIndex];

                string summationOfCurrentBinaryDigits = AddBinaryNumbers(currentBinaryDigitOfFirstList, currentBinaryDigitOfSecondList, carry);

                char[] summationOfCurrentBinaryDigitsArray = summationOfCurrentBinaryDigits.ToCharArray();

                if (summationOfCurrentBinaryDigitsArray.Length > 1)
                {
                    carry = summationOfCurrentBinaryDigitsArray.First().ToString();
                }

                string resultDigit = summationOfCurrentBinaryDigitsArray.Last().ToString();

                resultList.Insert(0, resultDigit);
            }

            if (!String.IsNullOrEmpty(carry))
            {
                resultList.Insert(0, carry);
            }

            return resultList;
        }

        public void RunBinaryAdditionApplication()
        {
            Console.WriteLine("\nPlease enter two binary numbers of same bits separated by comma to form two arrays with binary digits.");

            List<List<string>> binaryNumberLists = GetParsedListsContainingTheBinaryNumbersFromUser();

            List<string> resultingListOfBinarySummationDigits = ExecuteBinaryAddition(binaryNumberLists);

            Console.WriteLine("[{0}]", String.Join(", ", resultingListOfBinarySummationDigits));
        }
    }
}
