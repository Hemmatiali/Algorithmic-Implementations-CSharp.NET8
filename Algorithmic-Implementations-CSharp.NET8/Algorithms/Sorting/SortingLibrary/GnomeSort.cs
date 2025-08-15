namespace SortingLibrary;


/// <summary>
///     Class containing methods for performing Gnome Sort.
/// </summary>
public static class GnomeSort
{
    /// <summary>
    ///     Sorts an array of integers using the Gnome Sort algorithm (ascending order).
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    public static void Sort(int[] array)
    {
        if (array == null || array.Length <= 1)
        {
            return; // Nothing to sort for null or single-element arrays
        }

        int i = 1;          // Current index (the "gnome")
        int n = array.Length;

        // Move forward when in order; step back (like insertion) when out of order
        while (i < n)
        {
            if (array[i] >= array[i - 1])
            {
                i++; // In order, move forward
            }
            else
            {
                // Swap out-of-order adjacent elements
                (array[i], array[i - 1]) = (array[i - 1], array[i]);

                // Step back if possible to continue local fixing; otherwise move forward
                if (i > 1)
                {
                    i--;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}

