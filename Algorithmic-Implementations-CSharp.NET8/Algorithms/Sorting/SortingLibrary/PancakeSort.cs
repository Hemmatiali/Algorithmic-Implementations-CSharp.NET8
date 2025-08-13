namespace SortingLibrary;


/// <summary>
///     Class containing methods for performing Pancake Sort.
/// </summary>
public static class PancakeSort
{
    /// <summary>
    ///     Sorts an array of integers in non-decreasing order using the Pancake Sort algorithm.
    ///     Pancake Sort repeatedly brings the maximum of the unsorted prefix to the front (via a flip)
    ///     and then flips it into its correct position at the end of the current range.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    public static void Sort(int[] array)
    {
        if (array == null || array.Length <= 1)
        {
            return; // Nothing to sort for null or single-element arrays
        }

        // Work from the full length down to 1, placing the next maximum at the end each iteration
        for (int currSize = array.Length; currSize > 1; currSize--)
        {
            // Find the index of the maximum element in array[0..currSize-1]
            int maxIndex = FindMaxIndex(array, currSize);

            // If the maximum element is not already at its correct position (currSize - 1)
            if (maxIndex != currSize - 1)
            {
                // Step 1: Bring the maximum element to the front if it's not already there
                if (maxIndex != 0)
                {
                    Flip(array, maxIndex);
                }

                // Step 2: Move the maximum element from the front to its correct position
                Flip(array, currSize - 1);
            }
        }
    }

    /// <summary>
    ///     Reverses the subarray array[0..i] in place (i.e., performs a "flip").
    /// </summary>
    /// <param name="array">The target array.</param>
    /// <param name="i">The end index of the prefix to flip (0-based, inclusive).</param>
    private static void Flip(int[] array, int i)
    {
        int start = 0;
        while (start < i)
        {
            (array[start], array[i]) = (array[i], array[start]); // Swap
            start++;
            i--;
        }
    }

    /// <summary>
    ///     Finds the index of the maximum element within array[0..n-1].
    /// </summary>
    /// <param name="array">The target array.</param>
    /// <param name="n">The exclusive upper bound of the search range (search 0..n-1).</param>
    /// <returns>The index of the maximum element in the specified range.</returns>
    private static int FindMaxIndex(int[] array, int n)
    {
        int maxIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }
        return maxIndex;
    }
}