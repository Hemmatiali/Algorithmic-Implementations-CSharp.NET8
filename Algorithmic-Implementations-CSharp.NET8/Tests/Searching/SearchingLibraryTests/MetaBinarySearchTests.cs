using SearchingLibrary;

namespace SearchingLibraryTests;

/// <summary>
///     Unit tests for the MetaBinarySearch class.
/// </summary>
public class MetaBinarySearchTests
{
    /// <summary>
    ///     Tests the recursive meta binary search method with a sorted array.
    /// </summary>
    [Fact]
    public void Recursive_Search_FindsTarget()
    {
        // Arrange
        int[] sortedArray = GenerateSortedArray(1000);
        int target = 724;
        int expectedIndex = Array.IndexOf(sortedArray, target);

        // Act
        int result = MetaBinarySearch.RecursiveSearch(sortedArray, target);

        // Assert
        Assert.Equal(expectedIndex, result);
    }

    /// <summary>
    ///     Tests the bitwise meta binary search method with a sorted list.
    /// </summary>
    [Fact]
    public void Bitwise_Search_FindsTarget()
    {
        // Arrange
        var sortedList = GenerateSortedList(1000);
        int target = 612;
        int expectedIndex = sortedList.IndexOf(target);

        // Act
        int result = MetaBinarySearch.BitwiseSearch(sortedList, target);

        // Assert
        Assert.Equal(expectedIndex, result);
    }

    /// <summary>
    ///     Tests the meta binary search methods with a target not in the array.
    /// </summary>
    [Fact]
    public void Search_TargetNotInArray_ReturnsMinusOne()
    {
        // Arrange
        int[] sortedArray = GenerateSortedArray(1000);
        int target = 1500;

        // Act & Assert
        Assert.Equal(-1, MetaBinarySearch.RecursiveSearch(sortedArray, target));
    }

    /// <summary>
    ///     Tests the meta binary search methods with a target not in the list.
    /// </summary>
    [Fact]
    public void Search_TargetNotInList_ReturnsMinusOne()
    {
        // Arrange
        var sortedList = GenerateSortedList(1000);
        int target = 1500;

        // Act & Assert
        Assert.Equal(-1, MetaBinarySearch.BitwiseSearch(sortedList, target));
    }

    /// <summary>
    ///     Tests the meta binary search methods with an empty array.
    /// </summary>
    [Fact]
    public void Search_EmptyArray_ReturnsMinusOne()
    {
        // Arrange
        int[] emptyArray = [];
        int target = 10;

        // Act & Assert
        Assert.Equal(-1, MetaBinarySearch.RecursiveSearch(emptyArray, target));
    }

    /// <summary>
    ///     Tests the meta binary search methods with an empty list.
    /// </summary>
    [Fact]
    public void Search_EmptyList_ReturnsMinusOne()
    {
        // Arrange
        var emptyList = new List<int>();
        int target = 10;

        // Act & Assert
        Assert.Equal(-1, MetaBinarySearch.BitwiseSearch(emptyList, target));
    }

    /// <summary>
    ///     Tests the meta binary search methods with a single-element array.
    /// </summary>
    [Fact]
    public void Search_SingleElementArray_ReturnsCorrectIndex()
    {
        // Arrange
        int[] singleElementArray = [15];
        int target = 15;
        int expectedIndex = 0;

        // Act & Assert
        Assert.Equal(expectedIndex, MetaBinarySearch.RecursiveSearch(singleElementArray, target));
    }

    /// <summary>
    ///     Tests the meta binary search methods with a single-element list.
    /// </summary>
    [Fact]
    public void Search_SingleElementList_ReturnsCorrectIndex()
    {
        // Arrange
        var singleElementList = new List<int> { 15 };
        int target = 15;
        int expectedIndex = 0;

        // Act & Assert
        Assert.Equal(expectedIndex, MetaBinarySearch.BitwiseSearch(singleElementList, target));
    }

    /// <summary>
    ///     Generates a sorted array of integers from 1 to length.
    /// </summary>
    /// <param name="length">The length of the array to generate.</param>
    /// <returns>A sorted array of integers.</returns>
    private int[] GenerateSortedArray(int length)
    {
        var array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = i + 1;
        }
        return array;
    }

    /// <summary>
    ///     Generates a sorted list of integers from 1 to length.
    /// </summary>
    /// <param name="length">The length of the list to generate.</param>
    /// <returns>A sorted list of integers.</returns>
    private List<int> GenerateSortedList(int length)
    {
        var list = new List<int>(length);
        for (int i = 0; i < length; i++)
        {
            list.Add(i + 1);
        }
        return list;
    }
}