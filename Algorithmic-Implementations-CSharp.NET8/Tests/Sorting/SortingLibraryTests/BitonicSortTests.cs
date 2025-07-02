using SortingLibrary;

namespace SortingLibraryTests;


/// <summary>
///     Unit tests for the BitonicSort class.
/// </summary>
public class BitonicSortTests
{
    /// <summary>
    ///     Tests Bitonic Sort with a random unsorted array of length 8.
    /// </summary>
    [Fact]
    public void Sort_RandomUnsortedArray_ReturnsSortedArray()
    {
        // Arrange
        int[] unsortedArray = [10, 30, 11, 20, 4, 33, 2, 1];
        int[] expectedArray = [1, 2, 4, 10, 11, 20, 30, 33];

        // Act
        BitonicSort.Sort(unsortedArray);

        // Assert
        Assert.Equal(expectedArray, unsortedArray);
    }

    /// <summary>
    ///     Tests Bitonic Sort with an already sorted array.
    /// </summary>
    [Fact]
    public void Sort_AlreadySortedArray_ReturnsSameArray()
    {
        // Arrange
        int[] sortedArray = [1, 2, 3, 4, 5, 6, 7, 8];
        int[] expectedArray = [1, 2, 3, 4, 5, 6, 7, 8];

        // Act
        BitonicSort.Sort(sortedArray);

        // Assert
        Assert.Equal(expectedArray, sortedArray);
    }

    /// <summary>
    ///     Tests Bitonic Sort with a reverse sorted array.
    /// </summary>
    [Fact]
    public void Sort_ReverseSortedArray_ReturnsSortedArray()
    {
        // Arrange
        int[] reverseSortedArray = [8, 7, 6, 5, 4, 3, 2, 1];
        int[] expectedArray = [1, 2, 3, 4, 5, 6, 7, 8];

        // Act
        BitonicSort.Sort(reverseSortedArray);

        // Assert
        Assert.Equal(expectedArray, reverseSortedArray);
    }

    /// <summary>
    ///     Tests Bitonic Sort with an array containing duplicates.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithDuplicates_ReturnsSortedArray()
    {
        // Arrange
        int[] arrayWithDuplicates = [5, 3, 2, 3, 1, 5, 7, 1];
        int[] expectedArray = [1, 1, 2, 3, 3, 5, 5, 7];

        // Act
        BitonicSort.Sort(arrayWithDuplicates);

        // Assert
        Assert.Equal(expectedArray, arrayWithDuplicates);
    }

    /// <summary>
    ///     Tests Bitonic Sort with invalid array length (not power of 2).
    /// </summary>
    [Fact]
    public void Sort_ArrayNotPowerOfTwo_ThrowsException()
    {
        // Arrange
        int[] invalidArray = [3, 1, 4, 1, 5];

        // Act & Assert
        var ex = Assert.Throws<ArgumentException>(() => BitonicSort.Sort(invalidArray));
        Assert.Contains("power of 2", ex.Message);
    }
}

