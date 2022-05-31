using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sort
{
    public class Quick_SortClass
    {
        public int[] QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                var position = Partition(arr, left, right);
                QuickSort(arr, left, position - 1);
                QuickSort(arr, position + 1, right);
            }
            return arr;
        }
        public int Partition(int[] arr, int left, int right)
        {
            var pivot = arr[right];
            var low = left - 1;
            for (int i = left; i < right; i++)
            {
                if (arr[i]<= pivot)
                {
                    low++;
                    Swap(arr, i, low);
                }
            }
            Swap(arr, right, low + 1);
            return low + 1;
        }
        public void Swap(int[] arr, int i, int low)
        {
            var temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }

    }
}
