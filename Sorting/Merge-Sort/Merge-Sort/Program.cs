using System;

namespace Merge_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[] { 8, 4, 23, 42, 16, 15 };

            Console.WriteLine("Unsorted array:");

            Console.Write("[");
            foreach (var item in testArray)
            {
                Console.Write("{0},", item);
            }
            Console.WriteLine("]");

            MergeSort sort = new MergeSort();

            Console.WriteLine("Sorted array:");
            sort.MergeSortArray(testArray);

            Console.Write("[");
            foreach (var item in testArray)
            {
                Console.Write("{0},", item);
            }
            Console.WriteLine("]");
        }
    }
}
