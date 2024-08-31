using SearchingLibrary;

namespace SearchingLibraryTests;

/// <summary>
///     Unit tests for the FibonacciSearch class.
/// </summary>
public class FibonacciSearchTests
{
    /// <summary>
    ///     Tests the Fibonacci search method with a sorted array.
    /// </summary>
    [Fact]
    public void Search_FindsTarget()
    {
        // Arrange
        int[] sortedArray = GenerateSortedArray(1000);
        int target = 724;
        int expectedIndex = Array.IndexOf(sortedArray, target);

        // Act
        int result = FibonacciSearch.Search(sortedArray, target);

        // Assert
        Assert.Equal(expectedIndex, result);
    }

    /// <summary>
    ///     Tests the Fibonacci search method with a target not in the array.
    /// </summary>
    [Fact]
    public void Search_TargetNotInArray_ReturnsMinusOne()
    {
        // Arrange
        int[] sortedArray = GenerateSortedArray(1000);
        int target = 1500;

        // Act
        int result = FibonacciSearch.Search(sortedArray, target);

        // Assert
        Assert.Equal(-1, result);
    }

    /// <summary>
    ///     Tests the Fibonacci search method with an empty array.
    /// </summary>
    [Fact]
    public void Search_EmptyArray_ReturnsMinusOne()
    {
        // Arrange
        int[] emptyArray = [];
        int target = 10;

        // Act
        int result = FibonacciSearch.Search(emptyArray, target);

        // Assert
        Assert.Equal(-1, result);
    }

    /// <summary>
    ///     Tests the Fibonacci search method with a single-element array.
    /// </summary>
    [Fact]
    public void Search_SingleElementArray_ReturnsCorrectIndex()
    {
        // Arrange
        int[] singleElementArray = [15];
        int target = 15;
        int expectedIndex = 0;

        // Act
        int result = FibonacciSearch.Search(singleElementArray, target);

        // Assert
        Assert.Equal(expectedIndex, result);
    }

    /// <summary>
    ///     Tests the Fibonacci search method with a target that is the first element.
    /// </summary>
    [Fact]
    public void Search_FirstElement_ReturnsCorrectIndex()
    {
        // Arrange
        int[] sortedArray = GenerateSortedArray(1000);
        int target = 1;
        int expectedIndex = 0;

        // Act
        int result = FibonacciSearch.Search(sortedArray, target);

        // Assert
        Assert.Equal(expectedIndex, result);
    }

    /// <summary>
    ///     Tests the Fibonacci search method with a target that is the last element.
    /// </summary>
    [Fact]
    public void Search_LastElement_ReturnsCorrectIndex()
    {
        // Arrange
        int[] sortedArray = GenerateSortedArray(1000);
        int target = 1000;
        int expectedIndex = sortedArray.Length - 1;

        // Act
        int result = FibonacciSearch.Search(sortedArray, target);

        // Assert
        Assert.Equal(expectedIndex, result);
    }

    /// <summary>
    ///     Generates a sorted array of integers from 1 to length.
    /// </summary>
    /// <param name="length">The length of the array to generate.</param>
    /// <returns>A sorted array of integers.</returns>
    private int[] GenerateSortedArray(int length)
    {
        var array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = i + 1;
        }
        return array;
    }
}