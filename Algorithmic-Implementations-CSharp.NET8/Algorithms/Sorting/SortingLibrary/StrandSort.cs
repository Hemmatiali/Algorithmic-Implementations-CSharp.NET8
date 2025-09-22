namespace SortingLibrary;

/// <summary>
///     Class containing methods for performing Strand Sort.
/// </summary>
public static class StrandSort
{
    /// <summary>
    ///     Sorts an array of integers using the Strand Sort algorithm.
    ///     The algorithm repeatedly extracts increasing subsequences (strands) from the input
    ///     and merges them into the result.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    public static void Sort(int[] array)
    {
        if (array == null || array.Length <= 1)
        {
            return; // Nothing to sort for null or single-element arrays
        }

        var input = new List<int>(array);
        var result = new List<int>(array.Length);

        // Repeatedly extract strands and merge into result
        while (input.Count > 0)
        {
            var strand = ExtractStrand(input);
            result = Merge(result, strand);
        }

        // Copy the sorted result back to the original array
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = result[i];
        }
    }

    /// <summary>
    ///     Extracts a single increasing strand from the input list, removing its elements from <paramref name="input"/>.
    /// </summary>
    /// <param name="input">The list to extract from (will be modified).</param>
    /// <returns>An increasing subsequence (strand).</returns>
    private static List<int> ExtractStrand(List<int> input)
    {
        var strand = new List<int>();

        // Start strand with the first remaining element
        strand.Add(input[0]);
        input.RemoveAt(0);

        int last = strand[^1];

        // Greedily append elements that continue the non-decreasing order
        for (int i = 0; i < input.Count;)
        {
            if (input[i] >= last)
            {
                last = input[i];
                strand.Add(input[i]);
                input.RemoveAt(i); // Remove consumed element; do not advance i
            }
            else
            {
                i++; // Skip this element for this strand
            }
        }

        return strand;
    }

    /// <summary>
    ///     Merges two sorted lists into a new sorted list (stable).
    /// </summary>
    /// <param name="left">First sorted list.</param>
    /// <param name="right">Second sorted list.</param>
    /// <returns>Merged sorted list.</returns>
    private static List<int> Merge(List<int> left, List<int> right)
    {
        int n = left.Count + right.Count;
        var merged = new List<int>(n);

        int i = 0, j = 0;
        while (i < left.Count && j < right.Count)
        {
            if (left[i] <= right[j]) // '<=' keeps the merge stable
            {
                merged.Add(left[i]);
                i++;
            }
            else
            {
                merged.Add(right[j]);
                j++;
            }
        }

        // Append any remaining elements
        while (i < left.Count) merged.Add(left[i++]);
        while (j < right.Count) merged.Add(right[j++]);

        return merged;
    }
}
