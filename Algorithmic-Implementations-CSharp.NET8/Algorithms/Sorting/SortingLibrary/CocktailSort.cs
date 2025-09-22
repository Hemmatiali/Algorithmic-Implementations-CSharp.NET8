namespace SortingLibrary;

/// <summary>
///     Class containing methods for performing Cocktail (Shaker) Sort.
/// </summary>
public static class CocktailSort
{
    /// <summary>
    ///     Sorts an array of integers in non-decreasing order using the Cocktail Sort algorithm.
    ///     Cocktail Sort is a bidirectional version of Bubble Sort: it traverses the array forward,
    ///     then backward in each pass, bubbling both the largest and smallest elements toward their ends.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    public static void Sort(int[] array)
    {
        if (array == null || array.Length <= 1)
        {
            return; // Nothing to sort for null or single-element arrays
        }

        int start = 0;                 // Beginning of the unsorted region
        int end = array.Length - 1;    // End of the unsorted region
        bool swapped;

        do
        {
            swapped = false;

            // Forward pass: bubble the largest item to the right end
            for (int i = start; i < end; i++)
            {
                if (array[i] > array[i + 1])
                {
                    (array[i], array[i + 1]) = (array[i + 1], array[i]); // Swap
                    swapped = true;
                }
            }

            // If no elements were swapped in the forward pass, array is sorted
            if (!swapped)
            {
                break;
            }

            // Shrink the unsorted region from the right
            end--;
            swapped = false;

            // Backward pass: bubble the smallest item to the left end
            for (int i = end; i > start; i--)
            {
                if (array[i - 1] > array[i])
                {
                    (array[i - 1], array[i]) = (array[i], array[i - 1]); // Swap
                    swapped = true;
                }
            }

            // Shrink the unsorted region from the left
            start++;

        } while (swapped); // Continue until a full bidirectional pass makes no swaps
    }
}
