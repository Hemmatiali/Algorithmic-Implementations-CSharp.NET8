namespace SearchingLibrary;

/// <summary>
///     Class containing methods for performing linear search.
/// </summary>
public static class LinearSearch
{
    /// <summary>
    ///     Performs a linear search on an array.
    /// </summary>
    /// <param name="array">The array to search in.</param>
    /// <param name="target">The value to search for.</param>
    /// <returns>The index of the target if found; otherwise, -1.</returns>
    public static int Search(int[] array, int target)
    {
        // Iterate over each element in the array
        for (int i = 0; i < array.Length; i++)
        {
            // Check if the current element matches the target
            if (array[i] == target)
            {
                return i; // Return the index if found
            }
        }

        return -1; // Return -1 if the target is not found
    }

    /// <summary>
    ///     Performs a linear search on a list.
    /// </summary>
    /// <param name="list">The list to search in.</param>
    /// <param name="target">The value to search for.</param>
    /// <returns>The index of the target if found; otherwise, -1.</returns>
    public static int Search(List<int> list, int target)
    {
        // Iterate over each element in the list
        for (int i = 0; i < list.Count; i++)
        {
            // Check if the current element matches the target
            if (list[i] == target)
            {
                return i; // Return the index if found
            }
        }

        return -1; // Return -1 if the target is not found
    }
}