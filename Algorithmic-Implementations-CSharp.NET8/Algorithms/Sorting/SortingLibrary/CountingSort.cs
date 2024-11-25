namespace SortingLibrary;

/// <summary>
/// Class containing methods for performing Counting Sort.
/// </summary>
public static class CountingSort
{
    /// <summary>
    ///     Sorts an array of integers using the Counting Sort algorithm.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    /// <returns>The sorted array.</returns>
    public static int[] Sort(int[] array)
    {
        if (array.Length == 0)
        {
            return array; 
        }

        // Find the range of input data
        var max = array[0];
        var min = array[0];
        foreach (var num in array)
        {
            if (num > max) max = num;
            if (num < min) min = num;
        }

        // Initialize the count array
        var range = max - min + 1;
        var count = new int[range];
        var output = new int[array.Length];

        // Count the occurrences of each element
        foreach (var num in array)
        {
            count[num - min]++;
        }

        // Update the count array to store cumulative counts
        for (var i = 1; i < count.Length; i++)
        {
            count[i] += count[i - 1];
        }

        // Build the output array
        for (var i = array.Length - 1; i >= 0; i--)
        {
            output[count[array[i] - min] - 1] = array[i];
            count[array[i] - min]--;
        }

        return output;
    }
}