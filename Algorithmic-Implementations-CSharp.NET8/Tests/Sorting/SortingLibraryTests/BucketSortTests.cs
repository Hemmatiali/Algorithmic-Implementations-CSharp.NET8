using SortingLibrary;

namespace SortingLibraryTests;

/// <summary>
///     Unit tests for the BucketSort class.
/// </summary>
public class BucketSortTests
{
    /// <summary>
    ///     Tests Bucket Sort with a random unsorted array.
    /// </summary>
    [Fact]
    public void Sort_RandomUnsortedArray_ReturnsSortedArray()
    {
        // Arrange
        float[] unsortedArray = [0.897f, 0.565f, 0.656f, 0.1234f, 0.665f, 0.3434f];
        float[] expectedArray = [0.1234f, 0.3434f, 0.565f, 0.656f, 0.665f, 0.897f];

        // Act
        BucketSort.Sort(unsortedArray);

        // Assert
        Assert.Equal(expectedArray, unsortedArray);
    }

    /// <summary>
    ///     Tests Bucket Sort with an already sorted array.
    /// </summary>
    [Fact]
    public void Sort_AlreadySortedArray_ReturnsSameArray()
    {
        // Arrange
        float[] sortedArray = [0.1234f, 0.3434f, 0.565f, 0.656f, 0.665f, 0.897f];
        float[] expectedArray = [0.1234f, 0.3434f, 0.565f, 0.656f, 0.665f, 0.897f];

        // Act
        BucketSort.Sort(sortedArray);

        // Assert
        Assert.Equal(expectedArray, sortedArray);
    }

    /// <summary>
    ///     Tests Bucket Sort with a reverse sorted array.
    /// </summary>
    [Fact]
    public void Sort_ReverseSortedArray_ReturnsSortedArray()
    {
        // Arrange
        float[] reverseSortedArray = [0.897f, 0.665f, 0.656f, 0.565f, 0.3434f, 0.1234f];
        float[] expectedArray = [0.1234f, 0.3434f, 0.565f, 0.656f, 0.665f, 0.897f];

        // Act
        BucketSort.Sort(reverseSortedArray);

        // Assert
        Assert.Equal(expectedArray, reverseSortedArray);
    }

    /// <summary>
    ///     Tests Bucket Sort with an array containing duplicates.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithDuplicates_ReturnsSortedArray()
    {
        // Arrange
        float[] arrayWithDuplicates = [0.897f, 0.565f, 0.897f, 0.1234f, 0.565f];
        float[] expectedArray = [0.1234f, 0.565f, 0.565f, 0.897f, 0.897f];

        // Act
        BucketSort.Sort(arrayWithDuplicates);

        // Assert
        Assert.Equal(expectedArray, arrayWithDuplicates);
    }

    /// <summary>
    ///     Tests Bucket Sort with a single-element array.
    /// </summary>
    [Fact]
    public void Sort_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        float[] singleElementArray = [0.42f];
        float[] expectedArray = [0.42f];

        // Act
        BucketSort.Sort(singleElementArray);

        // Assert
        Assert.Equal(expectedArray, singleElementArray);
    }

    /// <summary>
    ///     Tests Bucket Sort with an empty array.
    /// </summary>
    [Fact]
    public void Sort_EmptyArray_ReturnsSameArray()
    {
        // Arrange
        float[] emptyArray = [];
        float[] expectedArray = [];

        // Act
        BucketSort.Sort(emptyArray);

        // Assert
        Assert.Equal(expectedArray, emptyArray);
    }

    /// <summary>
    ///     Tests Bucket Sort with an array where all elements are the same.
    /// </summary>
    [Fact]
    public void Sort_ArrayWithSameElements_ReturnsSameArray()
    {
        // Arrange
        float[] arrayWithSameElements = [0.7f, 0.7f, 0.7f, 0.7f];
        float[] expectedArray = [0.7f, 0.7f, 0.7f, 0.7f];

        // Act
        BucketSort.Sort(arrayWithSameElements);

        // Assert
        Assert.Equal(expectedArray, arrayWithSameElements);
    }
}