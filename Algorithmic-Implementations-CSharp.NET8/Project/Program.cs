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

    #endregion

    #endregion

}