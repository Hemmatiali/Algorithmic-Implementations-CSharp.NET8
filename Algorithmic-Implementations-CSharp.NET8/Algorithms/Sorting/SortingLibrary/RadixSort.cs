namespace SortingLibrary;

/// <summary>
///     Class containing methods for performing Radix Sort.
/// </summary>
public static class RadixSort
{
    /// <summary>
    ///     Sorts an array of integers using the Radix Sort algorithm.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    public static void Sort(int[] array)
    {
        if (array.Length == 0)
        {
            return; // Return if the array is empty
        }

        // Find the maximum number to determine the number of digits
        int max = FindMax(array);

        // Perform counting sort for each digit
        for (int exp = 1; max / exp > 0; exp *= 10)
        {
            CountingSortByDigit(array, exp);
        }
    }

    /// <summary>
    ///     Finds the maximum value in the array.
    /// </summary>
    /// <param name="array">The array to search.</param>
    /// <returns>The maximum value in the array.</returns>
    private static int FindMax(int[] array)
    {
        int max = array[0];
        foreach (var num in array)
        {
            if (num > max)
            {
                max = num;
            }
        }
        return max;
    }

    /// <summary>
    ///     Performs counting sort on the array based on the specified digit.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    /// <param name="exp">The current digit's place value (1, 10, 100, etc.).</param>
    private static void CountingSortByDigit(int[] array, int exp)
    {
        var n = array.Length;
        var output = new int[n]; // Output array to store sorted elements
        var count = new int[10]; // There are 10 possible digits (0-9)

        // Count occurrences of each digit
        for (var i = 0; i < n; i++)
        {
            var digit = (array[i] / exp) % 10;
            count[digit]++;
        }

        // Update count array to store cumulative counts
        for (var i = 1; i < 10; i++)
        {
            count[i] += count[i - 1];
        }

        // Build the output array in reverse to maintain stability
        for (var i = n - 1; i >= 0; i--)
        {
            var digit = (array[i] / exp) % 10;
            output[count[digit] - 1] = array[i];
            count[digit]--;
        }

        // Copy the output array back to the original array
        for (var i = 0; i < n; i++)
        {
            array[i] = output[i];
        }
    }
}
