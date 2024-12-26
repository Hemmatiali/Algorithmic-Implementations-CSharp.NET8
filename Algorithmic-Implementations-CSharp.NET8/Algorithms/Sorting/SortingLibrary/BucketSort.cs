namespace SortingLibrary;

/// <summary>
///     Class containing methods for performing Bucket Sort.
/// </summary>
public static class BucketSort
{
    /// <summary>
    ///     Sorts an array of floats using the Bucket Sort algorithm.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    public static void Sort(float[] array)
    {
        int n = array.Length;
        if (n == 0)
            return; // Return if the array is empty

        // 1) Create n empty buckets
        var buckets = new List<float>[n];
        for (int i = 0; i < n; i++)
        {
            buckets[i] = [];
        }

        // 2) Put array elements in different buckets
        for (int i = 0; i < n; i++)
        {
            int bucketIndex = (int)(n * array[i]);
            buckets[bucketIndex].Add(array[i]);
        }

        // 3) Sort individual buckets using insertion sort
        for (int i = 0; i < n; i++)
        {
            InsertionSort(buckets[i]);
        }

        // 4) Concatenate all buckets into the original array
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            foreach (var num in buckets[i])
            {
                array[index++] = num;
            }
        }

    }

    /// <summary>
    ///     Sorts a list of floats using the Insertion Sort algorithm.
    /// </summary>
    /// <param name="bucket">The list to be sorted.</param>
    private static void InsertionSort(List<float> bucket)
    {
        for (int i = 1; i < bucket.Count; ++i)
        {
            float key = bucket[i];
            int j = i - 1;
            while (j >= 0 && bucket[j] > key)
            {
                bucket[j + 1] = bucket[j];
                j--;
            }
            bucket[j + 1] = key;
        }
    }
}