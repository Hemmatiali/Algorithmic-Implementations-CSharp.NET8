using SearchingLibrary;

namespace SearchingLibraryTests;

/// <summary>
///     Unit tests for the BinarySearch class.
/// </summary>
public class BinarySearchTests
{
    /// <summary>
    ///     Tests for the iterative binary search method.
    /// </summary>
    [Fact]
    public void Iterative_Search_FindsTarget()
    {
        // Arrange
        int[] sortedArray = GenerateSortedArray(1000);
        int target = 598;
        int expectedIndex = Array.IndexOf(sortedArray, target);

        // Act
        int result = BinarySearch.Iterative(sortedArray, target);

        // Assert
        Assert.Equal(expectedIndex, result);
    }

    /// <summary>
    ///     Tests for the recursive binary search method.
    /// </summary>
    [Fact]
    public void Recursive_Search_FindsTarget()
    {
        // Arrange
        int[] sortedArray = GenerateSortedArray(1000);
        int target = 374;
        int expectedIndex = Array.IndexOf(sortedArray, target);

        // Act
        int result = BinarySearch.Recursive(sortedArray, target, 0, sortedArray.Length - 1);

        // Assert
        Assert.Equal(expectedIndex, result);
    }

    /// <summary>
    ///     Tests the binary search methods with a target not in the array.
    /// </summary>
    [Fact]
    public void Search_TargetNotInArray_ReturnsMinusOne()
    {
        // Arrange
        int[] sortedArray = GenerateSortedArray(1000);
        int target = 1001;

        // Act & Assert
        Assert.Equal(-1, BinarySearch.Iterative(sortedArray, target));
        Assert.Equal(-1, BinarySearch.Recursive(sortedArray, target, 0, sortedArray.Length - 1));
    }

    /// <summary>
    ///     Tests the binary search methods with an empty array.
    /// </summary>
    [Fact]
    public void Search_EmptyArray_ReturnsMinusOne()
    {
        // Arrange
        int[] emptyArray = [];
        int target = 1;

        // Act & Assert
        Assert.Equal(-1, BinarySearch.Iterative(emptyArray, target));
        Assert.Equal(-1, BinarySearch.Recursive(emptyArray, target, 0, emptyArray.Length - 1));
    }

    /// <summary>
    ///     Tests the binary search methods with a single-element array.
    /// </summary>
    [Fact]
    public void Search_SingleElementArray_ReturnsCorrectIndex()
    {
        // Arrange
        int[] singleElementArray = [5];
        int target = 5;
        int expectedIndex = 0;

        // Act & Assert
        Assert.Equal(expectedIndex, BinarySearch.Iterative(singleElementArray, target));
        Assert.Equal(expectedIndex, BinarySearch.Recursive(singleElementArray, target, 0, singleElementArray.Length - 1));
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