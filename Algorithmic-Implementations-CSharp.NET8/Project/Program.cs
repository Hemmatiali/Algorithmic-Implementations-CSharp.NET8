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

    #endregion

    #endregion
}