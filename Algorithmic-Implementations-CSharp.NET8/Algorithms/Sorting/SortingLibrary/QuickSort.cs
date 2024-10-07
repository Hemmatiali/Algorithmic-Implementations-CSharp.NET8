namespace SortingLibrary;

/// <summary>
///     Class containing methods for performing Quick Sort.
/// </summary>
public static class QuickSort
{
    /// <summary>
    ///     Sorts an array of integers using the Quick Sort algorithm.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    /// <param name="low">The starting index of the array.</param>
    /// <param name="high">The ending index of the array.</param>
    public static void Sort(int[] array, int low, int high)
    {
        if (low < high)
        {
            // Partition the array around the pivot
            int pivotIndex = Partition(array, low, high);

            // Recursively sort elements before and after the partition
            Sort(array, low, pivotIndex - 1);
            Sort(array, pivotIndex + 1, high);
        }
    }

    /// <summary>
    ///     Partitions the array into two halves, elements less than the pivot on the left and greater on the right.
    /// </summary>
    /// <param name="array">The array to partition.</param>
    /// <param name="low">The starting index of the partition.</param>
    /// <param name="high">The ending index of the partition.</param>
    /// <returns>The index of the pivot element after partitioning.</returns>
    private static int Partition(int[] array, int low, int high)
    {
        // Choose the last element as the pivot
        int pivot = array[high];
        int i = low - 1;

        // Rearrange elements such that elements less than the pivot are on the left and greater on the right
        for (int j = low; j < high; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                Swap(ref array[i], ref array[j]);
            }
        }

        // Swap the pivot element to its correct position
        Swap(ref array[i + 1], ref array[high]);

        return i + 1;
    }

    /// <summary>
    ///     Swaps two elements in the array.
    /// </summary>
    /// <param name="a">Reference to the first element.</param>
    /// <param name="b">Reference to the second element.</param>
    private static void Swap(ref int a, ref int b)
    {
        (a, b) = (b, a);
    }
}
