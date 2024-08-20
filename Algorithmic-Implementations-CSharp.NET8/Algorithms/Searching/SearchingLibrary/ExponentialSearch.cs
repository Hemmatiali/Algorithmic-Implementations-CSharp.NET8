namespace SearchingLibrary;

/// <summary>
///     Class containing methods for performing Exponential Search.
/// </summary>
public static class ExponentialSearch
{
    /// <summary>
    ///     Performs an exponential search on a sorted array using the basic recursive approach.
    /// </summary>
    /// <param name="array">The sorted array to search in.</param>
    /// <param name="target">The value to search for.</param>
    /// <returns>The index of the target if found; otherwise, -1.</returns>
    public static int BasicSearch(int[] array, int target)
    {
        int n = array.Length;

        if (n == 0)
            return -1;

        // If the target is at the first position
        if (array[0] == target)
            return 0;

        // Find range for binary search by repeated doubling
        int i = 1;
        while (i < n && array[i] <= target)
        {
            i *= 2;
        }

        // Call binary search for the found range
        return BinarySearch(array, target, i / 2, Math.Min(i, n - 1));
    }

    /// <summary>
    ///     Performs a binary search within a specific range in a sorted array.
    /// </summary>
    /// <param name="array">The sorted array to search in.</param>
    /// <param name="target">The value to search for.</param>
    /// <param name="low">The lower bound of the range to search within.</param>
    /// <param name="high">The upper bound of the range to search within.</param>
    /// <returns>The index of the target if found; otherwise, -1.</returns>
    private static int BinarySearch(int[] array, int target, int low, int high)
    {
        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (array[mid] == target)
                return mid;

            if (array[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return -1;
    }

    /// <summary>
    ///     Performs an exponential search on a sorted array using the iterative approach.
    /// </summary>
    /// <param name="array">The sorted array to search in.</param>
    /// <param name="target">The value to search for.</param>
    /// <returns>The index of the target if found; otherwise, -1.</returns>
    public static int IterativeSearch(int[] array, int target)
    {
        int n = array.Length;

        if (n == 0)
            return -1;

        // Find range for binary search by repeated doubling
        int bound = 1;
        while (bound < n && array[bound] < target)
        {
            bound *= 2;
        }

        // Perform binary search within the identified range
        int left = bound / 2;
        int right = Math.Min(bound, n - 1);

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] == target)
                return mid;

            if (array[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }
}
