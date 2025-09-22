namespace SortingLibrary;

/// <summary>
///     Class containing methods for performing Spaghetti Sort (software simulation).
///     Conceptually, Spaghetti Sort uses parallel “length comparisons” to order elements.
///     This implementation simulates that idea using a frequency map (like laying out pasta
///     of different lengths and collecting from shortest to longest).
/// </summary>
public static class SpaghettiSort
{
    /// <summary>
    ///     Sorts an array of integers in non-decreasing order using a Spaghetti Sort simulation.
    ///     Works for any integers (negative and positive) by normalizing values to a non-negative range.
    ///     Note: This approach allocates O(max - min + 1) extra space (similar to Counting Sort).
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    public static void Sort(int[] array)
    {
        if (array == null || array.Length <= 1)
        {
            return; // Nothing to sort for null or single-element arrays
        }

        // Find min and max to normalize values to [0..range]
        int min = array[0], max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min) min = array[i];
            if (array[i] > max) max = array[i];
        }

        int range = max - min + 1;

        // Frequency map for each value in [min..max]
        int[] freq = new int[range];
        for (int i = 0; i < array.Length; i++)
        {
            freq[array[i] - min]++;
        }

        // Reconstruct the array in sorted order
        int index = 0;
        for (int r = 0; r < range; r++)
        {
            while (freq[r]-- > 0)
            {
                array[index++] = r + min;
            }
        }
    }
}