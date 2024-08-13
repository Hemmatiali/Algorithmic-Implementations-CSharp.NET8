namespace SearchingLibrary;

/// <summary>
///     Class containing methods for performing Ternary Search.
/// </summary>
public static class TernarySearch
{
    /// <summary>
    ///     Performs a ternary search on a sorted array.
    /// </summary>
    /// <param name="array">The sorted array to search in.</param>
    /// <param name="target">The value to search for.</param>
    /// <returns>The index of the target if found; otherwise, -1.</returns>
    public static int Search(int[] array, int target)
    {
        return TernarySearchRecursive(array, target, 0, array.Length - 1);
    }

    /// <summary>
    ///     Recursively performs the ternary search on a sorted array.
    /// </summary>
    /// <param name="array">The sorted array to search in.</param>
    /// <param name="target">The value to search for.</param>
    /// <param name="left">The starting index of the current search range.</param>
    /// <param name="right">The ending index of the current search range.</param>
    /// <returns>The index of the target if found; otherwise, -1.</returns>
    private static int TernarySearchRecursive(int[] array, int target, int left, int right)
    {
        if (right < left)
            return -1;

        // Calculate the two midpoints
        int mid1 = left + (right - left) / 3;
        int mid2 = right - (right - left) / 3;

        // Check if the target is at either of the midpoints
        if (array[mid1] == target)
            return mid1;

        if (array[mid2] == target)
            return mid2;

        // If target is less than mid1, search in the left third
        if (target < array[mid1])
            return TernarySearchRecursive(array, target, left, mid1 - 1);

        // If target is greater than mid2, search in the right third
        if (target > array[mid2])
            return TernarySearchRecursive(array, target, mid2 + 1, right);

        // Otherwise, search in the middle third
        return TernarySearchRecursive(array, target, mid1 + 1, mid2 - 1);
    }
}