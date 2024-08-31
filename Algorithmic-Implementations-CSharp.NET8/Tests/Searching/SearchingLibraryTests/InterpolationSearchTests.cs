using SearchingLibrary;

namespace SearchingLibraryTests;

/// <summary>
///     Unit tests for the InterpolationSearch class.
/// </summary>
public class InterpolationSearchTests
{
    /// <summary>
    ///     Tests the interpolation search method with a uniformly distributed sorted array (best case).
    /// </summary>
    [Fact]
    public void Search_UniformlyDistributedArray_FindsTarget()
    {
        // Arrange
        int[] uniformlyDistributedArray = GenerateUniformArray(1000);
        int target = 724;
        int expectedIndex = Array.IndexOf(uniformlyDistributedArray, target);

        // Act
        int result = InterpolationSearch.Search(uniformlyDistributedArray, target);

        // Assert
        Assert.Equal(expectedIndex, result);
    }

    /// <summary>
    ///     Tests the interpolation search method with a non-uniformly distributed sorted array (worst case).
    /// </summary>
    [Fact]
    public void Search_NonUniformlyDistributedArray_FindsTarget()
    {
        // Arrange
        int[] nonUniformlyDistributedArray = GenerateNonUniformArray(1000);
        int target = 9; // Choosing a value in the denser section
        int expectedIndex = Array.IndexOf(nonUniformlyDistributedArray, target);

        // Act
        int result = InterpolationSearch.Search(nonUniformlyDistributedArray, target);

        // Assert
        Assert.Equal(expectedIndex, result);
    }

    /// <summary>
    ///     Tests the interpolation search method with a target not in the array.
    /// </summary>
    [Fact]
    public void Search_TargetNotInArray_ReturnsMinusOne()
    {
        // Arrange
        int[] uniformlyDistributedArray = GenerateUniformArray(1000);
        int target = 1500;

        // Act
        int result = InterpolationSearch.Search(uniformlyDistributedArray, target);

        // Assert
        Assert.Equal(-1, result);
    }

    /// <summary>
    ///     Tests the interpolation search method with an empty array.
    /// </summary>
    [Fact]
    public void Search_EmptyArray_ReturnsMinusOne()
    {
        // Arrange
        int[] emptyArray = [];
        int target = 10;

        // Act
        int result = InterpolationSearch.Search(emptyArray, target);

        // Assert
        Assert.Equal(-1, result);
    }

    /// <summary>
    ///     Tests the interpolation search method with a single-element array.
    /// </summary>
    [Fact]
    public void Search_SingleElementArray_ReturnsCorrectIndex()
    {
        // Arrange
        int[] singleElementArray = [15];
        int target = 15;
        int expectedIndex = 0;

        // Act
        int result = InterpolationSearch.Search(singleElementArray, target);

        // Assert
        Assert.Equal(expectedIndex, result);
    }

    /// <summary>
    ///     Tests the interpolation search method with a target that is the first element.
    /// </summary>
    [Fact]
    public void Search_FirstElement_ReturnsCorrectIndex()
    {
        // Arrange
        int[] uniformlyDistributedArray = GenerateUniformArray(1000);
        int target = 1;
        int expectedIndex = 0;

        // Act
        int result = InterpolationSearch.Search(uniformlyDistributedArray, target);

        // Assert
        Assert.Equal(expectedIndex, result);
    }

    /// <summary>
    ///     Tests the interpolation search method with a target that is the last element.
    /// </summary>
    [Fact]
    public void Search_LastElement_ReturnsCorrectIndex()
    {
        // Arrange
        int[] uniformlyDistributedArray = GenerateUniformArray(1000);
        int target = 1000;
        int expectedIndex = uniformlyDistributedArray.Length - 1;

        // Act
        int result = InterpolationSearch.Search(uniformlyDistributedArray, target);

        // Assert
        Assert.Equal(expectedIndex, result);
    }

    /// <summary>
    ///     Generates a uniformly distributed array of integers from 1 to length.
    /// </summary>
    /// <param name="length">The length of the array to generate.</param>
    /// <returns>A uniformly distributed sorted array of integers.</returns>
    private int[] GenerateUniformArray(int length)
    {
        var array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = i + 1;
        }
        return array;
    }

    /// <summary>
    ///     Generates a non-uniformly distributed array.
    /// </summary>
    /// <param name="length">The length of the array to generate.</param>
    /// <returns>A non-uniformly distributed sorted array of integers.</returns>
    private int[] GenerateNonUniformArray(int length)
    {
        var array = new int[length];
        for (int i = 0; i < length; i++)
        {
            // First half of the array is densely packed
            if (i < length / 2)
                array[i] = i / 10 + 1;
            else
                // Second half is more sparse
                array[i] = i + 1;
        }
        return array;
    }
}