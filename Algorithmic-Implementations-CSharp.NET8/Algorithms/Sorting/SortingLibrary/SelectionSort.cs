namespace SortingLibrary;

/// <summary>
///     Class containing methods for performing Selection Sort.
/// </summary>
public static class SelectionSort
{
    /// <summary>
    ///     Sorts an array of integers using the Selection Sort algorithm.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    public static void Sort(int[] array)
    {
        int n = array.Length;

        // One by one, move the boundary of the unsorted subarray
        for (int i = 0; i < n - 1; i++)
        {
            // Find the minimum element in the unsorted array
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            // Swap the found minimum element with the first element
            Swap(ref array[i], ref array[minIndex]);
        }
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