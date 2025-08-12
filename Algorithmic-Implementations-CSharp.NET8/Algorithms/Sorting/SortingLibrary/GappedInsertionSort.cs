namespace SortingLibrary;


/// <summary>
///     Class containing methods for performing Gapped Insertion Sort (utility used by Shell Sort).
/// </summary>
public static class GappedInsertionSort
{
    /// <summary>
    ///     Performs a single gapped insertion pass over the entire array using the specified <paramref name="gap"/>.
    ///     This is the core operation used by Shell Sort.
    /// </summary>
    /// <param name="array">The array to be partially sorted.</param>
    /// <param name="gap">The gap distance between compared elements (must be &gt;= 1).</param>
    public static void Sort(int[] array, int gap)
    {
        if (array == null || array.Length <= 1 || gap <= 0)
        {
            return; // Nothing to do for null/single-element arrays or invalid gap
        }

        // Starting from index = gap, perform an insertion-sort-like pass
        // where elements are compared and shifted in steps of 'gap'.
        for (int i = gap; i < array.Length; i++)
        {
            int temp = array[i];
            int j = i;

            // Shift earlier gap-sorted elements up until the correct
            // location for 'temp' is found.
            while (j >= gap && array[j - gap] > temp)
            {
                array[j] = array[j - gap];
                j -= gap;
            }

            // Place 'temp' at its correct location for this gap.
            array[j] = temp;
        }
    }

    /// <summary>
    ///     Performs a gapped insertion pass on a subsection of the array [<paramref name="left"/>.. <paramref name="right"/>].
    ///     Useful if you need to restrict the pass to a specific range.
    /// </summary>
    /// <param name="array">The array to be partially sorted.</param>
    /// <param name="left">Left boundary (inclusive).</param>
    /// <param name="right">Right boundary (inclusive).</param>
    /// <param name="gap">The gap distance between compared elements (must be &gt;= 1).</param>
    public static void SortRange(int[] array, int left, int right, int gap)
    {
        if (array == null || array.Length <= 1 || gap <= 0)
        {
            return; // Nothing to do
        }

        if (left < 0) left = 0;
        if (right >= array.Length) right = array.Length - 1;
        if (left >= right) return;

        for (int i = left + gap; i <= right; i++)
        {
            int temp = array[i];
            int j = i;

            while (j - gap >= left && array[j - gap] > temp)
            {
                array[j] = array[j - gap];
                j -= gap;
            }

            array[j] = temp;
        }
    }
}
