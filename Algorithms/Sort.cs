using IntroToAlgorithms.Algorithms.Insertion;

namespace IntroToAlgorithms.Algorithms
{
    public class Sort
    {
        public InsertionAlgorithms InsertionAlgorithms { get; set; }

        public Sort()
        {
            InsertionAlgorithms = new InsertionAlgorithms();
        }
    }
}
