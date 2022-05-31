using System;
using Xunit;
using Quick_Sort;
namespace Quick_Sort_Test
{
    public class UnitTest1
    {
       [Fact]
        public void SimpleArray()
        {
            Quick_SortClass sort = new Quick_SortClass();

            int[] arr = new int[] { 8, 4, 23, 42, 16, 15 };
            int[] sortedArr = new int[] { 4, 8, 15, 16, 23, 42 };
            int[] result = sort.QuickSort(arr, 0, arr.Length - 1);

            Assert.Equal(sortedArr, result);
        }
        [Fact]
        public void ReverseSorted()
        {
            Quick_SortClass sort = new Quick_SortClass();

            int[] arr = new int[] { 20, 18, 12, 8, 5, -2 };
            int[] sortedArr = new int[] { -2, 5, 8, 12, 18, 20 };
            int[] result = sort.QuickSort(arr, 0, arr.Length - 1);

            Assert.Equal(sortedArr, result);
        }
        [Fact]
        public void FewUniques()
        {
            Quick_SortClass sort = new Quick_SortClass();

            int[] arr = new int[] { 5, 12, 7, 5, 5, 7 };
            int[] sortedArr = new int[] { 5, 5, 5, 7, 7, 12 };
            int[] result = sort.QuickSort(arr, 0, arr.Length - 1);

            Assert.Equal(sortedArr, result);
        }
        [Fact]
        public void NearlySorted()
        {
            Quick_SortClass sort = new Quick_SortClass();

            int[] arr = new int[] { 2, 3, 5, 7, 13, 11 };
            int[] sortedArr = new int[] { 2, 3, 5, 7, 11, 13 };
            int[] result = sort.QuickSort(arr, 0, arr.Length - 1);

            Assert.Equal(sortedArr, result);
        }
    }
}
