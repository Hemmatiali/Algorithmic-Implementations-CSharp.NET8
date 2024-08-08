namespace SearchingLibrary;

/// <summary>
///     Class containing methods for performing binary search.
/// </summary>
public static class BinarySearch
{
    /// <summary>
    ///     Iteratively performs binary search on a sorted array.
    /// </summary>
    /// <param name="array">The sorted array to search in.</param>
    /// <param name="target">The value to search for.</param>
    /// <returns>The index of the target if found; otherwise, -1.</returns>
    public static int Iterative(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2; // Handles overflow

            if (array[mid] == target)
                return mid;

            if (array[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }

    /// <summary>
    ///     Recursively performs binary search on a sorted array.
    /// </summary>
    /// <param name="array">The sorted array to search in.</param>
    /// <param name="target">The value to search for.</param>
    /// <param name="left">The left boundary of the search interval.</param>
    /// <param name="right">The right boundary of the search interval.</param>
    /// <returns>The index of the target if found; otherwise, -1.</returns>
    public static int Recursive(int[] array, int target, int left, int right)
    {
        if (left > right)
            return -1;

        int mid = left + (right - left) / 2; // Handles overflow

        if (array[mid] == target)
            return mid;

        if (array[mid] < target)
            return Recursive(array, target, mid + 1, right);
        else
            return Recursive(array, target, left, mid - 1);
    }
}

