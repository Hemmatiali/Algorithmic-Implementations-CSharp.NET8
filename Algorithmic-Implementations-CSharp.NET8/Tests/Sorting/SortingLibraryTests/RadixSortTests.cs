using SortingLibrary;

namespace SortingLibraryTests;

/// <summary>
///     Unit tests for the RadixSort class.
/// </summary>
public class RadixSortTests
{
    /// <summary>
    ///     Tests Radix Sort with a random unsorted array.
    /// </summary>
    [Fact]
    public void Sort_RandomUnsortedArray_ReturnsSortedArray()
    {
        // Arrange
        int[] unsortedArray = [170, 45, 75, 90, 802, 24, 2, 66];
        int[] expectedArray = [2, 24, 45, 66, 75, 90, 170, 802];

        // Act
        RadixSort.Sort(unsortedArray);

        // Assert
        Assert.Equal(expectedArray, unsortedArray);
    }

    /// <summary>
    ///     Tests Radix Sort with an already sorted array.
    /// </summary>
    [Fact]
    public void Sort_AlreadySortedArray_ReturnsSameArray()
    {
        // Arrange
        int[] sortedArray = [2, 24, 45, 66, 75, 90, 170, 802];
        int[] expectedArray = [2, 24, 45, 66, 75, 90, 170, 802];

        // Act
        RadixSort.Sort(sortedArray);

        // Assert
        Assert.Equal(expectedArray, sortedArray);
    }

    /// <summary>
    ///     Tests Radix Sort with a reverse sorted array.
    /// </summary>
    [Fact]
    public void Sort_ReverseSortedArray_ReturnsSortedArray()
    {
        // Arrange
        int[] reverseSortedArray = [802, 170, 90, 75, 66, 45, 24, 2];
        int[] expectedArray = [2, 24, 45, 66, 75, 90, 170, 802];

        // Act
        RadixSort.Sort(reverseSortedArray);

        // Assert
        Assert.Equal(expectedArray, reverseSortedArray);
    }

    /// <summary>
    ///     Tests Radix Sort with an array containing duplicates.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithDuplicates_ReturnsSortedArray()
    {
        // Arrange
        int[] arrayWithDuplicates = [170, 45, 75, 90, 170, 24, 45, 66];
        int[] expectedArray = [24, 45, 45, 66, 75, 90, 170, 170];

        // Act
        RadixSort.Sort(arrayWithDuplicates);

        // Assert
        Assert.Equal(expectedArray, arrayWithDuplicates);
    }

    /// <summary>
    ///     Tests Radix Sort with a single-element array.
    /// </summary>
    [Fact]
    public void Sort_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] singleElementArray = [42];
        int[] expectedArray = [42];

        // Act
        RadixSort.Sort(singleElementArray);

        // Assert
        Assert.Equal(expectedArray, singleElementArray);
    }

    /// <summary>
    ///     Tests Radix Sort with an empty array.
    /// </summary>
    [Fact]
    public void Sort_EmptyArray_ReturnsSameArray()
    {
        // Arrange
        int[] emptyArray = [];
        int[] expectedArray = [];

        // Act
        RadixSort.Sort(emptyArray);

        // Assert
        Assert.Equal(expectedArray, emptyArray);
    }

    /// <summary>
    ///     Tests Radix Sort with an array where all elements are the same.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithSameElements_ReturnsSameArray()
    {
        // Arrange
        int[] arrayWithSameElements = [7, 7, 7, 7, 7];
        int[] expectedArray = [7, 7, 7, 7, 7];

        // Act
        RadixSort.Sort(arrayWithSameElements);

        // Assert
        Assert.Equal(expectedArray, arrayWithSameElements);
    }

    /// <summary>
    ///     Tests Radix Sort with an array containing zeros.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithZeros_ReturnsSortedArray()
    {
        // Arrange
        int[] arrayWithZeros = [0, 0, 170, 0, 45, 75, 0, 24];
        int[] expectedArray = [0, 0, 0, 0, 24, 45, 75, 170];

        // Act
        RadixSort.Sort(arrayWithZeros);

        // Assert
        Assert.Equal(expectedArray, arrayWithZeros);
    }

    /// <summary>
    ///     Tests Radix Sort with an array containing large numbers.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithLargeNumbers_ReturnsSortedArray()
    {
        // Arrange
        int[] arrayWithLargeNumbers = [987654, 123456, 654321, 234567, 345678];
        int[] expectedArray = [123456, 234567, 345678, 654321, 987654];

        // Act
        RadixSort.Sort(arrayWithLargeNumbers);

        // Assert
        Assert.Equal(expectedArray, arrayWithLargeNumbers);
    }

    /// <summary>
    ///     Tests Radix Sort with negative numbers (if handled in implementation).
    /// </summary>
    [Fact]
    public void Sort_ArrayWithNegativeNumbers_NotSupportedByDefault()
    {
        // Arrange
        int[] arrayWithNegatives = [-5, -1, -3, -2, 0, 2, 1];

        // Act & Assert
        Assert.Throws<IndexOutOfRangeException>(() => RadixSort.Sort(arrayWithNegatives));
    }
}
