namespace SortingLibrary;


/// <summary>
///     Class containing methods for performing Shell Sort.
/// </summary>
public static class ShellSort
{
    /// <summary>
    ///     Sorts an array of integers using the Shell Sort algorithm.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    public static void Sort(int[] array)
    {
        if (array == null || array.Length <= 1)
        {
            return; 
        }

        // Start with a gap of half the array length, then reduce it each iteration
        int n = array.Length;
        for (int gap = n / 2; gap > 0; gap /= 2)
        {
            // Perform a gapped insertion sort for each gap size
            for (int i = gap; i < n; i++)
            {
                int temp = array[i];
                int j = i;

                // Shift elements until the correct position for temp is found
                while (j >= gap && array[j - gap] > temp)
                {
                    array[j] = array[j - gap];
                    j -= gap;
                }

                // Place the current element at its correct position
                array[j] = temp;
            }
        }
    }
}
