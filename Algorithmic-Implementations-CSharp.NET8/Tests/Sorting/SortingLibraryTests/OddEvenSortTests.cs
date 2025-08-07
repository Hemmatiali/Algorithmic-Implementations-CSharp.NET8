using SortingLibrary;

namespace SortingLibraryTests;


/// <summary>
///     Unit tests for the OddEvenSort class.
/// </summary>
public class OddEvenSortTests
{
    /// <summary>
    ///     Tests Odd-Even Sort with a random unsorted array.
    /// </summary>
    [Fact]
    public void Sort_RandomUnsortedArray_ReturnsSortedArray()
    {
        // Arrange
        int[] unsortedArray = { 34, 2, 25, 12, 22, 11, 90, 3, 18, 45 };
        int[] expectedArray = { 2, 3, 11, 12, 18, 22, 25, 34, 45, 90 };

        // Act
        OddEvenSort.Sort(unsortedArray);

        // Assert
        Assert.Equal(expectedArray, unsortedArray);
    }

    /// <summary>
    ///     Tests Odd-Even Sort with an already sorted array.
    /// </summary>
    [Fact]
    public void Sort_AlreadySortedArray_ReturnsSameArray()
    {
        // Arrange
        int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7 };
        int[] expectedArray = { 1, 2, 3, 4, 5, 6, 7 };

        // Act
        OddEvenSort.Sort(sortedArray);

        // Assert
        Assert.Equal(expectedArray, sortedArray);
    }

    /// <summary>
    ///     Tests Odd-Even Sort with a reverse sorted array.
    /// </summary>
    [Fact]
    public void Sort_ReverseSortedArray_ReturnsSortedArray()
    {
        // Arrange
        int[] reverseSortedArray = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        int[] expectedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // Act
        OddEvenSort.Sort(reverseSortedArray);

        // Assert
        Assert.Equal(expectedArray, reverseSortedArray);
    }

    /// <summary>
    ///     Tests Odd-Even Sort with an array containing duplicates.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithDuplicates_ReturnsSortedArray()
    {
        // Arrange
        int[] arrayWithDuplicates = { 5, 1, 4, 2, 1, 5 };
        int[] expectedArray = { 1, 1, 2, 4, 5, 5 };

        // Act
        OddEvenSort.Sort(arrayWithDuplicates);

        // Assert
        Assert.Equal(expectedArray, arrayWithDuplicates);
    }

    /// <summary>
    ///     Tests Odd-Even Sort with a single-element array.
    /// </summary>
    [Fact]
    public void Sort_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] singleElementArray = { 42 };
        int[] expectedArray = { 42 };

        // Act
        OddEvenSort.Sort(singleElementArray);

        // Assert
        Assert.Equal(expectedArray, singleElementArray);
    }

    /// <summary>
    ///     Tests Odd-Even Sort with an empty array.
    /// </summary>
    [Fact]
    public void Sort_EmptyArray_ReturnsSameArray()
    {
        // Arrange
        int[] emptyArray = { };
        int[] expectedArray = { };

        // Act
        OddEvenSort.Sort(emptyArray);

        // Assert
        Assert.Equal(expectedArray, emptyArray);
    }

    /// <summary>
    ///     Tests Odd-Even Sort with an array where all elements are the same.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithSameElements_ReturnsSameArray()
    {
        // Arrange
        int[] arrayWithSameElements = { 7, 7, 7, 7 };
        int[] expectedArray = { 7, 7, 7, 7 };

        // Act
        OddEvenSort.Sort(arrayWithSameElements);

        // Assert
        Assert.Equal(expectedArray, arrayWithSameElements);
    }
}
