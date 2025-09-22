using SortingLibrary;

namespace SortingLibraryTests;

/// <summary>
///     Unit tests for the SleepSort class.
///     NOTE: Sleep Sort is a novelty algorithm; tests keep ranges small and use a delay budget guard.
/// </summary>
public class SleepSortTests
{
    /// <summary>
    ///     Small fixed-range input should sort correctly.
    /// </summary>
    [Fact]
    public void Sort_SmallFixedRange_ReturnsSortedArray()
    {
        // Arrange
        int[] array = { 5, 1, 3, 0, 4, 2 };
        int[] expected = { 0, 1, 2, 3, 4, 5 };

        // Act
        SleepSort.Sort(array, unitDelayMs: 1, maxTotalDelayMs: 500);

        // Assert
        Assert.Equal(expected, array);
    }

    /// <summary>
    ///     Already sorted array stays the same.
    /// </summary>
    [Fact]
    public void Sort_AlreadySortedArray_ReturnsSameArray()
    {
        // Arrange
        int[] array = { 0, 1, 2, 3, 4, 5 };
        int[] expected = { 0, 1, 2, 3, 4, 5 };

        // Act
        SleepSort.Sort(array, unitDelayMs: 1, maxTotalDelayMs: 500);

        // Assert
        Assert.Equal(expected, array);
    }

    /// <summary>
    ///     Reverse-sorted small-range array becomes sorted.
    /// </summary>
    [Fact]
    public void Sort_ReverseSortedSmallRange_ReturnsSortedArray()
    {
        // Arrange
        int[] array = { 5, 4, 3, 2, 1, 0 };
        int[] expected = { 0, 1, 2, 3, 4, 5 };

        // Act
        SleepSort.Sort(array, unitDelayMs: 1, maxTotalDelayMs: 500);

        // Assert
        Assert.Equal(expected, array);
    }

    /// <summary>
    ///     Handles duplicates correctly.
    /// </summary>
    [Fact]
    public void Sort_WithDuplicates_ReturnsSortedArray()
    {
        // Arrange
        int[] array = { 2, 1, 2, 1, 0, 0, 3, 3 };
        int[] expected = { 0, 0, 1, 1, 2, 2, 3, 3 };

        // Act
        SleepSort.Sort(array, unitDelayMs: 1, maxTotalDelayMs: 500);

        // Assert
        Assert.Equal(expected, array);
    }

    /// <summary>
    ///     Small-range negatives are supported (delays are relative to the minimum).
    /// </summary>
    [Fact]
    public void Sort_WithNegativeNumbersSmallRange_ReturnsSortedArray()
    {
        // Arrange
        int[] array = { -2, -1, -2, 0, 1, -1 };
        int[] expected = { -2, -2, -1, -1, 0, 1 };

        // Act
        SleepSort.Sort(array, unitDelayMs: 2, maxTotalDelayMs: 500);

        // Assert
        Assert.Equal(expected, array);
    }

    /// <summary>
    ///     Single-element array remains unchanged.
    /// </summary>
    [Fact]
    public void Sort_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] array = { 42 };
        int[] expected = { 42 };

        // Act
        SleepSort.Sort(array, unitDelayMs: 1, maxTotalDelayMs: 100);

        // Assert
        Assert.Equal(expected, array);
    }

    /// <summary>
    ///     Empty array remains unchanged.
    /// </summary>
    [Fact]
    public void Sort_EmptyArray_ReturnsSameArray()
    {
        // Arrange
        int[] array = Array.Empty<int>();

        // Act
        SleepSort.Sort(array, unitDelayMs: 1, maxTotalDelayMs: 100);

        // Assert
        Assert.Empty(array);
    }

    /// <summary>
    ///     All-equal array remains unchanged and completes quickly.
    /// </summary>
    [Fact]
    public void Sort_AllEqualElements_ReturnsSameArray()
    {
        // Arrange
        int[] array = { 7, 7, 7, 7 };
        int[] expected = { 7, 7, 7, 7 };

        // Act
        SleepSort.Sort(array, unitDelayMs: 1, maxTotalDelayMs: 100);

        // Assert
        Assert.Equal(expected, array);
    }

    /// <summary>
    ///     Excessive range should trigger the delay-budget guard (prevents long sleeps).
    /// </summary>
    [Fact]
    public void Sort_RangeExceedsBudget_ThrowsInvalidOperationException()
    {
        // Arrange: Range 0..500 with 10ms per unit needs ~5000ms, budget is 1000ms
        int[] array = { 0, 500 };

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() =>
            SleepSort.Sort(array, unitDelayMs: 10, maxTotalDelayMs: 1000));
    }

    /// <summary>
    ///     Non-positive unitDelayMs should be sanitized and still sort correctly.
    /// </summary>
    [Fact]
    public void Sort_ZeroUnitDelay_IsSanitized_SortsCorrectly()
    {
        // Arrange
        int[] array = { 2, 1, 0 };
        int[] expected = { 0, 1, 2 };

        // Act
        SleepSort.Sort(array, unitDelayMs: 0, maxTotalDelayMs: 100);

        // Assert
        Assert.Equal(expected, array);
    }

    /// <summary>
    ///     Passing null must not throw (no-op).
    /// </summary>
    [Fact]
    public void Sort_NullArray_NoThrow()
    {
        // Act
        var ex = Record.Exception(() => SleepSort.Sort(null!));

        // Assert
        Assert.Null(ex);
    }
}
