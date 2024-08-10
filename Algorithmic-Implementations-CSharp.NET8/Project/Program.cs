using SearchingLibrary;

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
        int[] array = { 10, 90, 82, 7, 65, 5, 4, 32, 21, 10 };

        // Define the target value to search for
        const int target = 7;

        // Perform sentinel linear search on the array and display the result
        int arrayResult = SentinelLinearSearch.Search(array, target);
        Console.WriteLine($"Sentinel Linear Search in Array: Target found at index {arrayResult}");

        // Create a list for the demonstration
        List<int> list = new List<int> { 10, 90, 82, 65, 5, 4, 32, 21, 10, 7 };

        // Perform sentinel linear search on the list and display the result
        int listResult = SentinelLinearSearch.Search(list, target);
        Console.WriteLine($"Sentinel Linear Search in List: Target found at index {listResult}");
    }

    #endregion

    #endregion

}