using SortingLibrary;

namespace SortingLibraryTests;

/// <summary>
///     Unit tests for the CycleSort class.
/// </summary>
public class CycleSortTests
{
    /// <summary>
    ///     Tests Cycle Sort with a random unsorted array.
    /// </summary>
    [Fact]
    public void Sort_RandomUnsortedArray_ReturnsSortedArray()
    {
        // Arrange
        int[] unsortedArray = [12, 11, 13, 5, 6, 7];
        int[] expectedArray = [5, 6, 7, 11, 12, 13];

        // Act
        CycleSort.Sort(unsortedArray);

        // Assert
        Assert.Equal(expectedArray, unsortedArray);
    }

    /// <summary>
    ///     Tests Cycle Sort with an already sorted array.
    /// </summary>
    [Fact]
    public void Sort_AlreadySortedArray_ReturnsSameArray()
    {
        // Arrange
        int[] sortedArray = [1, 2, 3, 4, 5];
        int[] expectedArray = [1, 2, 3, 4, 5];

        // Act
        CycleSort.Sort(sortedArray);

        // Assert
        Assert.Equal(expectedArray, sortedArray);
    }

    /// <summary>
    ///     Tests Cycle Sort with a reverse sorted array.
    /// </summary>
    [Fact]
    public void Sort_ReverseSortedArray_ReturnsSortedArray()
    {
        // Arrange
        int[] reverseSortedArray = [5, 4, 3, 2, 1];
        int[] expectedArray = [1, 2, 3, 4, 5];

        // Act
        CycleSort.Sort(reverseSortedArray);

        // Assert
        Assert.Equal(expectedArray, reverseSortedArray);
    }

    /// <summary>
    ///     Tests Cycle Sort with an array containing duplicates.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithDuplicates_ReturnsSortedArray()
    {
        // Arrange
        int[] arrayWithDuplicates = [12, 11, 13, 11, 12, 5];
        int[] expectedArray = [5, 11, 11, 12, 12, 13];

        // Act
        CycleSort.Sort(arrayWithDuplicates);

        // Assert
        Assert.Equal(expectedArray, arrayWithDuplicates);
    }

    /// <summary>
    ///     Tests Cycle Sort with an array containing negative numbers.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithNegativeNumbers_ReturnsSortedArray()
    {
        // Arrange
        int[] arrayWithNegatives = [-12, 11, -13, 5, -6];
        int[] expectedArray = [-13, -12, -6, 5, 11];

        // Act
        CycleSort.Sort(arrayWithNegatives);

        // Assert
        Assert.Equal(expectedArray, arrayWithNegatives);
    }

    /// <summary>
    ///     Tests Cycle Sort with a single element array.
    /// </summary>
    [Fact]
    public void Sort_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] singleElementArray = [42];
        int[] expectedArray = [42];

        // Act
        CycleSort.Sort(singleElementArray);

        // Assert
        Assert.Equal(expectedArray, singleElementArray);
    }

    /// <summary>
    ///     Tests Cycle Sort with an empty array.
    /// </summary>
    [Fact]
    public void Sort_EmptyArray_ReturnsSameArray()
    {
        // Arrange
        int[] emptyArray = [];
        int[] expectedArray = [];

        // Act
        CycleSort.Sort(emptyArray);

        // Assert
        Assert.Equal(expectedArray, emptyArray);
    }

    /// <summary>
    ///     Tests Cycle Sort with an array where all elements are the same.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithSameElements_ReturnsSameArray()
    {
        // Arrange
        int[] arrayWithSameElements = [10, 10, 10, 10, 10];
        int[] expectedArray = [10, 10, 10, 10, 10];

        // Act
        CycleSort.Sort(arrayWithSameElements);

        // Assert
        Assert.Equal(expectedArray, arrayWithSameElements);
    }
}