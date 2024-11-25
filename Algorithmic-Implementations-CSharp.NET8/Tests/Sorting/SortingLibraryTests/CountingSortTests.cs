using SortingLibrary;

namespace SortingLibraryTests;

/// <summary>
///     Unit tests for the CountingSort class.
/// </summary>
public class CountingSortTests
{
    /// <summary>
    ///     Tests Counting Sort with a random unsorted array.
    /// </summary>
    [Fact]
    public void Sort_RandomUnsortedArray_ReturnsSortedArray()
    {
        // Arrange
        int[] unsortedArray = [4, 2, 2, 8, 3, 3, 1];
        int[] expectedArray = [1, 2, 2, 3, 3, 4, 8];

        // Act
        var sortedArray = CountingSort.Sort(unsortedArray);

        // Assert
        Assert.Equal(expectedArray, sortedArray);
    }

    /// <summary>
    ///     Tests Counting Sort with an already sorted array.
    /// </summary>
    [Fact]
    public void Sort_AlreadySortedArray_ReturnsSameArray()
    {
        // Arrange
        int[] sortedArray = [1, 2, 3, 4, 5];
        int[] expectedArray = [1, 2, 3, 4, 5];

        // Act
        var result = CountingSort.Sort(sortedArray);

        // Assert
        Assert.Equal(expectedArray, result);
    }

    /// <summary>
    ///     Tests Counting Sort with a reverse sorted array.
    /// </summary>
    [Fact]
    public void Sort_ReverseSortedArray_ReturnsSortedArray()
    {
        // Arrange
        int[] reverseSortedArray = [5, 4, 3, 2, 1];
        int[] expectedArray = [1, 2, 3, 4, 5];

        // Act
        var result = CountingSort.Sort(reverseSortedArray);

        // Assert
        Assert.Equal(expectedArray, result);
    }

    /// <summary>
    ///     Tests Counting Sort with an array containing duplicates.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithDuplicates_ReturnsSortedArray()
    {
        // Arrange
        int[] arrayWithDuplicates = [4, 2, 2, 4, 3, 3, 1];
        int[] expectedArray = [1, 2, 2, 3, 3, 4, 4];

        // Act
        var result = CountingSort.Sort(arrayWithDuplicates);

        // Assert
        Assert.Equal(expectedArray, result);
    }

    /// <summary>
    ///     Tests Counting Sort with an array containing negative numbers.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithNegativeNumbers_ReturnsSortedArray()
    {
        // Arrange
        int[] arrayWithNegatives = [-5, -1, -3, -2, 0, 2, 1];
        int[] expectedArray = [-5, -3, -2, -1, 0, 1, 2];

        // Act
        var result = CountingSort.Sort(arrayWithNegatives);

        // Assert
        Assert.Equal(expectedArray, result);
    }

    /// <summary>
    ///     Tests Counting Sort with a single element array.
    /// </summary>
    [Fact]
    public void Sort_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] singleElementArray = [42];
        int[] expectedArray = [42];

        // Act
        var result = CountingSort.Sort(singleElementArray);

        // Assert
        Assert.Equal(expectedArray, result);
    }

    /// <summary>
    ///     Tests Counting Sort with an empty array.
    /// </summary>
    [Fact]
    public void Sort_EmptyArray_ReturnsSameArray()
    {
        // Arrange
        int[] emptyArray = [];
        int[] expectedArray = [];

        // Act
        var result = CountingSort.Sort(emptyArray);

        // Assert
        Assert.Equal(expectedArray, result);
    }

    /// <summary>
    ///     Tests Counting Sort with an array where all elements are the same.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithSameElements_ReturnsSameArray()
    {
        // Arrange
        int[] arrayWithSameElements = [7, 7, 7, 7, 7];
        int[] expectedArray = [7, 7, 7, 7, 7];

        // Act
        var result = CountingSort.Sort(arrayWithSameElements);

        // Assert
        Assert.Equal(expectedArray, result);
    }
}
