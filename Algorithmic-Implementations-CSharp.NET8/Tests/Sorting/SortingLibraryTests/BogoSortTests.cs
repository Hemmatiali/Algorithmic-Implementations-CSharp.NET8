using SortingLibrary;

namespace SortingLibraryTests;


/// <summary>
///     Unit tests for the BogoSort class.
///     NOTE: Bogo Sort is randomized and intentionally inefficient; tests use tiny arrays and/or guards.
/// </summary>
public class BogoSortTests
{
    /// <summary>
    ///     Already-sorted small array should remain unchanged and complete immediately (no shuffles needed).
    /// </summary>
    [Fact]
    public void Sort_AlreadySortedSmallArray_ReturnsSameArray()
    {
        // Arrange
        int[] array = { 1, 2, 3 };
        int[] expected = { 1, 2, 3 };

        // Act
        BogoSort.Sort(array, maxShuffles: 0); // guard 0 is fine because it's sorted at the start

        // Assert
        Assert.Equal(expected, array);
    }

    /// <summary>
    ///     Unsorted tiny array (length 3) should sort within a generous shuffle cap (to avoid flakiness).
    /// </summary>
    [Fact]
    public void Sort_UnsortedVerySmallArray_SortsWithinCap()
    {
        // Arrange
        int[] array = { 3, 1, 2 };
        int[] expected = { 1, 2, 3 };

        // Act
        BogoSort.Sort(array, maxShuffles: 1_000_000); // Large cap to make the test robust

        // Assert
        Assert.Equal(expected, array);
    }

    /// <summary>
    ///     When the array is not sorted and maxShuffles is 0, the method should throw.
    /// </summary>
    [Fact]
    public void Sort_UnsortedArray_ThrowsAfterMaxShuffles()
    {
        // Arrange
        int[] array = { 2, 1 };

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => BogoSort.Sort(array, maxShuffles: 0));
    }

    /// <summary>
    ///     Empty array remains unchanged.
    /// </summary>
    [Fact]
    public void Sort_EmptyArray_NoChange()
    {
        // Arrange
        int[] array = Array.Empty<int>();

        // Act
        BogoSort.Sort(array);

        // Assert
        Assert.Empty(array);
    }

    /// <summary>
    ///     Single-element array remains unchanged.
    /// </summary>
    [Fact]
    public void Sort_SingleElementArray_NoChange()
    {
        // Arrange
        int[] array = { 42 };

        // Act
        BogoSort.Sort(array);

        // Assert
        Assert.Equal(new[] { 42 }, array);
    }

    /// <summary>
    ///     All-equal elements remain unchanged and should complete immediately.
    /// </summary>
    [Fact]
    public void Sort_AllEqualElements_NoChange()
    {
        // Arrange
        int[] array = { 7, 7, 7, 7 };
        int[] expected = { 7, 7, 7, 7 };

        // Act
        BogoSort.Sort(array, maxShuffles: 0);

        // Assert
        Assert.Equal(expected, array);
    }

    /// <summary>
    ///     Passing null should not throw (method is a no-op on null).
    /// </summary>
    [Fact]
    public void Sort_NullArray_NoThrow()
    {
        // Act
        var ex = Record.Exception(() => BogoSort.Sort(null!));

        // Assert
        Assert.Null(ex);
    }
}

