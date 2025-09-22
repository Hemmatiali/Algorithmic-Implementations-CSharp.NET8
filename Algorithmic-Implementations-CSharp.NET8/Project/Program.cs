using SearchingLibrary;
using SortingLibrary;

namespace Project;

/// <summary>
///     Entry point for the console application.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        // Section: Binary Search
        RunBinarySearchDemo();

        // Section: Linear Search
        RunLinearSearchDemo();

        // Section: Sentinel Linear Search
        RunSentinelLinearSearchDemo();

        // Section: Meta Binary Search
        RunMetaBinarySearchDemo();

        // Section: Ternary Search
        RunTernarySearchDemo();

        // Section: Jump Search
        RunJumpSearchDemo();

        // Section: Interpolation Search
        RunInterpolationSearchDemo();

        // Section: Exponential Search
        RunExponentialSearchDemo();

        // Section: Fibonacci Search
        RunFibonacciSearchDemo();

        // Section: Ubiquitous Binary Search
        RunUbiquitousBinarySearchDemo();

        // Section: Selection Sort
        RunSelectionSortDemo();

        // Section: Bubble Sort
        RunBubbleSortDemo();

        // Section: Recursive Bubble Sort
        RunRecursiveBubbleSortDemo();

        // Section: Insertion Sort
        RunInsertionSortDemo();

        // Section: Merge Sort
        RunMergeSortDemo();

        // Section: Quick Sort
        RunQuickSortDemo();

        // Section: Heap Sort
        RunHeapSortDemo();

        // Section: Cycle Sort
        RunCycleSortDemo();

        // Section: Counting Sort
        RunCountingSortDemo();

        // Section: Radix Sort
        RunRadixSortDemo();

        // Section: Bucket Sort
        RunBucketSortDemo();

        // Section: Shell Sort
        RunShellSortDemo();

        // Section: Tim Sort
        RunTimSortDemo();

        // Section: Bitonic Sort
        RunBitonicSortDemo();

        // Section: Odd-Even Sort
        RunOddEvenSortDemo();

        // Section: Intro Sort
        RunIntroSortDemo();

        // Section: Gapped Insertion Sort
        RunGappedInsertionSortDemo();

        // Section: Pancake Sort
        RunPancakeSortDemo();

        // Section: Bogo Sort
        RunBogoSortDemo();

        // Section: Gnome Sort
        RunGnomeSortDemo();

        // Section: Cocktail Sort
        RunCocktailSortDemo();

        // Section: Strand Sort
        RunStrandSortDemo();

        // Section: Spaghetti Sort
        RunSpaghettiSortDemo();
    }

    #region Algorithms

    #region Searching Algorithms

    /// <summary>
    ///     Demonstrates the usage of binary search algorithms.
    /// </summary>
    private static void RunBinarySearchDemo()
    {
        // Create a sorted array for the demonstration
        int[] sortedArray = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

        // Define the target value to search for
        const int target = 8;

        // Perform iterative binary search and display the result
        int iterativeResult = BinarySearch.Iterative(sortedArray, target);
        Console.WriteLine($"Iterative Binary Search: Target found at index {iterativeResult}");

        // Perform recursive binary search and display the result
        int recursiveResult = BinarySearch.Recursive(sortedArray, target, 0, sortedArray.Length - 1);
        Console.WriteLine($"Recursive Binary Search: Target found at index {recursiveResult}");
    }

    /// <summary>
    ///     Demonstrates the usage of linear search algorithms.
    /// </summary>
    private static void RunLinearSearchDemo()
    {
        // Create an array for the demonstration
        int[] array = [10, 90, 82, 7, 65, 5, 4, 32, 21, 10];

        // Define the target value to search for
        const int target = 7;

        // Perform linear search on the array and display the result
        int arrayResult = LinearSearch.Search(array, target);
        Console.WriteLine($"Linear Search in Array: Target found at index {arrayResult}");

        // Create a list for the demonstration
        List<int> list = [10, 90, 82, 65, 5, 4, 32, 21, 10, 7];

        // Perform linear search on the list and display the result
        int listResult = LinearSearch.Search(list, target);
        Console.WriteLine($"Linear Search in List: Target found at index {listResult}");
    }

    /// <summary>
    ///     Demonstrates the usage of sentinel linear search algorithms.
    /// </summary>
    private static void RunSentinelLinearSearchDemo()
    {
        // Create an array for the demonstration
        int[] array = [10, 90, 82, 7, 65, 5, 4, 32, 21, 10];

        // Define the target value to search for
        const int target = 7;

        // Perform sentinel linear search on the array and display the result
        int arrayResult = SentinelLinearSearch.Search(array, target);
        Console.WriteLine($"Sentinel Linear Search in Array: Target found at index {arrayResult}");

        // Create a list for the demonstration
        List<int> list = [10, 90, 82, 65, 5, 4, 32, 21, 10, 7];

        // Perform sentinel linear search on the list and display the result
        int listResult = SentinelLinearSearch.Search(list, target);
        Console.WriteLine($"Sentinel Linear Search in List: Target found at index {listResult}");
    }

    /// <summary>
    ///     Demonstrates the usage of Meta Binary Search algorithms.
    /// </summary>
    private static void RunMetaBinarySearchDemo()
    {
        // Create a sorted array for the demonstration
        int[] sortedArray = [1, 3, 5, 7, 9, 11, 13, 15, 17, 19];

        // Define the target value to search for
        const int target = 15;

        // Perform recursive meta binary search and display the result
        int recursiveResult = MetaBinarySearch.RecursiveSearch(sortedArray, target);
        Console.WriteLine($"Recursive Meta Binary Search: Target found at index {recursiveResult}");

        // Create a sorted list for the demonstration
        List<int> sortedList = [1, 3, 5, 7, 9, 11, 13, 15, 17, 19];

        // Perform bitwise meta binary search and display the result
        int bitwiseResult = MetaBinarySearch.BitwiseSearch(sortedList, target);
        Console.WriteLine($"Bitwise Meta Binary Search: Target found at index {bitwiseResult}");
    }

    /// <summary>
    ///     Demonstrates the usage of Ternary Search algorithms.
    /// </summary>
    private static void RunTernarySearchDemo()
    {
        // Create a sorted array for the demonstration
        int[] sortedArray = [1, 3, 5, 7, 9, 11, 13, 15, 17, 19];

        // Define the target value to search for
        const int target = 13;

        // Perform ternary search and display the result
        int result = TernarySearch.Search(sortedArray, target);
        Console.WriteLine($"Ternary Search: Target found at index {result}");
    }

    /// <summary>
    ///     Demonstrates the usage of Jump Search algorithms.
    /// </summary>
    private static void RunJumpSearchDemo()
    {
        // Create a sorted array for the demonstration
        int[] sortedArray = [1, 3, 5, 7, 9, 11, 13, 15, 17, 19];

        // Define the target value to search for
        const int target = 15;

        // Perform jump search and display the result
        int result = JumpSearch.Search(sortedArray, target);
        Console.WriteLine($"Jump Search: Target found at index {result}");
    }

    /// <summary>
    ///     Demonstrates the usage of Interpolation Search algorithms.
    /// </summary>
    private static void RunInterpolationSearchDemo()
    {
        // Create a sorted array for the demonstration
        int[] sortedArray = [1, 3, 5, 7, 9, 11, 13, 15, 17, 19];

        // Define the target value to search for
        const int target = 15;

        // Perform interpolation search and display the result
        int result = InterpolationSearch.Search(sortedArray, target);
        Console.WriteLine($"Interpolation Search: Target found at index {result}");
    }

    /// <summary>
    ///     Demonstrates the usage of Exponential Search algorithms.
    /// </summary>
    private static void RunExponentialSearchDemo()
    {
        // Create a sorted array for the demonstration
        int[] sortedArray = [1, 3, 5, 7, 9, 11, 13, 15, 17, 19];

        // Define the target value to search for
        const int target = 15;

        // Perform basic exponential search and display the result
        int basicResult = ExponentialSearch.BasicSearch(sortedArray, target);
        Console.WriteLine($"Basic Exponential Search: Target found at index {basicResult}");

        // Perform iterative exponential search and display the result
        int iterativeResult = ExponentialSearch.IterativeSearch(sortedArray, target);
        Console.WriteLine($"Iterative Exponential Search: Target found at index {iterativeResult}");
    }

    /// <summary>
    ///     Demonstrates the usage of Fibonacci Search algorithms.
    /// </summary>
    private static void RunFibonacciSearchDemo()
    {
        // Create a sorted array for the demonstration
        int[] sortedArray = [1, 3, 5, 7, 9, 11, 13, 15, 17, 19];

        // Define the target value to search for
        const int target = 15;

        // Perform Fibonacci search and display the result
        int result = FibonacciSearch.Search(sortedArray, target);
        Console.WriteLine($"Fibonacci Search: Target found at index {result}");
    }

    /// <summary>
    ///     Demonstrates the usage of Ubiquitous Binary Search algorithms.
    /// </summary>
    private static void RunUbiquitousBinarySearchDemo()
    {
        // Create a sorted array for the demonstration
        int[] sortedArray = [1, 2, 2, 2, 3, 4, 4, 5, 6, 7];

        // Define the target value to search for
        const int target = 2;

        // Perform Ubiquitous Binary Search to find the first occurrence and display the result
        int firstOccurrence = UbiquitousBinarySearch.FindFirst(sortedArray, target);
        Console.WriteLine($"UbiquitousBinarySearch: First occurrence of {target}: {firstOccurrence}");

        // Perform Ubiquitous Binary Search to find the last occurrence and display the result
        int lastOccurrence = UbiquitousBinarySearch.FindLast(sortedArray, target);
        Console.WriteLine($"UbiquitousBinarySearch: Last occurrence of {target}: {lastOccurrence}");

        // Perform Ubiquitous Binary Search to count the occurrences and display the result
        int occurrenceCount = UbiquitousBinarySearch.CountOccurrences(sortedArray, target);
        Console.WriteLine($"UbiquitousBinarySearch: {target} appears {occurrenceCount} times in the array");
    }

    #endregion

    #region Sorting Algorithms

    /// <summary>
    ///     Demonstrates the usage of Selection Sort algorithm.
    /// </summary>
    private static void RunSelectionSortDemo()
    {
        // Create an unsorted array for the demonstration
        int[] array = [64, 25, 12, 22, 11];

        Console.WriteLine("Unsorted array:");
        PrintArray(array);

        // Perform Selection Sort and display the result
        SelectionSort.Sort(array);

        Console.WriteLine("Sorted array using Selection Sort:");
        PrintArray(array);
    }

    /// <summary>
    ///     Demonstrates the usage of Bubble Sort algorithm.
    /// </summary>
    private static void RunBubbleSortDemo()
    {
        // Create an unsorted array for the demonstration
        int[] array = [64, 34, 25, 12, 22, 11, 90];

        Console.WriteLine("Unsorted array:");
        PrintArray(array);

        // Perform Bubble Sort and display the result
        BubbleSort.Sort(array);

        Console.WriteLine("Sorted array using Bubble Sort:");
        PrintArray(array);
    }

    /// <summary>
    ///     Demonstrates the usage of Recursive Bubble Sort algorithm.
    /// </summary>
    private static void RunRecursiveBubbleSortDemo()
    {
        // Create an unsorted array for the demonstration
        int[] array = [64, 34, 25, 12, 22, 11, 90];

        Console.WriteLine("Unsorted array:");
        PrintArray(array);

        // Perform Recursive Bubble Sort and display the result
        RecursiveBubbleSort.Sort(array, array.Length);

        Console.WriteLine("Sorted array using Recursive Bubble Sort:");
        PrintArray(array);
    }

    /// <summary>
    ///     Demonstrates the usage of Insertion Sort algorithm.
    /// </summary>
    private static void RunInsertionSortDemo()
    {
        // Create an unsorted array for the demonstration
        int[] array = [12, 11, 13, 5, 6];

        Console.WriteLine("Unsorted array:");
        PrintArray(array);

        // Perform Insertion Sort and display the result
        InsertionSort.Sort(array);

        Console.WriteLine("Sorted array using Insertion Sort:");
        PrintArray(array);
    }

    /// <summary>
    ///     Demonstrates the usage of Merge Sort algorithm.
    /// </summary>
    private static void RunMergeSortDemo()
    {
        // Create an unsorted array for the demonstration
        int[] array = [12, 13, 11, 8, 6, 7];

        Console.WriteLine("Unsorted array:");
        PrintArray(array);

        // Perform Merge Sort and display the result
        MergeSort.Sort(array);

        Console.WriteLine("Sorted array using Merge Sort:");
        PrintArray(array);
    }

    /// <summary>
    ///     Demonstrates the usage of Quick Sort algorithm.
    /// </summary>
    private static void RunQuickSortDemo()
    {
        // Create an unsorted array for the demonstration
        int[] array = [12, 7, 14, 9, 10, 11];

        Console.WriteLine("Unsorted array:");
        PrintArray(array);

        // Perform Quick Sort and display the result
        QuickSort.Sort(array, 0, array.Length - 1);

        Console.WriteLine("Sorted array using Quick Sort:");
        PrintArray(array);
    }

    /// <summary>
    ///     Demonstrates the usage of Heap Sort algorithm.
    /// </summary>
    private static void RunHeapSortDemo()
    {
        // Create an unsorted array for the demonstration
        int[] array = [12, 11, 13, 5, 6, 7];

        Console.WriteLine("Unsorted array:");
        PrintArray(array);

        // Perform Heap Sort and display the result
        HeapSort.Sort(array);

        Console.WriteLine("Sorted array using Heap Sort:");
        PrintArray(array);
    }

    /// <summary>
    ///     Demonstrates the usage of Cycle Sort algorithm.
    /// </summary>
    private static void RunCycleSortDemo()
    {
        // Create an unsorted array for the demonstration
        int[] array = [12, 11, 13, 5, 6, 7];

        Console.WriteLine("Unsorted array:");
        PrintArray(array);

        // Perform Cycle Sort and display the result
        CycleSort.Sort(array);

        Console.WriteLine("Sorted array using Cycle Sort:");
        PrintArray(array);
    }

    /// <summary>
    ///     Demonstrates the usage of Counting Sort algorithm.
    /// </summary>
    private static void RunCountingSortDemo()
    {
        // Create an unsorted array for the demonstration
        int[] array = [4, 2, 2, 8, 3, 3, 1];

        Console.WriteLine("Unsorted array:");
        PrintArray(array);

        // Perform Counting Sort and display the result
        int[] sortedArray = CountingSort.Sort(array);

        Console.WriteLine("Sorted array using Counting Sort:");
        PrintArray(sortedArray);
    }

    /// <summary>
    ///     Demonstrates the usage of Radix Sort algorithm.
    /// </summary>
    private static void RunRadixSortDemo()
    {
        // Create an unsorted array for the demonstration
        int[] array = [170, 45, 75, 90, 802, 24, 2, 66];

        Console.WriteLine("Unsorted array:");
        PrintArray(array);

        // Perform Radix Sort and display the result
        RadixSort.Sort(array);

        Console.WriteLine("Sorted array using Radix Sort:");
        PrintArray(array);
    }

    /// <summary>
    ///     Demonstrates the usage of Bucket Sort algorithm.
    /// </summary>
    private static void RunBucketSortDemo()
    {
        // Create an unsorted array for the demonstration
        float[] array = [0.897f, 0.565f, 0.656f, 0.1234f, 0.665f, 0.3434f];

        Console.WriteLine("Unsorted array:");
        PrintArray(array);

        // Perform Bucket Sort and display the result
        BucketSort.Sort(array);

        Console.WriteLine("Sorted array using Bucket Sort:");
        PrintArray(array);
    }

    /// <summary>
    ///     Demonstrates the usage of Shell Sort algorithm.
    /// </summary>
    private static void RunShellSortDemo()
    {
        // Generate a random array of integers
        Random random = new();
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101); // Random integers between 1 and 100
        }

        Console.WriteLine("Unsorted array:");
        PrintArray(array);

        // Perform Shell Sort and display the result
        ShellSort.Sort(array);

        Console.WriteLine("Sorted array using Shell Sort:");
        PrintArray(array);
    }

    /// <summary>
    ///     Demonstrates the usage of Tim Sort algorithm.
    /// </summary>
    private static void RunTimSortDemo()
    {
        // Generate a random array of integers
        Random random = new();
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101); // Random integers between 1 and 100
        }

        Console.WriteLine("Unsorted array:");
        PrintArray(array);

        // Perform Tim Sort and display the result
        TimSort.Sort(array);

        Console.WriteLine("Sorted array using Tim Sort:");
        PrintArray(array);
    }

    /// <summary>
    ///     Demonstrates the usage of Bitonic Sort algorithm.
    /// </summary>
    private static void RunBitonicSortDemo()
    {
        // Random array with length as a power of 2 like 8
        Random random = new();
        int[] array = new int[8];
        for (int i = 0; i < array.Length; i++)
        {
            // Random integers between 1 and 100
            array[i] = random.Next(1, 101); 
        }

        Console.WriteLine("Unsorted array:");
        PrintArray(array);

        BitonicSort.Sort(array);

        Console.WriteLine("Sorted array using Bitonic Sort:");
        PrintArray(array);
    }

    /// <summary>
    ///     Demonstrates the usage of Odd-Even Sort algorithm.
    /// </summary>
    private static void RunOddEvenSortDemo()
    {
        // Generate a random array of integers
        Random random = new();
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101); // Random integers between 1 and 100
        }

        Console.WriteLine("Unsorted array:");
        PrintArray(array);

        // Perform Odd-Even Sort and display the result
        OddEvenSort.Sort(array);

        Console.WriteLine("Sorted array using Odd-Even Sort:");
        PrintArray(array);
    }


    /// <summary>
    ///     Demonstrates the usage of Intro Sort algorithm.
    /// </summary>
    private static void RunIntroSortDemo()
    {
        // Generate a random array of integers
        Random random = new();
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101); // Random integers between 1 and 100
        }

        Console.WriteLine("Unsorted array:");
        PrintArray(array);

        // Perform Intro Sort and display the result
        IntroSort.Sort(array);

        Console.WriteLine("Sorted array using Intro Sort:");
        PrintArray(array);
    }


    /// <summary>
    ///     Demonstrates the usage of Gapped Insertion Sort (Shell-style sequence of gaps).
    /// </summary>
    private static void RunGappedInsertionSortDemo()
    {
        // Generate a random array of integers
        Random random = new();
        int[] array = new int[12];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101); // Random integers between 1 and 100
        }

        Console.WriteLine("Unsorted array:");
        PrintArray(array);

        // Apply gapped insertion passes with a simple Shell sequence: n/2, n/4, ..., 1
        for (int gap = array.Length / 2; gap >= 1; gap /= 2)
        {
            GappedInsertionSort.Sort(array, gap);
        }

        Console.WriteLine("Sorted array using Gapped Insertion (Shell-style):");
        PrintArray(array);
    }


    /// <summary>
    ///     Demonstrates the usage of Pancake Sort algorithm.
    /// </summary>
    private static void RunPancakeSortDemo()
    {
        // Generate a random array of integers
        Random random = new();
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101); // Random integers between 1 and 100
        }

        Console.WriteLine("Unsorted array:");
        PrintArray(array);

        // Perform Pancake Sort and display the result
        PancakeSort.Sort(array);

        Console.WriteLine("Sorted array using Pancake Sort:");
        PrintArray(array);
    }


    /// <summary>
    ///     Demonstrates the usage of Bogo Sort algorithm (educational; small n only).
    /// </summary>
    private static void RunBogoSortDemo()
    {
        // Generate a small random array (Bogo Sort is extremely slow for larger n)
        Random random = new();
        int[] array = new int[6];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 21); // Random integers between 1 and 20
        }

        Console.WriteLine("Unsorted array:");
        PrintArray(array);

        try
        {
            // Limit shuffles to avoid non-terminating behavior
            BogoSort.Sort(array, maxShuffles: 10_000);

            Console.WriteLine("Sorted array using Bogo Sort:");
            PrintArray(array);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Bogo Sort aborted: {ex.Message}");
        }
    }


    /// <summary>
    ///     Demonstrates the usage of Gnome Sort algorithm.
    /// </summary>
    private static void RunGnomeSortDemo()
    {
        // Generate a random array of integers
        Random random = new();
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101); // Random integers between 1 and 100
        }

        Console.WriteLine("Unsorted array:");
        PrintArray(array);

        // Perform Gnome Sort and display the result
        GnomeSort.Sort(array);

        Console.WriteLine("Sorted array using Gnome Sort:");
        PrintArray(array);
    }

    /// <summary>
    ///     Demonstrates the usage of Cocktail Sort algorithm.
    /// </summary>
    private static void RunCocktailSortDemo()
    {
        // Generate a random array of integers
        Random random = new();
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101); // Random integers between 1 and 100
        }

        Console.WriteLine("Unsorted array:");
        PrintArray(array);

        // Perform Cocktail Sort and display the result
        CocktailSort.Sort(array);

        Console.WriteLine("Sorted array using Cocktail Sort:");
        PrintArray(array);
    }

    /// <summary>
    ///     Demonstrates the usage of Strand Sort algorithm.
    /// </summary>
    private static void RunStrandSortDemo()
    {
        // Generate a random array of integers
        Random random = new();
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101); // Random integers between 1 and 100
        }

        Console.WriteLine("Unsorted array:");
        PrintArray(array);

        // Perform Strand Sort and display the result
        StrandSort.Sort(array);

        Console.WriteLine("Sorted array using Strand Sort:");
        PrintArray(array);
    }


    /// <summary>
    ///     Demonstrates the usage of Spaghetti Sort algorithm.
    /// </summary>
    private static void RunSpaghettiSortDemo()
    {
        // Generate a random array of integers
        Random random = new();
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-50, 101); // Random integers between -50 and 100
        }

        Console.WriteLine("Unsorted array:");
        PrintArray(array);

        // Perform Spaghetti Sort and display the result
        SpaghettiSort.Sort(array);

        Console.WriteLine("Sorted array using Spaghetti Sort:");
        PrintArray(array);
    }

    /// <summary>
    ///     Prints the elements of an array.
    /// </summary>
    /// <param name="array">The array to be printed.</param>
    private static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    /// <summary>
    ///     Prints the elements of a float array.
    /// </summary>
    /// <param name="array">The array to be printed.</param>
    private static void PrintArray(float[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    #endregion

    #endregion
}