namespace SortingLibrary;


/// <summary>
///     Class containing methods for performing Bogo Sort (a.k.a. permutation sort).
///     WARNING: This algorithm is intentionally inefficient and is for educational/demo purposes only.
/// </summary>
public static class BogoSort
{
    /// <summary>
    ///     Sorts an array of integers using the Bogo Sort algorithm by repeatedly shuffling
    ///     the array until it becomes sorted. An optional <paramref name="maxShuffles"/> guard
    ///     limits the number of shuffles to avoid non-terminating behavior on larger inputs.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    /// <param name="maxShuffles">
    ///     Maximum number of shuffles before aborting (defaults to <see cref="int.MaxValue"/>).
    ///     If the limit is reached and the array is still not sorted, an <see cref="InvalidOperationException"/> is thrown.
    /// </param>
    public static void Sort(int[] array, int maxShuffles = int.MaxValue)
    {
        if (array == null || array.Length <= 1)
        {
            return; // Nothing to do for null/single-element arrays
        }

        int attempts = 0;
        var rng = System.Random.Shared; // .NET 6+ thread-safe shared RNG

        // Keep shuffling until the array is sorted or we hit the guard limit
        while (!IsSorted(array))
        {
            if (attempts++ >= maxShuffles)
            {
                throw new System.InvalidOperationException("BogoSort exceeded the maximum number of shuffles without sorting.");
            }

            Shuffle(array, rng);
        }
    }

    /// <summary>
    ///     Determines whether the array is sorted in non-decreasing order.
    /// </summary>
    /// <param name="array">The array to check.</param>
    /// <returns><c>true</c> if sorted; otherwise, <c>false</c>.</returns>
    private static bool IsSorted(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i - 1])
            {
                return false;
            }
        }
        return true;
    }

    /// <summary>
    ///     Shuffles the array in place using the Fisher–Yates algorithm.
    /// </summary>
    /// <param name="array">The array to shuffle.</param>
    /// <param name="rng">Random number generator.</param>
    private static void Shuffle(int[] array, System.Random rng)
    {
        for (int i = array.Length - 1; i > 0; i--)
        {
            int j = rng.Next(i + 1); // 0..i inclusive
            if (j != i)
            {
                (array[i], array[j]) = (array[j], array[i]); // Swap
            }
        }
    }
}

