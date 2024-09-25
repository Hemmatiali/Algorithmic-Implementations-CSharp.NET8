namespace SortingLibrary;

/// <summary>
///     Class containing methods for performing Bubble Sort.
/// </summary>
public static class BubbleSort
{
    /// <summary>
    ///     Sorts an array of integers using the Bubble Sort algorithm.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    public static void Sort(int[] array)
    {
        int n = array.Length;
        bool swapped;

        // Traverse the array
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            // Last i elements are already in place
            for (int j = 0; j < n - i - 1; j++)
            {
                // Swap if the element is greater than the next element
                if (array[j] > array[j + 1])
                {
                    Swap(ref array[j], ref array[j + 1]);
                    swapped = true;
                }
            }

            // If no two elements were swapped by the inner loop, then the array is already sorted
            if (!swapped)
            {
                break;
            }
        }
    }

    /// <summary>
    ///     Swaps two elements in the array.
    /// </summary>
    /// <param name="a">Reference to the first element.</param>
    /// <param name="b">Reference to the second element.</param>
    private static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}