using System;

namespace Quick_Sort
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

            Quick_SortClass sort = new Quick_SortClass();

            Console.WriteLine("Sorted array:");
            sort.QuickSort(testArray, 0, testArray.Length - 1);

            Console.Write("[");
            foreach (var item in testArray)
            {
                Console.Write("{0},", item);
            }
            Console.WriteLine("]");
        }
    }
}
