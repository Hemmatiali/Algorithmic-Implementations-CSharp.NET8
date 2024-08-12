namespace SearchingLibrary;

/// <summary>
///     Class containing methods for performing Meta Binary Search.
/// </summary>
public static class MetaBinarySearch
{
    /// <summary>
    ///     Performs a Meta Binary Search using recursion on a sorted array.
    /// </summary>
    /// <param name="array">The sorted array to search in.</param>
    /// <param name="target">The value to search for.</param>
    /// <returns>The index of the target if found; otherwise, -1.</returns>
    public static int RecursiveSearch(int[] array, int target)
    {
        return MetaBinarySearchRecursive(array, target, 0, array.Length - 1);
    }

    /// <summary>
    ///     Recursively performs the Meta Binary Search on a sorted array.
    /// </summary>
    /// <param name="array">The sorted array to search in.</param>
    /// <param name="target">The value to search for.</param>
    /// <param name="low">The starting index of the current search range.</param>
    /// <param name="high">The ending index of the current search range.</param>
    /// <returns>The index of the target if found; otherwise, -1.</returns>
    private static int MetaBinarySearchRecursive(int[] array, int target, int low, int high)
    {
        if (low > high) return -1; // Base case: Target is not found.

        // Calculate the middle index in the current range
        int mid = low + (high - low) / 2;

        // Check if the middle element is the target
        if (array[mid] == target)
            return mid;

        // If target is less than the middle element, search in the left subarray
        if (array[mid] > target)
            return MetaBinarySearchRecursive(array, target, low, mid - 1);

        // Otherwise, search in the right subarray
        return MetaBinarySearchRecursive(array, target, mid + 1, high);
    }

    /// <summary>
    ///     Performs a Meta Binary Search using bitwise operations on a sorted list.
    /// </summary>
    /// <param name="list">The sorted list to search in.</param>
    /// <param name="keyToSearch">The value to search for.</param>
    /// <returns>The index of the target if found; otherwise, -1.</returns>
    public static int BitwiseSearch(List<int> list, int keyToSearch)
    {
        int n = list.Count;

        // Calculate the number of bits required to represent the largest index
        int lg = (int)Math.Log(n - 1, 2.0) + 1;

        int pos = 0;
        for (int i = lg - 1; i >= 0; i--)
        {
            if (list[pos] == keyToSearch)
            {
                return pos;
            }

            // Incrementally construct the index of the target value
            int newPos = pos | (1 << i);

            // Check within bounds and update position if necessary
            if (newPos < n && list[newPos] <= keyToSearch)
            {
                pos = newPos;
            }
        }

        // Return the final position if the element was found
        return (list.Any() && list[pos] == keyToSearch) ? pos : -1;
    }
}