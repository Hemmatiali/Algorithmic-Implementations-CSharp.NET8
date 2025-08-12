using SortingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLibraryTests;


/// <summary>
///     Unit tests for the <see cref="GappedInsertionSort"/> utility (used by Shell Sort).
/// </summary>
public class GappedInsertionSortTests
{
    /// <summary>
    ///     Applies a standard Shell sequence (n/2, n/4, ..., 1) using GappedInsertionSort
    ///     and verifies the array becomes fully sorted.
    /// </summary>
    [Fact]
    public void Sort_WithShellSequence_ReturnsSortedArray()
    {
        // Arrange
        int[] array = { 34, 2, 25, 12, 22, 11, 90, 3, 18, 45 };
        int[] expected = (int[])array.Clone();
        Array.Sort(expected);

        // Act
        ApplyShellSequence(array);

        // Assert
        Assert.Equal(expected, array);
    }

    /// <summary>
    ///     A single pass with gap=2 should produce a 2-sorted (gap-sorted) array, even if not fully sorted.
    /// </summary>
    [Fact]
    public void Sort_SinglePassGap2_ProducesGapSortedArray()
    {
        // Arrange
        int[] array = { 9, 8, 7, 6, 5, 4, 3, 2 };

        // Act
        GappedInsertionSort.Sort(array, 2);

        // Assert
        Assert.True(IsGapSorted(array, 2));
    }

    /// <summary>
    ///     SortRange should only affect the specified subsection; outside elements remain unchanged.
    ///     Using gap=1 (equivalent to insertion sort) for clarity.
    /// </summary>
    [Fact]
    public void SortRange_SortsOnlySubrange_Gap1()
    {
        // Arrange
        int[] array = { 50, 40, 30, 20, 10, 99, 77, 66, 55 };
        int left = 1; // sort [1..5]
        int right = 5;
        int gap = 1;
        int[] before = (int[])array.Clone();

        // Act
        GappedInsertionSort.SortRange(array, left, right, gap);

        // Assert: subrange sorted
        Assert.True(IsSorted(array[left..(right + 1)]));

        // Assert: elements before 'left' and after 'right' unchanged
        for (int i = 0; i < left; i++)
        {
            Assert.Equal(before[i], array[i]);
        }
        for (int i = right + 1; i < array.Length; i++)
        {
            Assert.Equal(before[i], array[i]);
        }
    }

    /// <summary>
    ///     Invalid gap (zero or negative) should leave the array unchanged.
    /// </summary>
    [Fact]
    public void Sort_InvalidGap_NoChange()
    {
        // Arrange
        int[] array = { 3, 1, 2 };
        int[] expected = (int[])array.Clone();

        // Act
        GappedInsertionSort.Sort(array, 0);
        GappedInsertionSort.Sort(array, -3);

        // Assert
        Assert.Equal(expected, array);
    }

    /// <summary>
    ///     Passing a null array must not throw.
    /// </summary>
    [Fact]
    public void Sort_NullArray_NoThrow()
    {
        // Act
        var ex = Record.Exception(() => GappedInsertionSort.Sort(null!, 2));

        // Assert
        Assert.Null(ex);
    }

    /// <summary>
    ///     Single-element array remains unchanged for any valid gap.
    /// </summary>
    [Fact]
    public void Sort_SingleElementArray_NoChange()
    {
        // Arrange
        int[] array = { 42 };
        int[] expected = { 42 };

        // Act
        GappedInsertionSort.Sort(array, 1);

        // Assert
        Assert.Equal(expected, array);
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
        GappedInsertionSort.Sort(array, 1);

        // Assert
        Assert.Empty(array);
    }

    /// <summary>
    ///     Duplicates should be handled correctly when using a full Shell sequence.
    /// </summary>
    [Fact]
    public void Sort_WithDuplicates_ReturnsSortedArray_UsingShellSequence()
    {
        // Arrange
        int[] array = { 5, 1, 4, 2, 1, 5, 3, 3 };
        int[] expected = (int[])array.Clone();
        Array.Sort(expected);

        // Act
        ApplyShellSequence(array);

        // Assert
        Assert.Equal(expected, array);
    }

    /// <summary>
    ///     Negative numbers are sorted correctly when using a full Shell sequence.
    /// </summary>
    [Fact]
    public void Sort_WithNegativeNumbers_ReturnsSortedArray_UsingShellSequence()
    {
        // Arrange
        int[] array = { -5, -1, -3, -2, 0, 2, 1 };
        int[] expected = (int[])array.Clone();
        Array.Sort(expected);

        // Act
        ApplyShellSequence(array);

        // Assert
        Assert.Equal(expected, array);
    }

    // ---------- Helpers ----------

    /// <summary>
    ///     Applies the classic Shell gap sequence (n/2, n/4, ..., 1) using GappedInsertionSort.
    /// </summary>
    private static void ApplyShellSequence(int[] array)
    {
        for (int gap = array.Length / 2; gap >= 1; gap /= 2)
        {
            GappedInsertionSort.Sort(array, gap);
        }
    }

    /// <summary>
    ///     Checks whether the array is non-decreasing.
    /// </summary>
    private static bool IsSorted(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < arr[i - 1]) return false;
        }
        return true;
    }

    /// <summary>
    ///     Checks whether the array is gap-sorted: for all i, arr[i] &gt;= arr[i-gap].
    /// </summary>
    private static bool IsGapSorted(int[] arr, int gap)
    {
        for (int i = gap; i < arr.Length; i++)
        {
            if (arr[i] < arr[i - gap]) return false;
        }
        return true;
    }
}
