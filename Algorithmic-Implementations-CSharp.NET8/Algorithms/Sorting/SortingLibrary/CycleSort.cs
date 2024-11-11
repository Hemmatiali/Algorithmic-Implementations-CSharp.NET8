namespace SortingLibrary;

/// <summary>
///     Class containing methods for performing Cycle Sort.
/// </summary>
public static class CycleSort
{
    /// <summary>
    ///     Sorts an array of integers using the Cycle Sort algorithm.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    public static void Sort(int[] array)
    {
        int n = array.Length;

        // Traverse the array and sort each cycle
        for (int cycleStart = 0; cycleStart < n - 1; cycleStart++)
        {
            int item = array[cycleStart];

            // Find the correct position for item
            int pos = cycleStart;
            for (int i = cycleStart + 1; i < n; i++)
            {
                if (array[i] < item)
                {
                    pos++;
                }
            }

            // If item is already in the correct position, continue
            if (pos == cycleStart)
            {
                continue;
            }

            // Skip duplicates
            while (item == array[pos])
            {
                pos++;
            }

            // Put the item to its right position
            if (pos != cycleStart)
            {
                (item, array[pos]) = (array[pos], item);
            }

            // Rotate the rest of the cycle
            while (pos != cycleStart)
            {
                pos = cycleStart;

                // Find the position for item
                for (int i = cycleStart + 1; i < n; i++)
                {
                    if (array[i] < item)
                    {
                        pos++;
                    }
                }

                // Skip duplicates
                while (item == array[pos])
                {
                    pos++;
                }

                // Place the item in its correct position
                if (item != array[pos])
                {
                    (item, array[pos]) = (array[pos], item);
                }
            }
        }
    }
}