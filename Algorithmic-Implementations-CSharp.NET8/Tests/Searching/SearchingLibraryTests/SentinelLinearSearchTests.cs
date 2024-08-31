using SearchingLibrary;

namespace SearchingLibraryTests;

/// <summary>
///     Unit tests for the SentinelLinearSearch class.
/// </summary>
public class SentinelLinearSearchTests
{
    /// <summary>
    ///     Tests the sentinel linear search method with an array.
    /// </summary>
    [Fact]
    public void Search_Array_FindsTarget()
    {
        // Arrange
        int[] array = GenerateArray(1000);
        int target = 598;
        int expectedIndex = Array.IndexOf(array, target);

        // Act
        int result = SentinelLinearSearch.Search(array, target);

        // Assert
        Assert.Equal(expectedIndex, result);
    }

    /// <summary>
    ///     Tests the sentinel linear search method with a list.
    /// </summary>
    [Fact]
    public void Search_List_FindsTarget()
    {
        // Arrange
        var list = GenerateList(1000);
        int target = 374;
        int expectedIndex = list.IndexOf(target);

        // Act
        int result = SentinelLinearSearch.Search(list, target);

        // Assert
        Assert.Equal(expectedIndex, result);
    }

    /// <summary>
    ///     Tests the sentinel linear search method with a target not in the array.
    /// </summary>
    [Fact]
    public void Search_TargetNotInArray_ReturnsMinusOne()
    {
        // Arrange
        int[] array = GenerateArray(1000);
        int target = 1001;

        // Act
        int result = SentinelLinearSearch.Search(array, target);

        // Assert
        Assert.Equal(-1, result);
    }

    /// <summary>
    ///     Tests the sentinel linear search method with a target not in the list.
    /// </summary>
    [Fact]
    public void Search_TargetNotInList_ReturnsMinusOne()
    {
        // Arrange
        var list = GenerateList(1000);
        int target = 1001;

        // Act
        int result = SentinelLinearSearch.Search(list, target);

        // Assert
        Assert.Equal(-1, result);
    }

    /// <summary>
    ///     Tests the sentinel linear search method with an empty array.
    /// </summary>
    [Fact]
    public void Search_EmptyArray_ReturnsMinusOne()
    {
        // Arrange
        int[] emptyArray = [];
        int target = 1;

        // Act
        int result = SentinelLinearSearch.Search(emptyArray, target);

        // Assert
        Assert.Equal(-1, result);
    }

    /// <summary>
    ///     Tests the sentinel linear search method with an empty list.
    /// </summary>
    [Fact]
    public void Search_EmptyList_ReturnsMinusOne()
    {
        // Arrange
        var emptyList = new List<int>();
        int target = 1;

        // Act
        int result = SentinelLinearSearch.Search(emptyList, target);

        // Assert
        Assert.Equal(-1, result);
    }

    /// <summary>
    ///     Tests the sentinel linear search method with a single-element array.
    /// </summary>
    [Fact]
    public void Search_SingleElementArray_ReturnsCorrectIndex()
    {
        // Arrange
        int[] singleElementArray = [5];
        int target = 5;
        int expectedIndex = 0;

        // Act
        int result = SentinelLinearSearch.Search(singleElementArray, target);

        // Assert
        Assert.Equal(expectedIndex, result);
    }

    /// <summary>
    ///     Tests the sentinel linear search method with a single-element list.
    /// </summary>
    [Fact]
    public void Search_SingleElementList_ReturnsCorrectIndex()
    {
        // Arrange
        var singleElementList = new List<int> { 5 };
        int target = 5;
        int expectedIndex = 0;

        // Act
        int result = SentinelLinearSearch.Search(singleElementList, target);

        // Assert
        Assert.Equal(expectedIndex, result);
    }

    /// <summary>
    ///     Generates an array of integers from 1 to length.
    /// </summary>
    /// <param name="length">The length of the array to generate.</param>
    /// <returns>An array of integers.</returns>
    private int[] GenerateArray(int length)
    {
        var array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = i + 1;
        }
        return array;
    }

    /// <summary>
    ///     Generates a list of integers from 1 to length.
    /// </summary>
    /// <param name="length">The length of the list to generate.</param>
    /// <returns>A list of integers.</returns>
    private List<int> GenerateList(int length)
    {
        var list = new List<int>(length);
        for (int i = 0; i < length; i++)
        {
            list.Add(i + 1);
        }
        return list;
    }
}