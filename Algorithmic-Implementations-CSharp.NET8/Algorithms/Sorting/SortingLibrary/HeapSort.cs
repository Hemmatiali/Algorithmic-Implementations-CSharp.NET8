namespace SortingLibrary;

/// <summary>
///     Class containing methods for performing Heap Sort.
/// </summary>
public static class HeapSort
{
    /// <summary>
    ///     Sorts an array of integers using the Heap Sort algorithm.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    public static void Sort(int[] array)
    {
        int n = array.Length;

        // Build max heap
        for (int i = (n / 2) - 1; i >= 0; i--)
        {
            Heapify(array, n, i);
        }

        // One by one extract elements from the heap
        for (int i = n - 1; i >= 0; i--)
        {
            // Move the current root (largest element) to the end of the array
            Swap(ref array[0], ref array[i]);

            // Heapify the reduced heap
            Heapify(array, i, 0);
        }
    }

    /// <summary>
    ///     Ensures that the subtree rooted at index i is a valid max heap.
    /// </summary>
    /// <param name="array">The array representation of the heap.</param>
    /// <param name="n">The size of the heap.</param>
    /// <param name="i">The index of the root of the subtree to heapify.</param>
    private static void Heapify(int[] array, int n, int i)
    {
        int largest = i;  // Initialize largest as root
        int left = 2 * i + 1;  // Left child
        int right = 2 * i + 2;  // Right child

        // If left child is larger than root
        if (left < n && array[left] > array[largest])
        {
            largest = left;
        }

        // If right child is larger than largest so far
        if (right < n && array[right] > array[largest])
        {
            largest = right;
        }

        // If largest is not root
        if (largest != i)
        {
            Swap(ref array[i], ref array[largest]);

            // Recursively heapify the affected subtree
            Heapify(array, n, largest);
        }
    }

    /// <summary>
    ///     Swaps two elements in the array.
    /// </summary>
    /// <param name="a">Reference to the first element.</param>
    /// <param name="b">Reference to the second element.</param>
    private static void Swap(ref int a, ref int b)
    {
        (a, b) = (b, a);
    }
}