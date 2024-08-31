using SearchingLibrary;

namespace SearchingLibraryTests;

/// <summary>
///     Unit tests for the UbiquitousBinarySearch class.
/// </summary>
public class UbiquitousBinarySearchTests
{
    /// <summary>
    ///     Tests the FindFirst method with a sorted array containing multiple occurrences of the target.
    /// </summary>
    [Fact]
    public void FindFirst_FindsFirstOccurrence()
    {
        // Arrange
        int[] sortedArray = [1, 2, 2, 2, 3, 4, 4, 5, 6, 7];
        int target = 2;
        int expectedIndex = 1;

        // Act
        int result = UbiquitousBinarySearch.FindFirst(sortedArray, target);

        // Assert
        Assert.Equal(expectedIndex, result);
    }

    /// <summary>
    ///     Tests the FindLast method with a sorted array containing multiple occurrences of the target.
    /// </summary>
    [Fact]
    public void FindLast_FindsLastOccurrence()
    {
        // Arrange
        int[] sortedArray = [1, 2, 2, 2, 3, 4, 4, 5, 6, 7];
        int target = 2;
        int expectedIndex = 3;

        // Act
        int result = UbiquitousBinarySearch.FindLast(sortedArray, target);

        // Assert
        Assert.Equal(expectedIndex, result);
    }

    /// <summary>
    ///     Tests the CountOccurrences method with a sorted array containing multiple occurrences of the target.
    /// </summary>
    [Fact]
    public void CountOccurrences_CountsAllOccurrences()
    {
        // Arrange
        int[] sortedArray = [1, 2, 2, 2, 3, 4, 4, 5, 6, 7];
        int target = 2;
        int expectedCount = 3;

        // Act
        int result = UbiquitousBinarySearch.CountOccurrences(sortedArray, target);

        // Assert
        Assert.Equal(expectedCount, result);
    }

    /// <summary>
    ///     Tests the FindFirst method with a sorted array where the target does not exist.
    /// </summary>
    [Fact]
    public void FindFirst_TargetNotInArray_ReturnsMinusOne()
    {
        // Arrange
        int[] sortedArray = [1, 2, 2, 2, 3, 4, 4, 5, 6, 7];
        int target = 10;

        // Act
        int result = UbiquitousBinarySearch.FindFirst(sortedArray, target);

        // Assert
        Assert.Equal(-1, result);
    }

    /// <summary>
    ///     Tests the FindLast method with a sorted array where the target does not exist.
    /// </summary>
    [Fact]
    public void FindLast_TargetNotInArray_ReturnsMinusOne()
    {
        // Arrange
        int[] sortedArray = [1, 2, 2, 2, 3, 4, 4, 5, 6, 7];
        int target = 10;

        // Act
        int result = UbiquitousBinarySearch.FindLast(sortedArray, target);

        // Assert
        Assert.Equal(-1, result);
    }

    /// <summary>
    ///     Tests the CountOccurrences method with a sorted array where the target does not exist.
    /// </summary>
    [Fact]
    public void CountOccurrences_TargetNotInArray_ReturnsZero()
    {
        // Arrange
        int[] sortedArray = [1, 2, 2, 2, 3, 4, 4, 5, 6, 7];
        int target = 10;

        // Act
        int result = UbiquitousBinarySearch.CountOccurrences(sortedArray, target);

        // Assert
        Assert.Equal(0, result);
    }

    /// <summary>
    ///     Tests the FindFirst method with a sorted array containing a single occurrence of the target.
    /// </summary>
    [Fact]
    public void FindFirst_SingleOccurrence_ReturnsCorrectIndex()
    {
        // Arrange
        int[] sortedArray = [1, 2, 3, 4, 5, 6, 7];
        int target = 4;
        int expectedIndex = 3;

        // Act
        int result = UbiquitousBinarySearch.FindFirst(sortedArray, target);

        // Assert
        Assert.Equal(expectedIndex, result);
    }

    /// <summary>
    ///     Tests the FindLast method with a sorted array containing a single occurrence of the target.
    /// </summary>
    [Fact]
    public void FindLast_SingleOccurrence_ReturnsCorrectIndex()
    {
        // Arrange
        int[] sortedArray = [1, 2, 3, 4, 5, 6, 7];
        int target = 4;
        int expectedIndex = 3;

        // Act
        int result = UbiquitousBinarySearch.FindLast(sortedArray, target);

        // Assert
        Assert.Equal(expectedIndex, result);
    }

    /// <summary>
    ///     Tests the CountOccurrences method with a sorted array containing a single occurrence of the target.
    /// </summary>
    [Fact]
    public void CountOccurrences_SingleOccurrence_ReturnsOne()
    {
        // Arrange
        int[] sortedArray = [1, 2, 3, 4, 5, 6, 7];
        int target = 4;
        int expectedCount = 1;

        // Act
        int result = UbiquitousBinarySearch.CountOccurrences(sortedArray, target);

        // Assert
        Assert.Equal(expectedCount, result);
    }

    /// <summary>
    ///     Tests the FindFirst method with an empty array.
    /// </summary>
    [Fact]
    public void FindFirst_EmptyArray_ReturnsMinusOne()
    {
        // Arrange
        int[] emptyArray = [];
        int target = 1;

        // Act
        int result = UbiquitousBinarySearch.FindFirst(emptyArray, target);

        // Assert
        Assert.Equal(-1, result);
    }

    /// <summary>
    ///     Tests the FindLast method with an empty array.
    /// </summary>
    [Fact]
    public void FindLast_EmptyArray_ReturnsMinusOne()
    {
        // Arrange
        int[] emptyArray = [];
        int target = 1;

        // Act
        int result = UbiquitousBinarySearch.FindLast(emptyArray, target);

        // Assert
        Assert.Equal(-1, result);
    }

    /// <summary>
    ///     Tests the CountOccurrences method with an empty array.
    /// </summary>
    [Fact]
    public void CountOccurrences_EmptyArray_ReturnsZero()
    {
        // Arrange
        int[] emptyArray = [];
        int target = 1;

        // Act
        int result = UbiquitousBinarySearch.CountOccurrences(emptyArray, target);

        // Assert
        Assert.Equal(0, result);
    }
}