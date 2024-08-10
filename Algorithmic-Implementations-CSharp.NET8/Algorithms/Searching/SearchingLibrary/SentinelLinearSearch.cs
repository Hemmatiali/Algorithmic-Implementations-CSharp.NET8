namespace SearchingLibrary;

/// <summary>
///     Class containing methods for performing sentinel linear search.
/// </summary>
public static class SentinelLinearSearch
{
    /// <summary>
    ///     Performs a sentinel linear search on an array.
    /// </summary>
    /// <param name="array">The array to search in.</param>
    /// <param name="target">The value to search for.</param>
    /// <returns>The index of the target if found; otherwise, -1.</returns>
    public static int Search(int[] array, int target)
    {
        int n = array.Length;
        if (n == 0) return -1; // Handle empty array case

        int lastElement = array[n - 1];
        array[n - 1] = target; // Place the sentinel

        int i = 0;
        // Iterate over each element until the target is found
        while (array[i] != target)
        {
            i++;
        }

        // Restore the last element
        array[n - 1] = lastElement;

        // Check if the found index is within the original array bounds
        if (i < n - 1 || array[n - 1] == target)
        {
            return i; // Return the index if found
        }

        return -1; // Return -1 if the target is not found
    }

    /// <summary>
    ///     Performs a sentinel linear search on a list.
    /// </summary>
    /// <param name="list">The list to search in.</param>
    /// <param name="target">The value to search for.</param>
    /// <returns>The index of the target if found; otherwise, -1.</returns>
    public static int Search(List<int> list, int target)
    {
        int n = list.Count;
        if (n == 0) return -1; // Handle empty list case

        list.Add(target); // Add the sentinel at the end

        int i = 0;
        // Iterate over each element until the target is found
        while (list[i] != target)
        {
            i++;
        }

        list.RemoveAt(n); // Remove the sentinel

        // Check if the found index is within the original list bounds
        if (i < n)
        {
            return i; // Return the index if found
        }

        return -1; // Return -1 if the target is not found
    }
}