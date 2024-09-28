namespace SortingLibrary;

/// <summary>
///     Class containing methods for performing Insertion Sort.
/// </summary>
public static class InsertionSort
{
    /// <summary>
    ///     Sorts an array of integers using the Insertion Sort algorithm.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    public static void Sort(int[] array)
    {
        var n = array.Length;

        // Traverse through 1 to n elements
        for (var i = 1; i < n; i++)
        {
            var temp = array[i];
            var j = i - 1;

            // Move elements of array[0..i-1], that are greater than key, to one position ahead of their current position
            while (j >= 0 && array[j] > temp)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = temp;
        }
    }
}