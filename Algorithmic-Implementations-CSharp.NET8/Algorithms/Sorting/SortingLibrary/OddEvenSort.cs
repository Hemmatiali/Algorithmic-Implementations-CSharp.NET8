namespace SortingLibrary;


/// <summary>
///     Class containing methods for performing Odd-Even (Brick) Sort.
/// </summary>
public static class OddEvenSort
{
    /// <summary>
    ///     Sorts an array of integers using the Odd-Even Sort algorithm.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    public static void Sort(int[] array)
    {
        if (array == null || array.Length <= 1)
        {
            return; // No sorting needed for null or single‑element arrays
        }

        int n = array.Length;
        bool sorted;

        // Repeat until no swaps are needed
        do
        {
            sorted = true;

            // Perform Bubble pass on odd indexed pairs (1,2), (3,4), ...
            for (int i = 1; i < n - 1; i += 2)
            {
                if (array[i] > array[i + 1])
                {
                    (array[i], array[i + 1]) = (array[i + 1], array[i]); // Swap
                    sorted = false;
                }
            }

            // Perform Bubble pass on even indexed pairs (0,1), (2,3), ...
            for (int i = 0; i < n - 1; i += 2)
            {
                if (array[i] > array[i + 1])
                {
                    (array[i], array[i + 1]) = (array[i + 1], array[i]); // Swap
                    sorted = false;
                }
            }

        } while (!sorted);
    }
}
