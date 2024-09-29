namespace SortingLibrary;

/// <summary>
///     Class containing methods for performing Merge Sort.
/// </summary>
public static class MergeSort
{
    /// <summary>
    ///     Sorts an array of integers using the Merge Sort algorithm.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    public static void Sort(int[] array)
    {
        if (array.Length < 2)
            return; // Base case: If the array has less than 2 elements, it's already sorted

        int mid = array.Length / 2;

        // Split array into two halves
        int[] left = new int[mid];
        int[] right = new int[array.Length - mid];

        // Manually copy elements into the left subarray
        for (int i = 0; i < mid; i++)
            left[i] = array[i];

        // Manually copy elements into the right subarray
        for (int i = mid; i < array.Length; i++)
            right[i - mid] = array[i];

        // Recursively sort the two halves
        Sort(left);
        Sort(right);

        // Merge the sorted halves
        Merge(array, left, right);
    }

    /// <summary>
    ///     Merges two sorted subarrays into the original array.
    /// </summary>
    /// <param name="array">The original array to store merged results.</param>
    /// <param name="left">The left sorted subarray.</param>
    /// <param name="right">The right sorted subarray.</param>
    private static void Merge(int[] array, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;

        // Traverse both arrays and copy the smaller element into the original array
        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
            {
                array[k] = left[i];
                i++;
            }
            else
            {
                array[k] = right[j];
                j++;
            }
            k++;
        }

        // Copy any remaining elements of the left subarray
        while (i < left.Length)
        {
            array[k] = left[i];
            i++;
            k++;
        }

        // Copy any remaining elements of the right subarray
        while (j < right.Length)
        {
            array[k] = right[j];
            j++;
            k++;
        }
    }
}