using SortingLibrary;

namespace SortingLibraryTests;

/// <summary>
///     Unit tests for the QuickSort class.
/// </summary>
public class QuickSortTests
{
    /// <summary>
    ///     Tests Quick Sort with a random unsorted array.
    /// </summary>
    [Fact]
    public void Sort_RandomUnsortedArray_ReturnsSortedArray()
    {
        // Arrange
        int[] unsortedArray = [12, 7, 14, 9, 10, 11];
        int[] expectedArray = [7, 9, 10, 11, 12, 14];

        // Act
        QuickSort.Sort(unsortedArray, 0, unsortedArray.Length - 1);

        // Assert
        Assert.Equal(expectedArray, unsortedArray);
    }

    /// <summary>
    ///     Tests Quick Sort with an already sorted array.
    /// </summary>
    [Fact]
    public void Sort_AlreadySortedArray_ReturnsSameArray()
    {
        // Arrange
        int[] sortedArray = [1, 2, 3, 4, 5];
        int[] expectedArray = [1, 2, 3, 4, 5];

        // Act
        QuickSort.Sort(sortedArray, 0, sortedArray.Length - 1);

        // Assert
        Assert.Equal(expectedArray, sortedArray);
    }

    /// <summary>
    ///     Tests Quick Sort with a reverse sorted array.
    /// </summary>
    [Fact]
    public void Sort_ReverseSortedArray_ReturnsSortedArray()
    {
        // Arrange
        int[] reverseSortedArray = [5, 4, 3, 2, 1];
        int[] expectedArray = [1, 2, 3, 4, 5];

        // Act
        QuickSort.Sort(reverseSortedArray, 0, reverseSortedArray.Length - 1);

        // Assert
        Assert.Equal(expectedArray, reverseSortedArray);
    }

    /// <summary>
    ///     Tests Quick Sort with an array containing duplicates.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithDuplicates_ReturnsSortedArray()
    {
        // Arrange
        int[] arrayWithDuplicates = [12, 7, 14, 9, 10, 11, 12];
        int[] expectedArray = [7, 9, 10, 11, 12, 12, 14];

        // Act
        QuickSort.Sort(arrayWithDuplicates, 0, arrayWithDuplicates.Length - 1);

        // Assert
        Assert.Equal(expectedArray, arrayWithDuplicates);
    }

    /// <summary>
    ///     Tests Quick Sort with an array containing negative numbers.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithNegativeNumbers_ReturnsSortedArray()
    {
        // Arrange
        int[] arrayWithNegatives = [-12, 7, 14, -9, 10, 11];
        int[] expectedArray = [-12, -9, 7, 10, 11, 14];

        // Act
        QuickSort.Sort(arrayWithNegatives, 0, arrayWithNegatives.Length - 1);

        // Assert
        Assert.Equal(expectedArray, arrayWithNegatives);
    }

    /// <summary>
    ///     Tests Quick Sort with a single element array.
    /// </summary>
    [Fact]
    public void Sort_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] singleElementArray = [42];
        int[] expectedArray = [42];

        // Act
        QuickSort.Sort(singleElementArray, 0, singleElementArray.Length - 1);

        // Assert
        Assert.Equal(expectedArray, singleElementArray);
    }

    /// <summary>
    ///     Tests Quick Sort with an empty array.
    /// </summary>
    [Fact]
    public void Sort_EmptyArray_ReturnsSameArray()
    {
        // Arrange
        int[] emptyArray = [];
        int[] expectedArray = [];

        // Act
        QuickSort.Sort(emptyArray, 0, emptyArray.Length - 1);

        // Assert
        Assert.Equal(expectedArray, emptyArray);
    }

    /// <summary>
    ///     Tests Quick Sort with an array where all elements are the same.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithSameElements_ReturnsSameArray()
    {
        // Arrange
        int[] arrayWithSameElements = [10, 10, 10, 10, 10];
        int[] expectedArray = [10, 10, 10, 10, 10];

        // Act
        QuickSort.Sort(arrayWithSameElements, 0, arrayWithSameElements.Length - 1);

        // Assert
        Assert.Equal(expectedArray, arrayWithSameElements);
    }
}