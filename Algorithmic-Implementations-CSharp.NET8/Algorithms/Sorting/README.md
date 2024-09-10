# Sorting Algorithms

## Overview

Sorting algorithms are essential techniques used in computer science to reorder elements in a specific order, typically in ascending or descending order. They are widely used in various applications such as searching, data analysis, and more. There are different types of sorting algorithms, each with its own strengths and weaknesses, stable and unstable, and appropriate for different types of data and use cases.

## Selection Sort

### Description

Selection Sort is an in-place comparison-based sorting algorithm. It divides the array into two parts: the sorted part and the unsorted part. Initially, the sorted part is empty, and the unsorted part contains all elements. The algorithm proceeds by repeatedly finding the minimum element from the unsorted part and swapping it with the first element of the unsorted part.

### Performance

- **Time Complexity**: O(n^2)
- **Space Complexity**: O(1)
- **Auxiliary Space**: O(1)
- **Stability**: Selection Sort is not stable.
- **In-Place**: Yes

### How It Works

1. **Initial Setup**: The array is divided into two subarrays: a sorted subarray and an unsorted subarray. Initially, the sorted subarray is empty.
2. **Finding the Minimum**: The algorithm finds the minimum element from the unsorted subarray and swaps it with the first element in the unsorted subarray.
3. **Move Boundary**: The boundary between the sorted and unsorted subarrays shifts, and the smallest element is moved to the sorted portion.
4. **Repeat**: This process is repeated until the entire array is sorted.

### Steps and Example

Let's consider an example where we sort the following array: [64, 25, 12, 22, 11].

1. Initial array: [64, 25, 12, 22, 11]
   - Find the minimum element (11) and swap it with the first element (64).
   - New array: [11, 25, 12, 22, 64]

2. Find the minimum in the remaining unsorted array [25, 12, 22, 64].
   - Find 12 and swap it with the first unsorted element (25).
   - New array: [11, 12, 25, 22, 64]

3. Repeat the process:
   - Swap 22 and 25 to get [11, 12, 22, 25, 64].
   - The array is now sorted.

### Advantages

- **Simplicity**: The algorithm is simple to understand and implement.
- **Memory Efficiency**: Since it is an in-place algorithm, it requires no additional memory other than a few variables for swapping.

### Limitations

- **Inefficiency for Large Arrays**: Selection Sort has a time complexity of O(n^2), making it inefficient for large datasets.
- **Not Stable**: Selection Sort is not a stable sorting algorithm, meaning it may not preserve the relative order of equal elements.

### Implementation in C#.NET 8

You can see the implementation of Selection Sort in C# in the `SelectionSort.cs` class. The algorithm is implemented using the in-place approach with a helper method for swapping elements.

