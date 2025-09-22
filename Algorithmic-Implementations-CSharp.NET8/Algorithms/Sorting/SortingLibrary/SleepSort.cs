namespace SortingLibrary;

/// <summary>
///     Class containing methods for performing Sleep Sort (asynchronous simulation).
///     WARNING: Sleep Sort is a novelty algorithm and not suitable for production use.
///     This implementation is deterministic: tasks wait for their turn to emit,
///     so the final output is correctly sorted even with scheduler jitter.
/// </summary>
public static class SleepSort
{
    /// <summary>
    ///     Sorts an array of integers using the Sleep Sort idea: items are scheduled with
    ///     delays proportional to their values. A guard prevents excessive total delay.
    ///     The method modifies the array in place.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    /// <param name="unitDelayMs">
    ///     Milliseconds to wait per unit difference between values (default 1 ms).
    ///     Keep small (e.g., 1–5) to avoid long sleeps.
    /// </param>
    /// <param name="maxTotalDelayMs">
    ///     Upper bound on total delay budget across the full value range; if exceeded, an exception is thrown.
    ///     This prevents pathological delays for very large ranges.
    /// </param>
    public static void Sort(int[] array, int unitDelayMs = 1, int maxTotalDelayMs = 30_000)
    {
        if (array == null || array.Length <= 1)
        {
            return; // Nothing to sort
        }

        if (unitDelayMs <= 0)
        {
            unitDelayMs = 1; // Sanitize
        }

        // Find min and max to compute relative delays
        int min = array[0], max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min) min = array[i];
            if (array[i] > max) max = array[i];
        }

        long range = (long)max - min;                // Non-negative
        long totalDelayBudget = range * unitDelayMs; // In ms

        if (totalDelayBudget > maxTotalDelayMs)
        {
            throw new InvalidOperationException(
                $"SleepSort delay budget exceeded. Range={range}, unitDelayMs={unitDelayMs}, " +
                $"required≈{totalDelayBudget} ms, maxTotalDelayMs={maxTotalDelayMs}. " +
                $"Increase maxTotalDelayMs or decrease the value range.");
        }

        // Count occurrences and prepare ordered distinct values
        var counts = new Dictionary<int, int>();
        foreach (int v in array)
        {
            counts.TryGetValue(v, out int c);
            counts[v] = c + 1;
        }

        var valuesAsc = new List<int>(counts.Keys);
        valuesAsc.Sort();

        // Map each distinct value to a sequential order index to avoid gaps/deadlocks
        var orderIndexByValue = new Dictionary<int, int>(valuesAsc.Count);
        for (int i = 0; i < valuesAsc.Count; i++)
        {
            orderIndexByValue[valuesAsc[i]] = i;
        }

        var output = new int[array.Length];
        int writeIndex = 0;
        object gate = new();

        // Ensures tasks emit strictly in ascending value order, regardless of scheduler jitter
        int nextOrderIndex = 0;

        var tasks = new List<Task>(valuesAsc.Count);
        foreach (int value in valuesAsc)
        {
            int count = counts[value];
            int orderIndex = orderIndexByValue[value];

            // Delay proportional to (value - min)
            long delay = ((long)value - min) * unitDelayMs;
            if (delay < 0) delay = 0; // Safety (shouldn't happen)

            tasks.Add(Task.Run(async () =>
            {
                // Sleep proportional to the value
                await Task.Delay((int)delay).ConfigureAwait(false);

                // Deterministically wait for our turn to emit
                var spinner = new SpinWait();
                while (Volatile.Read(ref nextOrderIndex) != orderIndex)
                {
                    spinner.SpinOnce();
                }

                // Emit 'count' copies of this value, then advance the turn
                lock (gate)
                {
                    for (int i = 0; i < count; i++)
                    {
                        output[writeIndex++] = value;
                    }
                    Interlocked.Increment(ref nextOrderIndex);
                }
            }));
        }

        Task.WaitAll(tasks.ToArray());

        // Copy back
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = output[i];
        }
    }
}
