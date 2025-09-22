namespace SortingLibrary;

/// <summary>
///     Class containing methods for performing Bead Sort (a.k.a. Gravity Sort).
///     Note: Bead Sort only works for arrays of <b>non-negative integers</b>.
/// </summary>
public static class BeadSort
{
    /// <summary>
    ///     Sorts an array of non-negative integers in non-decreasing order using the Bead Sort algorithm.
    ///     The algorithm simulates gravity on a grid of beads: each number is represented by that many beads in a row;
    ///     beads "fall" to the bottom in each column, and the final row bead counts form the sorted sequence.
    /// </summary>
    /// <param name="array">The array to be sorted (must contain only non-negative integers).</param>
    /// <exception cref="System.ArgumentOutOfRangeException">Thrown when the input contains negative numbers.</exception>
    public static void Sort(int[] array)
    {
        if (array == null || array.Length <= 1)
        {
            return; // Nothing to sort for null or single-element arrays
        }

        // Bead Sort is defined only for non-negative integers
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                throw new System.ArgumentOutOfRangeException(nameof(array), "Bead Sort supports only non-negative integers.");
            }
        }

        // Find the maximum value to size the bead grid (rows = n, cols = max)
        int max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
        }

        if (max == 0)
        {
            return; // All zeros: already sorted
        }

        int n = array.Length;

        // Grid of beads: rows = elements, columns = potential bead positions up to 'max'
        // Using byte to minimize memory; 0 = empty, 1 = bead
        var beads = new byte[n, max];

        // Place beads for each row: row i has 'array[i]' beads from column 0 to array[i]-1
        for (int i = 0; i < n; i++)
        {
            int beadsInRow = array[i];
            for (int j = 0; j < beadsInRow; j++)
            {
                beads[i, j] = 1;
            }
        }

        // "Gravity" step: for each column, count beads and let them fall to the bottom rows
        for (int col = 0; col < max; col++)
        {
            int count = 0;

            // Count beads in this column and clear the column
            for (int row = 0; row < n; row++)
            {
                if (beads[row, col] == 1)
                {
                    count++;
                    beads[row, col] = 0;
                }
            }

            // Place 'count' beads at the bottom of this column
            for (int row = n - count; row < n; row++)
            {
                beads[row, col] = 1;
            }
        }

        // Read the sorted values: the number of beads in each row (from top to bottom) is non-decreasing
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = 0; j < max; j++)
            {
                if (beads[i, j] == 1) sum++;
            }
            array[i] = sum;
        }
    }
}
