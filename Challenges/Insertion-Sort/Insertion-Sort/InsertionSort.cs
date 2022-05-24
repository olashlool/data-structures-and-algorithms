using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    public class InsertionSort
    {
        public int[] InsertionSortArray(int[] arr)
        {
            Output(arr);

            for (int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                int temp = arr[i];

                while (j >= 0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j -= 1;
                }

                arr[j + 1] = temp;
                Output(arr);
            }
            return arr;
        }

        static void Output(int[] sortedArray)
        {
            Console.Write("[ ");
            foreach (int item in sortedArray)
            {
                Console.Write($"{item}, ");

            }
            Console.WriteLine("]");
        }
    }
}
