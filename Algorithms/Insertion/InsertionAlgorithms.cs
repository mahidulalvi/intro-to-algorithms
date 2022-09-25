using System;
using IntroToAlgorithms.Algorithms.Insertion.Modules;

namespace IntroToAlgorithms.Algorithms.Insertion
{
    public class InsertionAlgorithms
    {
        public InsertionSortModule InsertionSortModule { get; set; }
        public BinaryAdditionModule BinaryAdditionModule { get; set; }
        public LinearSearchModule LinearSearchModule { get; set; }
        public SelectionSortModule SelectionSortModule { get; set; }
        public Utils Utils { get; set; }

        public InsertionAlgorithms()
        {
            InsertionSortModule = new InsertionSortModule();
            BinaryAdditionModule = new BinaryAdditionModule();
            LinearSearchModule = new LinearSearchModule();
            SelectionSortModule = new SelectionSortModule();
            Utils = new Utils();
        }

        public void Initialize()
        {
            Console.WriteLine("\nPlease select an application.");
            Console.WriteLine("1. Insertion Sort");
            Console.WriteLine("2. Linear Search");
            Console.WriteLine("3. Binary Addition");
            Console.WriteLine("4. Selection Sort\n");

            string selectedApplication = Console.ReadLine();

            if (selectedApplication == "1")
            {
                InsertionSortModule.RunInsertionSortApplication();
            }
            else if (selectedApplication == "2")
            {
                LinearSearchModule.RunLinearSearchApplication();
            }
            else if (selectedApplication == "3")
            {
                BinaryAdditionModule.RunBinaryAdditionApplication();
            }
            else if (selectedApplication == "4")
            {
                SelectionSortModule.RunSelectionSortApplication();
            }
        }
    }
}
