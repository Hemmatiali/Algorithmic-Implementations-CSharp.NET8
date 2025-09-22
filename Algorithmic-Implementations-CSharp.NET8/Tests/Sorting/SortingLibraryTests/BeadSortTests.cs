using SortingLibrary;

namespace SortingLibraryTests;

/// <summary>
///     Unit tests for the BeadSort class.
/// </summary>
public class BeadSortTests
{
    /// <summary>
    ///     Tests Bead Sort with a typical unsorted array including zeros.
    /// </summary>
    [Fact]
    public void Sort_RandomUnsortedArray_ReturnsSortedArray()
    {
        // Arrange
        int[] array = { 5, 3, 0, 2, 8, 1, 4, 7, 6 };
        int[] expected = (int[])array.Clone();
        Array.Sort(expected);

        // Act
        BeadSort.Sort(array);

        // Assert
        Assert.Equal(expected, array);
    }

    /// <summary>
    ///     Tests Bead Sort with an already sorted array.
    /// </summary>
    [Fact]
    public void Sort_AlreadySortedArray_ReturnsSameArray()
    {
        // Arrange
        int[] sortedArray = { 0, 1, 2, 3, 4, 5 };
        int[] expected = { 0, 1, 2, 3, 4, 5 };

        // Act
        BeadSort.Sort(sortedArray);

        // Assert
        Assert.Equal(expected, sortedArray);
    }

    /// <summary>
    ///     Tests Bead Sort with a reverse sorted array.
    /// </summary>
    [Fact]
    public void Sort_ReverseSortedArray_ReturnsSortedArray()
    {
        // Arrange
        int[] reverseSortedArray = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
        int[] expected = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // Act
        BeadSort.Sort(reverseSortedArray);

        // Assert
        Assert.Equal(expected, reverseSortedArray);
    }

    /// <summary>
    ///     Tests Bead Sort with an array containing duplicates (and zeros).
    /// </summary>
    [Fact]
    public void Sort_ArrayWithDuplicates_ReturnsSortedArray()
    {
        // Arrange
        int[] arrayWithDuplicates = { 5, 1, 4, 2, 1, 5, 3, 0, 0 };
        int[] expected = (int[])arrayWithDuplicates.Clone();
        Array.Sort(expected);

        // Act
        BeadSort.Sort(arrayWithDuplicates);

        // Assert
        Assert.Equal(expected, arrayWithDuplicates);
    }

    /// <summary>
    ///     Tests Bead Sort with a single-element array.
    /// </summary>
    [Fact]
    public void Sort_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] singleElementArray = { 42 };
        int[] expected = { 42 };

        // Act
        BeadSort.Sort(singleElementArray);

        // Assert
        Assert.Equal(expected, singleElementArray);
    }

    /// <summary>
    ///     Tests Bead Sort with an empty array.
    /// </summary>
    [Fact]
    public void Sort_EmptyArray_ReturnsSameArray()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        BeadSort.Sort(emptyArray);

        // Assert
        Assert.Empty(emptyArray);
    }

    /// <summary>
    ///     Tests Bead Sort with an array where all elements are the same.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithSameElements_ReturnsSameArray()
    {
        // Arrange
        int[] arrayWithSameElements = { 7, 7, 7, 7 };
        int[] expected = { 7, 7, 7, 7 };

        // Act
        BeadSort.Sort(arrayWithSameElements);

        // Assert
        Assert.Equal(expected, arrayWithSameElements);
    }

    /// <summary>
    ///     Tests Bead Sort rejects negative numbers.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithNegativeNumbers_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        int[] arrayWithNegatives = { 3, -1, 2 };

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => BeadSort.Sort(arrayWithNegatives));
    }

    /// <summary>
    ///     Tests Bead Sort with zeros mixed in.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithZeros_ReturnsSortedArray()
    {
        // Arrange
        int[] arrayWithZeros = { 0, 5, 0, 3, 2 };
        int[] expected = (int[])arrayWithZeros.Clone();
        Array.Sort(expected);

        // Act
        BeadSort.Sort(arrayWithZeros);

        // Assert
        Assert.Equal(expected, arrayWithZeros);
    }

    /// <summary>
    ///     Tests Bead Sort with larger (but reasonable) values to avoid excessive memory use.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithLargerValues_ReturnsSortedArray()
    {
        // Arrange (max ~ 100 keeps bead grid manageable)
        int[] array = { 100, 25, 75, 0, 50 };
        int[] expected = (int[])array.Clone();
        Array.Sort(expected);

        // Act
        BeadSort.Sort(array);

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
        var ex = Record.Exception(() => BeadSort.Sort(null!));

        // Assert
        Assert.Null(ex);
    }
}
