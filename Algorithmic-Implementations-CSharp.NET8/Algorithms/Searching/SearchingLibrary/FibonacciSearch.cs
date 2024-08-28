namespace SearchingLibrary;

/// <summary>
///     Class containing methods for performing Fibonacci Search.
/// </summary>
public static class FibonacciSearch
{
    /// <summary>
    ///     Performs a Fibonacci search on a sorted array.
    /// </summary>
    /// <param name="array">The sorted array to search in.</param>
    /// <param name="target">The value to search for.</param>
    /// <returns>The index of the target if found; otherwise, -1.</returns>
    public static int Search(int[] array, int target)
    {
        int n = array.Length;

        // Check array
        if (n == 0)
            return -1;

        // Initialize Fibonacci numbers
        int fibMm2 = 0; // (m-2)'th Fibonacci number
        int fibMm1 = 1; // (m-1)'th Fibonacci number
        int fibM = fibMm2 + fibMm1; // m'th Fibonacci number

        // fibM is going to store the smallest Fibonacci number greater than or equal to n
        while (fibM < n)
        {
            fibMm2 = fibMm1;
            fibMm1 = fibM;
            fibM = fibMm2 + fibMm1;
        }

        // Marks the eliminated range from front
        int offset = -1;

        // While there are elements to be inspected
        while (fibM > 1)
        {
            // Check if fibMm2 is a valid location
            int i = Math.Min(offset + fibMm2, n - 1);

            // If target is greater than the value at index i, cut the subarray array from offset to i
            if (array[i] < target)
            {
                fibM = fibMm1;
                fibMm1 = fibMm2;
                fibMm2 = fibM - fibMm1;
                offset = i;
            }
            // If target is less than the value at index i, cut the subarray after i+1
            else if (array[i] > target)
            {
                fibM = fibMm2;
                fibMm1 = fibMm1 - fibMm2;
                fibMm2 = fibM - fibMm1;
            }
            // Target found
            else
            {
                return i;
            }
        }

        // Check if the target is the last element and within bounds
        if (fibMm1 == 1 && offset + 1 < n && array[offset + 1] == target)
        {
            return offset + 1;
        }

        // Target not found
        return -1;
    }
}
