using SortingLibrary;

namespace SortingLibraryTests;

/// <summary>
///     Unit tests for the SpaghettiSort class.
/// </summary>
public class SpaghettiSortTests
{
    /// <summary>
    ///     Tests Spaghetti Sort with a random unsorted array.
    /// </summary>
    [Fact]
    public void Sort_RandomUnsortedArray_ReturnsSortedArray()
    {
        // Arrange
        int[] array = { 34, -2, 25, 12, 22, 11, 90, 3, -18, 45 };
        int[] expected = (int[])array.Clone();
        Array.Sort(expected);

        // Act
        SpaghettiSort.Sort(array);

        // Assert
        Assert.Equal(expected, array);
    }

    /// <summary>
    ///     Tests Spaghetti Sort with an already sorted array.
    /// </summary>
    [Fact]
    public void Sort_AlreadySortedArray_ReturnsSameArray()
    {
        // Arrange
        int[] sortedArray = { -5, -1, 0, 1, 2, 3, 4 };
        int[] expected = { -5, -1, 0, 1, 2, 3, 4 };

        // Act
        SpaghettiSort.Sort(sortedArray);

        // Assert
        Assert.Equal(expected, sortedArray);
    }

    /// <summary>
    ///     Tests Spaghetti Sort with a reverse sorted array.
    /// </summary>
    [Fact]
    public void Sort_ReverseSortedArray_ReturnsSortedArray()
    {
        // Arrange
        int[] reverseSortedArray = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // Act
        SpaghettiSort.Sort(reverseSortedArray);

        // Assert
        Assert.Equal(expected, reverseSortedArray);
    }

    /// <summary>
    ///     Tests Spaghetti Sort with an array containing duplicates.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithDuplicates_ReturnsSortedArray()
    {
        // Arrange
        int[] arrayWithDuplicates = { 5, 1, 4, 2, 1, 5, 3 };
        int[] expected = (int[])arrayWithDuplicates.Clone();
        Array.Sort(expected);

        // Act
        SpaghettiSort.Sort(arrayWithDuplicates);

        // Assert
        Assert.Equal(expected, arrayWithDuplicates);
    }

    /// <summary>
    ///     Tests Spaghetti Sort with a single-element array.
    /// </summary>
    [Fact]
    public void Sort_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] singleElementArray = { 42 };
        int[] expected = { 42 };

        // Act
        SpaghettiSort.Sort(singleElementArray);

        // Assert
        Assert.Equal(expected, singleElementArray);
    }

    /// <summary>
    ///     Tests Spaghetti Sort with an empty array.
    /// </summary>
    [Fact]
    public void Sort_EmptyArray_ReturnsSameArray()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        SpaghettiSort.Sort(emptyArray);

        // Assert
        Assert.Empty(emptyArray);
    }

    /// <summary>
    ///     Tests Spaghetti Sort with an array where all elements are the same.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithSameElements_ReturnsSameArray()
    {
        // Arrange
        int[] arrayWithSameElements = { 7, 7, 7, 7 };
        int[] expected = { 7, 7, 7, 7 };

        // Act
        SpaghettiSort.Sort(arrayWithSameElements);

        // Assert
        Assert.Equal(expected, arrayWithSameElements);
    }

    /// <summary>
    ///     Tests Spaghetti Sort with negative numbers included.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithNegativeNumbers_ReturnsSortedArray()
    {
        // Arrange
        int[] arrayWithNegatives = { -5, -1, -3, -2, 0, 2, 1 };
        int[] expected = (int[])arrayWithNegatives.Clone();
        Array.Sort(expected);

        // Act
        SpaghettiSort.Sort(arrayWithNegatives);

        // Assert
        Assert.Equal(expected, arrayWithNegatives);
    }

    /// <summary>
    ///     Tests Spaghetti Sort with very large integers but a narrow range
    ///     (compatible with counting-style spaghetti simulation).
    /// </summary>
    [Fact]
    public void Sort_ArrayWithVeryLargeNumbers_NarrowRange_ReturnsSortedArray()
    {
        // Arrange: large values but only a range of 5
        int a = int.MaxValue;
        int[] array = { a - 3, a, a - 1, a - 2, a - 4 };
        int[] expected = (int[])array.Clone();
        Array.Sort(expected);

        // Act
        SpaghettiSort.Sort(array);

        // Assert
        Assert.Equal(expected, array);
    }


    /// <summary>
    ///     Passing a null array must not throw (method is no-op on null).
    /// </summary>
    [Fact]
    public void Sort_NullArray_NoThrow()
    {
        // Act
        var ex = Record.Exception(() => SpaghettiSort.Sort(null!));

        // Assert
        Assert.Null(ex);
    }
}
