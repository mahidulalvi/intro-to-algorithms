using System;
using IntroToAlgorithms.Algorithms;

Console.WriteLine("Let's practise some algorithms!");

Sort sort = new Sort();

Console.WriteLine("\nPress 1 to select insertion algorithms.");

string selectedAlgorithm = Console.ReadLine();

if (selectedAlgorithm == "1")
{
    sort.InsertionAlgorithms.Initialize();
}
