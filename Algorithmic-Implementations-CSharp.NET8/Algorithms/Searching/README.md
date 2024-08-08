
# Searching Algorithms

## Overview

Searching algorithms are fundamental techniques used in computer science to retrieve information stored within some data structure. They are essential for efficient data retrieval and are widely used in various applications, from databases to search engines. There are several types of searching algorithms, each with its own advantages and use cases.

## Binary Search

### Description

Binary search is a highly efficient algorithm for finding an item from a sorted list of items. It works by repeatedly dividing the search interval in half, which allows it to quickly eliminate large portions of the search space. Binary search is much faster than linear search, especially for large datasets.

### Performance

- **Time Complexity**: O(log n)
- **Space Complexity**: O(1)

Binary search operates in logarithmic time, meaning that the time it takes to search an element grows logarithmically with the size of the input data. This makes binary search extremely efficient for large datasets.

### How It Works

1. **Initial Setup**: Start with two pointers, `low` and `high`, which represent the current range of elements being searched. Initially, `low` is set to 0, and `high` is set to the length of the list minus one.
2. **Calculate Midpoint**: Find the midpoint of the current range using the formula: `mid = low + (high - low) / 2`.
3. **Comparison**:
    - If the target value equals the middle element, the search is successful, and the index of the middle element is returned.
    - If the target value is less than the middle element, adjust the `high` pointer to `mid - 1` and repeat the process for the left subarray.
    - If the target value is greater than the middle element, adjust the `low` pointer to `mid + 1` and repeat the process for the right subarray.
4. **Repeat**: Continue the process until the `low` pointer exceeds the `high` pointer, indicating that the target value is not present in the list.



### Steps and Example

Let's consider an example where we search for the value 23 in a sorted array: [1, 5, 8, 12, 15, 23, 28, 32, 38, 45].

low and high are indexes.

1. Initial array: [1, 5, 8, 12, 15, 23, 28, 32, 38, 45]
   - low = 0, high = 9
   - mid = (0 + 9) / 2 = 4
   - mid element = 15

2. 23 > 15: Search the right subarray
   - low = 5, high = 9
   - mid = (5 + 9) / 2 = 7
   - mid element = 32

3. 23 < 32: Search the left subarray
   - low = 5, high = 6
   - mid = (5 + 6) / 2 = 5
   - mid element = 23

4. 23 == 23: Target found at index 5.

### Advantages

- **Efficiency**: Binary search is significantly faster than linear search, particularly for large datasets.
- **Simplicity**: Despite its efficiency, the binary search algorithm is simple and easy to implement.

### Limitations

- **Sorted Data**: Binary search can only be applied to a sorted list of elements.
- **Complexity**: Understanding and implementing binary search can be more complex than linear search, especially for beginners.

### Implementation in C#.NET 8

You can see the implementation of Binary Search in C# in code written in `BinarySearch.cs` class.
