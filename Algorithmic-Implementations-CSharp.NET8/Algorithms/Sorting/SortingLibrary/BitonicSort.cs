namespace SortingLibrary;

/// <summary>
///     Class containing methods for performing Bitonic Sort.
/// </summary>
public static class BitonicSort
{
    /// <summary>
    ///     Sorts an array using the Bitonic Sort algorithm.
    ///     The input array's length must be a power of 2.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    /// <param name="ascending">True to sort in ascending order; false for descending.</param>
    public static void Sort(int[] array, bool ascending = true)
    {
        if (!IsPowerOfTwo(array.Length))
        {
            throw new ArgumentException("Array length must be a power of 2 for Bitonic Sort.");
        }

        BitonicSortRecursive(array, 0, array.Length, ascending);
    }

    /// <summary>
    ///     Recursively sorts a bitonic sequence.
    /// </summary>
    private static void BitonicSortRecursive(int[] array, int low, int count, bool ascending)
    {
        if (count > 1)
        {
            int k = count / 2;

            // First half in ascending order second half in descending
            BitonicSortRecursive(array, low, k, true);
            BitonicSortRecursive(array, low + k, k, false);

            // Merge the entire sequence in specified order
            BitonicMerge(array, low, count, ascending);
        }
    }

    /// <summary>
    ///     Merges a bitonic sequence into sorted order.
    /// </summary>
    private static void BitonicMerge(int[] array, int low, int count, bool ascending)
    {
        if (count > 1)
        {
            int k = count / 2;
            for (int i = low; i < low + k; i++)
            {
                if ((ascending && array[i] > array[i + k]) ||
                    (!ascending && array[i] < array[i + k]))
                {
                    // Swap elements to maintain order
                    (array[i], array[i + k]) = (array[i + k], array[i]);
                }
            }

            BitonicMerge(array, low, k, ascending);
            BitonicMerge(array, low + k, k, ascending);
        }
    }

    /// <summary>
    ///     Checks whether a number is a power of 2.
    /// </summary>
    private static bool IsPowerOfTwo(int n) =>
        n > 0 && (n & (n - 1)) == 0;
}

