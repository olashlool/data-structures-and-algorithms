using System;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertionSort insertSortArray = new InsertionSort();
            int[] reverseSort = new int[] { 20, 18, 12, 8, 5, -2 };
            int[] fewUniques = new int[] { 5, 12, 7, 5, 5, 7 };
            int[] nearlySorted = new int[] { 2, 3, 5, 7, 13, 11 };

            Console.WriteLine("======== Reverse Sorted Array =========");
            reverseSort = insertSortArray.InsertionSortArray(reverseSort);
            Console.WriteLine();

            Console.WriteLine("========== Few Uniques Array ==========");
            fewUniques = insertSortArray.InsertionSortArray(fewUniques);
            Console.WriteLine();

            Console.WriteLine("========= Nearly Sorted Array =========");
            nearlySorted = insertSortArray.InsertionSortArray(nearlySorted);

        }
    }
}
