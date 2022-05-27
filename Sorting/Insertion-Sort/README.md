# Insertion Sort

## Challenge Summary

Write a function for insertion sort that takes in an unsorted array and returns the array sorted using insertion sort.

## Approach & Efficiency

This function looks at the value at **array[0]** and compares it to the value at **array[1]**. 
If **array[1]** is less than **array[0]**, the two values are "swapped". 
The function then compares **array[1]** to **array[2]**. If **array[2]** is less than **array[1]**, 
the two values are "swapped" and **array[0]** is once again compared to **array[1]** 
and swapped if required.

- Time: O(n^2)

  - The basic operation of this algorithm is comparison. This will happen nth triangular number of times, making this n squared algorithm

- Space: O(1)
  - No additional space is being created. This array is being sorted in place, making this space at constant O(1).
