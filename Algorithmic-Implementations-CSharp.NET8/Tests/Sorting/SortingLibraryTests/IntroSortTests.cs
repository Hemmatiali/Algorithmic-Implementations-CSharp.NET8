using SortingLibrary;

namespace SortingLibraryTests;


/// <summary>
///     Unit tests for the IntroSort class.
/// </summary>
public class IntroSortTests
{
    /// <summary>
    ///     Tests Intro Sort with a random unsorted array.
    /// </summary>
    [Fact]
    public void Sort_RandomUnsortedArray_ReturnsSortedArray()
    {
        // Arrange
        int[] unsortedArray = { 23, 12, 1, 8, 34, 54, 2, 3 };
        int[] expectedArray = { 1, 2, 3, 8, 12, 23, 34, 54 };

        // Act
        IntroSort.Sort(unsortedArray);

        // Assert
        Assert.Equal(expectedArray, unsortedArray);
    }

    /// <summary>
    ///     Tests Intro Sort with an already sorted array.
    /// </summary>
    [Fact]
    public void Sort_AlreadySortedArray_ReturnsSameArray()
    {
        // Arrange
        int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7 };
        int[] expectedArray = { 1, 2, 3, 4, 5, 6, 7 };

        // Act
        IntroSort.Sort(sortedArray);

        // Assert
        Assert.Equal(expectedArray, sortedArray);
    }

    /// <summary>
    ///     Tests Intro Sort with a reverse sorted array.
    /// </summary>
    [Fact]
    public void Sort_ReverseSortedArray_ReturnsSortedArray()
    {
        // Arrange
        int[] reverseSortedArray = { 9, 7, 5, 3, 1 };
        int[] expectedArray = { 1, 3, 5, 7, 9 };

        // Act
        IntroSort.Sort(reverseSortedArray);

        // Assert
        Assert.Equal(expectedArray, reverseSortedArray);
    }

    /// <summary>
    ///     Tests Intro Sort with an array containing duplicates.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithDuplicates_ReturnsSortedArray()
    {
        // Arrange
        int[] arrayWithDuplicates = { 5, 1, 4, 2, 1, 5 };
        int[] expectedArray = { 1, 1, 2, 4, 5, 5 };

        // Act
        IntroSort.Sort(arrayWithDuplicates);

        // Assert
        Assert.Equal(expectedArray, arrayWithDuplicates);
    }

    /// <summary>
    ///     Tests Intro Sort with a single-element array.
    /// </summary>
    [Fact]
    public void Sort_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] singleElementArray = { 42 };
        int[] expectedArray = { 42 };

        // Act
        IntroSort.Sort(singleElementArray);

        // Assert
        Assert.Equal(expectedArray, singleElementArray);
    }

    /// <summary>
    ///     Tests Intro Sort with an empty array.
    /// </summary>
    [Fact]
    public void Sort_EmptyArray_ReturnsSameArray()
    {
        // Arrange
        int[] emptyArray = { };
        int[] expectedArray = { };

        // Act
        IntroSort.Sort(emptyArray);

        // Assert
        Assert.Equal(expectedArray, emptyArray);
    }

    /// <summary>
    ///     Tests Intro Sort with negative numbers included.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithNegativeNumbers_ReturnsSortedArray()
    {
        // Arrange
        int[] arrayWithNegatives = { -5, -1, -3, -2, 0, 2, 1 };
        int[] expectedArray = { -5, -3, -2, -1, 0, 1, 2 };

        // Act
        IntroSort.Sort(arrayWithNegatives);

        // Assert
        Assert.Equal(expectedArray, arrayWithNegatives);
    }

    /// <summary>
    ///     Tests Intro Sort with an array containing large numbers.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithLargeNumbers_ReturnsSortedArray()
    {
        // Arrange
        int[] arrayWithLargeNumbers = { 2_000_000_000, -2_000_000_000, 1_000_000_000, -1_000_000_000, 0 };
        int[] expectedArray = { -2_000_000_000, -1_000_000_000, 0, 1_000_000_000, 2_000_000_000 };

        // Act
        IntroSort.Sort(arrayWithLargeNumbers);

        // Assert
        Assert.Equal(expectedArray, arrayWithLargeNumbers);
    }
}
