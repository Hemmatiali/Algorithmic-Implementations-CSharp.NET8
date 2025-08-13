using SortingLibrary;

namespace SortingLibraryTests;


/// <summary>
///     Unit tests for the PancakeSort class.
/// </summary>
public class PancakeSortTests
{
    /// <summary>
    ///     Tests Pancake Sort with a random unsorted array.
    /// </summary>
    [Fact]
    public void Sort_RandomUnsortedArray_ReturnsSortedArray()
    {
        // Arrange
        int[] array = { 3, 6, 1, 10, 2, 7, 9, 8, 4, 5 };
        int[] expected = (int[])array.Clone();
        Array.Sort(expected);

        // Act
        PancakeSort.Sort(array);

        // Assert
        Assert.Equal(expected, array);
    }

    /// <summary>
    ///     Tests Pancake Sort with an already sorted array.
    /// </summary>
    [Fact]
    public void Sort_AlreadySortedArray_ReturnsSameArray()
    {
        // Arrange
        int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7 };
        int[] expected = { 1, 2, 3, 4, 5, 6, 7 };

        // Act
        PancakeSort.Sort(sortedArray);

        // Assert
        Assert.Equal(expected, sortedArray);
    }

    /// <summary>
    ///     Tests Pancake Sort with a reverse sorted array.
    /// </summary>
    [Fact]
    public void Sort_ReverseSortedArray_ReturnsSortedArray()
    {
        // Arrange
        int[] reverseSortedArray = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // Act
        PancakeSort.Sort(reverseSortedArray);

        // Assert
        Assert.Equal(expected, reverseSortedArray);
    }

    /// <summary>
    ///     Tests Pancake Sort with an array containing duplicates.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithDuplicates_ReturnsSortedArray()
    {
        // Arrange
        int[] arrayWithDuplicates = { 5, 1, 4, 2, 1, 5, 3 };
        int[] expected = (int[])arrayWithDuplicates.Clone();
        Array.Sort(expected);

        // Act
        PancakeSort.Sort(arrayWithDuplicates);

        // Assert
        Assert.Equal(expected, arrayWithDuplicates);
    }

    /// <summary>
    ///     Tests Pancake Sort with a single-element array.
    /// </summary>
    [Fact]
    public void Sort_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] singleElementArray = { 42 };
        int[] expected = { 42 };

        // Act
        PancakeSort.Sort(singleElementArray);

        // Assert
        Assert.Equal(expected, singleElementArray);
    }

    /// <summary>
    ///     Tests Pancake Sort with an empty array.
    /// </summary>
    [Fact]
    public void Sort_EmptyArray_ReturnsSameArray()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        PancakeSort.Sort(emptyArray);

        // Assert
        Assert.Empty(emptyArray);
    }

    /// <summary>
    ///     Tests Pancake Sort with an array where all elements are the same.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithSameElements_ReturnsSameArray()
    {
        // Arrange
        int[] arrayWithSameElements = { 7, 7, 7, 7 };
        int[] expected = { 7, 7, 7, 7 };

        // Act
        PancakeSort.Sort(arrayWithSameElements);

        // Assert
        Assert.Equal(expected, arrayWithSameElements);
    }

    /// <summary>
    ///     Tests Pancake Sort with negative numbers included.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithNegativeNumbers_ReturnsSortedArray()
    {
        // Arrange
        int[] arrayWithNegatives = { -5, -1, -3, -2, 0, 2, 1 };
        int[] expected = (int[])arrayWithNegatives.Clone();
        Array.Sort(expected);

        // Act
        PancakeSort.Sort(arrayWithNegatives);

        // Assert
        Assert.Equal(expected, arrayWithNegatives);
    }

    /// <summary>
    ///     Tests Pancake Sort with very large and very small integers.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithLargeNumbers_ReturnsSortedArray()
    {
        // Arrange
        int[] arrayWithLargeNumbers = { int.MaxValue, int.MinValue, 0, 1_000_000_000, -1_000_000_000 };
        int[] expected = (int[])arrayWithLargeNumbers.Clone();
        Array.Sort(expected);

        // Act
        PancakeSort.Sort(arrayWithLargeNumbers);

        // Assert
        Assert.Equal(expected, arrayWithLargeNumbers);
    }
}
