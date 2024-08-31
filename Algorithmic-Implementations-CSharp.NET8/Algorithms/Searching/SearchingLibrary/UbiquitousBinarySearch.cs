namespace SearchingLibrary;

/// <summary>
///     Class containing methods for performing Ubiquitous Binary Search.
/// </summary>
public static class UbiquitousBinarySearch
{
    /// <summary>
    ///     Finds the first occurrence of a target value in a sorted array.
    /// </summary>
    /// <param name="array">The sorted array to search in.</param>
    /// <param name="target">The value to search for.</param>
    /// <returns>The index of the first occurrence of the target if found; otherwise, -1.</returns>
    public static int FindFirst(int[] array, int target)
    {
        int low = 0;
        int high = array.Length - 1;
        int result = -1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (array[mid] == target)
            {
                result = mid;  // Target found, but continue searching in the left half to find the first occurrence
                high = mid - 1;
            }
            else if (array[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return result;
    }

    /// <summary>
    ///     Finds the last occurrence of a target value in a sorted array.
    /// </summary>
    /// <param name="array">The sorted array to search in.</param>
    /// <param name="target">The value to search for.</param>
    /// <returns>The index of the last occurrence of the target if found; otherwise, -1.</returns>
    public static int FindLast(int[] array, int target)
    {
        int low = 0;
        int high = array.Length - 1;
        int result = -1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (array[mid] == target)
            {
                result = mid;  // Target found, but continue searching in the right half to find the last occurrence
                low = mid + 1;
            }
            else if (array[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return result;
    }

    /// <summary>
    ///     Counts the number of occurrences of a target value in a sorted array.
    /// </summary>
    /// <param name="array">The sorted array to search in.</param>
    /// <param name="target">The value to search for.</param>
    /// <returns>The number of occurrences of the target in the array.</returns>
    public static int CountOccurrences(int[] array, int target)
    {
        int firstIndex = FindFirst(array, target);
        if (firstIndex == -1)
        {
            return 0;  // Target not found
        }

        int lastIndex = FindLast(array, target);

        return lastIndex - firstIndex + 1;
    }
}