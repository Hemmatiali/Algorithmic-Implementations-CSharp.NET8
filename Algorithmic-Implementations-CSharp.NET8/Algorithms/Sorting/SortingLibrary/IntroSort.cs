namespace SortingLibrary;


/// <summary>
///     Class containing methods for performing IntroSort (Introspective Sort).
///     IntroSort starts with Quick Sort and falls back to Heap Sort when the recursion depth exceeds a limit,
///     and uses Insertion Sort for small partitions. This guarantees O(n log n) worst-case time.
/// </summary>
public static class IntroSort
{
    // Threshold under which we switch to Insertion Sort for small partitions
    private const int INSERTION_SORT_THRESHOLD = 16;

    /// <summary>
    ///     Sorts an array of integers using the IntroSort algorithm.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    public static void Sort(int[] array)
    {
        if (array == null || array.Length <= 1)
        {
            return; // Nothing to sort
        }

        // Depth limit set to 2 * floor(log2(n)) to prevent Quick Sort worst-case
        int depthLimit = 2 * (int)System.Math.Floor(System.Math.Log(array.Length, 2));
        IntroSortRecursive(array, 0, array.Length - 1, depthLimit);
    }

    /// <summary>
    ///     Recursively sorts the array using Quick Sort until the depth limit is reached,
    ///     then falls back to Heap Sort. For small ranges, uses Insertion Sort.
    /// </summary>
    private static void IntroSortRecursive(int[] array, int left, int right, int depthLimit)
    {
        // Use a loop to reduce recursion depth (tail-recursion elimination on one side)
        while (right - left > INSERTION_SORT_THRESHOLD)
        {
            if (depthLimit == 0)
            {
                // Depth limit reached: use Heap Sort on the current range
                HeapSortRange(array, left, right);
                return;
            }

            depthLimit--;

            // Median-of-three pivot selection to improve partition quality
            int pivotIndex = MedianOfThree(array, left, right);

            // Partition around the pivot and obtain final index
            int p = Partition(array, left, right, pivotIndex);

            // Recurse on smaller partition first to keep recursion shallow
            if (p - left < right - p)
            {
                IntroSortRecursive(array, left, p - 1, depthLimit);
                left = p + 1; // Tail recurse on the right side by adjusting bounds
            }
            else
            {
                IntroSortRecursive(array, p + 1, right, depthLimit);
                right = p - 1; // Tail recurse on the left side by adjusting bounds
            }
        }

        // Small range: finish with Insertion Sort
        InsertionSort(array, left, right);
    }

    /// <summary>
    ///     Partitions the array using Lomuto partition scheme around the element at pivotIndex.
    /// </summary>
    private static int Partition(int[] array, int left, int right, int pivotIndex)
    {
        int pivot = array[pivotIndex];
        Swap(array, pivotIndex, right); // Move pivot to end
        int storeIndex = left;
        for (int i = left; i < right; i++)
        {
            if (array[i] < pivot)
            {
                Swap(array, i, storeIndex);
                storeIndex++;
            }
        }
        Swap(array, storeIndex, right); // Move pivot to its final place
        return storeIndex;
    }

    /// <summary>
    ///     Chooses a pivot index using the median-of-three rule on (left, mid, right).
    /// </summary>
    private static int MedianOfThree(int[] array, int left, int right)
    {
        int mid = left + ((right - left) / 2);

        // Order left, mid, right so that array[left] <= array[mid] <= array[right]
        if (array[mid] < array[left]) Swap(array, left, mid);
        if (array[right] < array[left]) Swap(array, left, right);
        if (array[right] < array[mid]) Swap(array, mid, right);

        return mid; // Median element index
    }

    /// <summary>
    ///     Insertion Sort on the subarray array[left..right].
    /// </summary>
    private static void InsertionSort(int[] array, int left, int right)
    {
        for (int i = left + 1; i <= right; i++)
        {
            int key = array[i];
            int j = i - 1;
            while (j >= left && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key;
        }
    }

    /// <summary>
    ///     Heap Sort restricted to the range array[left..right] (inclusive).
    /// </summary>
    private static void HeapSortRange(int[] array, int left, int right)
    {
        int n = right - left + 1;

        // Build max heap
        for (int i = (n / 2) - 1; i >= 0; i--)
        {
            SiftDown(array, left, n, i);
        }

        // Extract elements one by one from the heap
        for (int end = n - 1; end > 0; end--)
        {
            Swap(array, left, left + end); // Move current max to the end of the range
            SiftDown(array, left, end, 0); // Restore heap on the reduced range
        }
    }

    /// <summary>
    ///     Sifts the element at local index 'i' down the heap for a heap rooted at 'left' with size 'count'.
    /// </summary>
    private static void SiftDown(int[] array, int left, int count, int i)
    {
        while (true)
        {
            int largest = i;
            int l = 2 * i + 1; // left child in local heap indices
            int r = 2 * i + 2; // right child in local heap indices

            if (l < count && array[left + l] > array[left + largest]) largest = l;
            if (r < count && array[left + r] > array[left + largest]) largest = r;

            if (largest == i) break;

            Swap(array, left + i, left + largest);
            i = largest; // Continue sifting down
        }
    }

    /// <summary>
    ///     Swaps two elements in the array.
    /// </summary>
    private static void Swap(int[] array, int i, int j)
    {
        if (i == j) return;
        int tmp = array[i];
        array[i] = array[j];
        array[j] = tmp;
    }
}
