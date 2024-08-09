# Searching Algorithms

## Overview

Searching algorithms are fundamental techniques used in computer science to retrieve information stored within some data structure. They are essential for efficient data retrieval and are widely used in various applications, from databases to search engines. There are several types of searching algorithms, each with its own advantages and use cases.

## Navigation

- [Binary Search](#binary-search)
- [Linear Search](#linear-search)

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

You can see the implementation of Binary Search in C# in code written in the `BinarySearch.cs` class.

## Linear Search

### Description

Linear search is the simplest searching algorithm. It works by iterating through each element in a list or array until it finds the target value. Unlike binary search, linear search does not require the data to be sorted, making it applicable in more general cases, though it is less efficient.

### Performance

- **Time Complexity**: O(n)
- **Space Complexity**: O(1)

Linear search operates in linear time, meaning that the time it takes to search an element grows linearly with the size of the input data. This makes linear search less efficient for large datasets compared to binary search.

### How It Works

1. **Initial Setup**: Start from the first element in the array or list.
2. **Iteration**: Check each element one by one:
    - If the current element matches the target value, the search is successful, and the index of that element is returned.
    - If the current element does not match the target value, move to the next element.
3. **Repeat**: Continue the process until either the target is found, or the end of the list is reached, indicating that the target is not present.

### Steps and Example

Let's consider an example where we search for the value 7 in an unsorted array: [10, 9, 8, 7, 6, 5, 4, 3, 2, 1].

1. Initial array: [10, 9, 8, 7, 6, 5, 4, 3, 2, 1]
   - Start at index 0: value = 10 (no match)
   - Move to index 1: value = 9 (no match)
   - Move to index 2: value = 8 (no match)
   - Move to index 3: value = 7 (match found)

2. 7 == 7: Target found at index 3.

### Advantages

- **Simplicity**: Linear search is easy to understand and implement.
- **Flexibility**: It can be used on unsorted data and works on all data structures that allow traversal.

### Limitations

- **Efficiency**: Linear search is less efficient than binary search for large datasets.
- **Scalability**: As the size of the dataset grows, the time taken by linear search increases linearly, making it impractical for large datasets.

### Implementation in C#.NET 8

You can see the implementation of Linear Search in C# in code written in the `LinearSearch.cs` class.
