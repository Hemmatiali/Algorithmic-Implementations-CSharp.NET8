namespace SearchingLibrary;

/// <summary>
///     Class containing methods for performing Interpolation Search.
/// </summary>
public static class InterpolationSearch
{
    /// <summary>
    ///     Performs an interpolation search on a sorted array.
    /// </summary>
    /// <param name="array">The sorted array to search in.</param>
    /// <param name="target">The value to search for.</param>
    /// <returns>The index of the target if found; otherwise, -1.</returns>
    public static int Search(int[] array, int target)
    {
        int low = 0;
        int high = array.Length - 1;

        // Check if we have one index only
        if (high == 0)
            return 0;

        while (low <= high && target >= array[low] && target <= array[high])
        {
            // Calculate the position using the interpolation formula
            int probe = low + ((target - array[low]) * (high - low))
                / (array[high] - array[low]);

            // Check if the target is found
            if (array[probe] == target)
                return probe;

            // If the target is larger, it is in the upper part
            if (array[probe] < target)
                low = probe + 1;

            // If the target is smaller, it is in the lower part
            else
                high = probe - 1;
        }

        return -1; // Target not found
    }
}