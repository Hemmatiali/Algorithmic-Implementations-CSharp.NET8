namespace SearchingLibrary;

/// <summary>
///     Class containing methods for performing jump search.
/// </summary>
public static class JumpSearch
{
    /// <summary>
    /// Performs a jump search on a sorted array.
    /// </summary>
    /// <param name="array">The sorted array to search in.</param>
    /// <param name="target">The value to search for.</param>
    /// <returns>The index of the target if found; otherwise, -1.</returns>
    public static int Search(int[] array, int target)
    {
        int n = array.Length;

        // Check array length 
        if (n == 0)
            return -1;

        // Calculate the optimal jump size
        int step = (int)Math.Floor(Math.Sqrt(n));
        int prev = 0;

        // Finding the block where the element is present (if it is present)
        while (array[Math.Min(step, n) - 1] < target)
        {
            prev = step;
            step += (int)Math.Floor(Math.Sqrt(n));
            if (prev >= n)
                return -1;
        }

        // Doing a linear search for target in the identified block
        while (array[prev] < target)
        {
            prev++;
            // If we reached next block or end of the array, element is not present
            if (prev == Math.Min(step, n))
                return -1;
        }

        // If element is found
        if (array[prev] == target)
            return prev;

        return -1;
    }
}