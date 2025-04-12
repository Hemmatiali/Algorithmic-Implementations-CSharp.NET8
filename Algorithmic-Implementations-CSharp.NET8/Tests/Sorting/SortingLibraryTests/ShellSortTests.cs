using SortingLibrary;

namespace SortingLibraryTests;


/// <summary>
///     Unit tests for the ShellSort class.
/// </summary>
public class ShellSortTests
{
    /// <summary>
    ///     Tests Shell Sort with a random unsorted array.
    /// </summary>
    [Fact]
    public void Sort_RandomUnsortedArray_ReturnsSortedArray()
    {
        // Arrange
        int[] unsortedArray = { 64, 34, 25, 12, 22, 11, 90 };
        int[] expectedArray = { 11, 12, 22, 25, 34, 64, 90 };

        // Act
        ShellSort.Sort(unsortedArray);

        // Assert
        Assert.Equal(expectedArray, unsortedArray);
    }

    /// <summary>
    ///     Tests Shell Sort with an already sorted array.
    /// </summary>
    [Fact]
    public void Sort_AlreadySortedArray_ReturnsSameArray()
    {
        // Arrange
        int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7 };
        int[] expectedArray = { 1, 2, 3, 4, 5, 6, 7 };

        // Act
        ShellSort.Sort(sortedArray);

        // Assert
        Assert.Equal(expectedArray, sortedArray);
    }

    /// <summary>
    ///     Tests Shell Sort with a reverse sorted array.
    /// </summary>
    [Fact]
    public void Sort_ReverseSortedArray_ReturnsSortedArray()
    {
        // Arrange
        int[] reverseSortedArray = { 9, 7, 5, 3, 1 };
        int[] expectedArray = { 1, 3, 5, 7, 9 };

        // Act
        ShellSort.Sort(reverseSortedArray);

        // Assert
        Assert.Equal(expectedArray, reverseSortedArray);
    }

    /// <summary>
    ///     Tests Shell Sort with an array containing duplicates.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithDuplicates_ReturnsSortedArray()
    {
        // Arrange
        int[] arrayWithDuplicates = { 5, 1, 4, 2, 1, 5 };
        int[] expectedArray = { 1, 1, 2, 4, 5, 5 };

        // Act
        ShellSort.Sort(arrayWithDuplicates);

        // Assert
        Assert.Equal(expectedArray, arrayWithDuplicates);
    }

    /// <summary>
    ///     Tests Shell Sort with a single-element array.
    /// </summary>
    [Fact]
    public void Sort_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] singleElementArray = { 42 };
        int[] expectedArray = { 42 };

        // Act
        ShellSort.Sort(singleElementArray);

        // Assert
        Assert.Equal(expectedArray, singleElementArray);
    }

    /// <summary>
    ///     Tests Shell Sort with an empty array.
    /// </summary>
    [Fact]
    public void Sort_EmptyArray_ReturnsSameArray()
    {
        // Arrange
        int[] emptyArray = { };
        int[] expectedArray = { };

        // Act
        ShellSort.Sort(emptyArray);

        // Assert
        Assert.Equal(expectedArray, emptyArray);
    }

    /// <summary>
    ///     Tests Shell Sort with an array where all elements are the same.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithSameElements_ReturnsSameArray()
    {
        // Arrange
        int[] arrayWithSameElements = { 7, 7, 7, 7 };
        int[] expectedArray = { 7, 7, 7, 7 };

        // Act
        ShellSort.Sort(arrayWithSameElements);

        // Assert
        Assert.Equal(expectedArray, arrayWithSameElements);
    }
}