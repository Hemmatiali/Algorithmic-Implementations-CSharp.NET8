using SortingLibrary;

namespace SortingLibraryTests;

/// <summary>
///     Unit tests for the SelectionSort class.
/// </summary>
public class SelectionSortTests
{
    /// <summary>
    ///     Tests Selection Sort with a random unsorted array.
    /// </summary>
    [Fact]
    public void Sort_RandomUnsortedArray_ReturnsSortedArray()
    {
        // Arrange
        int[] unsortedArray = [64, 25, 12, 22, 11];
        int[] expectedArray = [11, 12, 22, 25, 64];

        // Act
        SelectionSort.Sort(unsortedArray);

        // Assert
        Assert.Equal(expectedArray, unsortedArray);
    }

    /// <summary>
    ///     Tests Selection Sort with an already sorted array.
    /// </summary>
    [Fact]
    public void Sort_AlreadySortedArray_ReturnsSameArray()
    {
        // Arrange
        int[] sortedArray = [1, 2, 3, 4, 5];
        int[] expectedArray = [1, 2, 3, 4, 5];

        // Act
        SelectionSort.Sort(sortedArray);

        // Assert
        Assert.Equal(expectedArray, sortedArray);
    }

    /// <summary>
    ///     Tests Selection Sort with a reverse sorted array.
    /// </summary>
    [Fact]
    public void Sort_ReverseSortedArray_ReturnsSortedArray()
    {
        // Arrange
        int[] reverseSortedArray = [5, 4, 3, 2, 1];
        int[] expectedArray = [1, 2, 3, 4, 5];

        // Act
        SelectionSort.Sort(reverseSortedArray);

        // Assert
        Assert.Equal(expectedArray, reverseSortedArray);
    }

    /// <summary>
    ///     Tests Selection Sort with an array containing duplicates.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithDuplicates_ReturnsSortedArray()
    {
        // Arrange
        int[] arrayWithDuplicates = [64, 25, 12, 22, 11, 12, 22];
        int[] expectedArray = [11, 12, 12, 22, 22, 25, 64];

        // Act
        SelectionSort.Sort(arrayWithDuplicates);

        // Assert
        Assert.Equal(expectedArray, arrayWithDuplicates);
    }

    /// <summary>
    ///     Tests Selection Sort with an array containing negative numbers.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithNegativeNumbers_ReturnsSortedArray()
    {
        // Arrange
        int[] arrayWithNegatives = [-3, 64, -15, 25, 0];
        int[] expectedArray = [-15, -3, 0, 25, 64];

        // Act
        SelectionSort.Sort(arrayWithNegatives);

        // Assert
        Assert.Equal(expectedArray, arrayWithNegatives);
    }

    /// <summary>
    ///     Tests Selection Sort with a single element array.
    /// </summary>
    [Fact]
    public void Sort_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] singleElementArray = [42];
        int[] expectedArray = [42];

        // Act
        SelectionSort.Sort(singleElementArray);

        // Assert
        Assert.Equal(expectedArray, singleElementArray);
    }

    /// <summary>
    ///     Tests Selection Sort with an empty array.
    /// </summary>
    [Fact]
    public void Sort_EmptyArray_ReturnsSameArray()
    {
        // Arrange
        int[] emptyArray = [];
        int[] expectedArray = [];

        // Act
        SelectionSort.Sort(emptyArray);

        // Assert
        Assert.Equal(expectedArray, emptyArray);
    }
}