namespace SortingLibrary;

/// <summary>
///     Class containing methods for performing Recursive Bubble Sort.
/// </summary>
public static class RecursiveBubbleSort
{
    /// <summary>
    ///     Sorts an array of integers using the recursive Bubble Sort algorithm.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    /// <param name="n">The length of the array or subarray being processed.</param>
    public static void Sort(int[] array, int n)
    {
        // Base case: If the array has one element or less, it's already sorted
        if (n is 0 or 1)
            return;

        // One pass of bubble sort: move the largest element to the end
        for (int i = 0; i < n - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                Swap(ref array[i], ref array[i + 1]);
            }
        }

        // Largest element is fixed, recurse for the remaining array
        Sort(array, n - 1);
    }

    /// <summary>
    ///     Swaps two elements in the array.
    /// </summary>
    /// <param name="a">Reference to the first element.</param>
    /// <param name="b">Reference to the second element.</param>
    private static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}