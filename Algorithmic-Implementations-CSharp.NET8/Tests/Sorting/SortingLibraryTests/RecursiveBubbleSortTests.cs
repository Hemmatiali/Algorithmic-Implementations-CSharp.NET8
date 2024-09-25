using SortingLibrary;

namespace SortingLibraryTests;

/// <summary>
///     Unit tests for the RecursiveBubbleSort class.
/// </summary>
public class RecursiveBubbleSortTests
{
    /// <summary>
    ///     Tests Recursive Bubble Sort with a random unsorted array.
    /// </summary>
    [Fact]
    public void Sort_RandomUnsortedArray_ReturnsSortedArray()
    {
        // Arrange
        int[] unsortedArray = [64, 34, 25, 12, 22, 11, 90];
        int[] expectedArray = [11, 12, 22, 25, 34, 64, 90];

        // Act
        RecursiveBubbleSort.Sort(unsortedArray, unsortedArray.Length);

        // Assert
        Assert.Equal(expectedArray, unsortedArray);
    }

    /// <summary>
    ///     Tests Recursive Bubble Sort with an already sorted array.
    /// </summary>
    [Fact]
    public void Sort_AlreadySortedArray_ReturnsSameArray()
    {
        // Arrange
        int[] sortedArray = [1, 2, 3, 4, 5];
        int[] expectedArray = [1, 2, 3, 4, 5];

        // Act
        RecursiveBubbleSort.Sort(sortedArray, sortedArray.Length);

        // Assert
        Assert.Equal(expectedArray, sortedArray);
    }

    /// <summary>
    ///     Tests Recursive Bubble Sort with a reverse sorted array.
    /// </summary>
    [Fact]
    public void Sort_ReverseSortedArray_ReturnsSortedArray()
    {
        // Arrange
        int[] reverseSortedArray = [5, 4, 3, 2, 1];
        int[] expectedArray = [1, 2, 3, 4, 5];

        // Act
        RecursiveBubbleSort.Sort(reverseSortedArray, reverseSortedArray.Length);

        // Assert
        Assert.Equal(expectedArray, reverseSortedArray);
    }

    /// <summary>
    ///     Tests Recursive Bubble Sort with an array containing duplicates.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithDuplicates_ReturnsSortedArray()
    {
        // Arrange
        int[] arrayWithDuplicates = [64, 25, 12, 22, 11, 12, 22];
        int[] expectedArray = [11, 12, 12, 22, 22, 25, 64];

        // Act
        RecursiveBubbleSort.Sort(arrayWithDuplicates, arrayWithDuplicates.Length);

        // Assert
        Assert.Equal(expectedArray, arrayWithDuplicates);
    }

    /// <summary>
    ///     Tests Recursive Bubble Sort with an array containing negative numbers.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithNegativeNumbers_ReturnsSortedArray()
    {
        // Arrange
        int[] arrayWithNegatives = [-3, 64, -15, 25, 0];
        int[] expectedArray = [-15, -3, 0, 25, 64];

        // Act
        RecursiveBubbleSort.Sort(arrayWithNegatives, arrayWithNegatives.Length);

        // Assert
        Assert.Equal(expectedArray, arrayWithNegatives);
    }

    /// <summary>
    ///     Tests Recursive Bubble Sort with a single element array.
    /// </summary>
    [Fact]
    public void Sort_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] singleElementArray = [42];
        int[] expectedArray = [42];

        // Act
        RecursiveBubbleSort.Sort(singleElementArray, singleElementArray.Length);

        // Assert
        Assert.Equal(expectedArray, singleElementArray);
    }

    /// <summary>
    ///     Tests Recursive Bubble Sort with an empty array.
    /// </summary>
    [Fact]
    public void Sort_EmptyArray_ReturnsSameArray()
    {
        // Arrange
        int[] emptyArray = [];
        int[] expectedArray = [];

        // Act
        RecursiveBubbleSort.Sort(emptyArray, emptyArray.Length);

        // Assert
        Assert.Equal(expectedArray, emptyArray);
    }

    /// <summary>
    ///     Tests Recursive Bubble Sort with an array where all elements are the same.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithSameElements_ReturnsSameArray()
    {
        // Arrange
        int[] arrayWithSameElements = [10, 10, 10, 10, 10];
        int[] expectedArray = [10, 10, 10, 10, 10];

        // Act
        RecursiveBubbleSort.Sort(arrayWithSameElements, arrayWithSameElements.Length);

        // Assert
        Assert.Equal(expectedArray, arrayWithSameElements);
    }
}