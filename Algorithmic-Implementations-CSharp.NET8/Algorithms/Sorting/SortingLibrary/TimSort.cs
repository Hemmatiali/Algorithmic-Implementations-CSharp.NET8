namespace SortingLibrary;

/// <summary>
///     Class containing methods for performing Tim Sort.
/// </summary>
public static class TimSort
{
    private const int RUN = 32;

    /// <summary>
    ///     Sorts an array of integers using the Tim Sort algorithm.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    public static void Sort(int[] array)
    {
        int n = array.Length;

        // Step 1: Sort individual subarrays of size RUN using Insertion Sort
        for (int i = 0; i < n; i += RUN)
        {
            InsertionSort(array, i, Math.Min(i + RUN - 1, n - 1));
        }

        // Step 2: Merge subarrays using Merge Sort logic with increasing sizes
        for (int size = RUN; size < n; size = 2 * size)
        {
            for (int left = 0; left < n; left += 2 * size)
            {
                int mid = left + size - 1;
                int right = Math.Min(left + 2 * size - 1, n - 1);

                if (mid < right)
                {
                    Merge(array, left, mid, right);
                }
            }
        }
    }

    /// <summary>
    ///     Performs Insertion Sort on a subarray.
    /// </summary>
    private static void InsertionSort(int[] array, int left, int right)
    {
        for (int i = left + 1; i <= right; i++)
        {
            int temp = array[i];
            int j = i - 1;
            while (j >= left && array[j] > temp)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = temp;
        }
    }

    /// <summary>
    ///     Merges two sorted subarrays: [left..mid] and [mid+1..right].
    /// </summary>
    private static void Merge(int[] array, int left, int mid, int right)
    {
        int len1 = mid - left + 1;
        int len2 = right - mid;

        int[] leftArray = new int[len1];
        int[] rightArray = new int[len2];

        Array.Copy(array, left, leftArray, 0, len1);
        Array.Copy(array, mid + 1, rightArray, 0, len2);

        int i = 0, j = 0, k = left;

        while (i < len1 && j < len2)
        {
            array[k++] = leftArray[i] <= rightArray[j] ? leftArray[i++] : rightArray[j++];
        }

        while (i < len1)
        {
            array[k++] = leftArray[i++];
        }

        while (j < len2)
        {
            array[k++] = rightArray[j++];
        }
    }
}
