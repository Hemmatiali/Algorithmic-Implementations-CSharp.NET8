# Searching Algorithms

## Overview

Searching algorithms are fundamental techniques used in computer science to retrieve information stored within some data structure. They are essential for efficient data retrieval and are widely used in various applications, from databases to search engines. There are several types of searching algorithms, each with its own advantages and use cases.

## Navigation

- [Binary Search](#binary-search)
- [Linear Search](#linear-search)
- [Sentinel Linear Search](#sentinel-linear-search)
- [Meta Binary Search](#meta-binary-search)

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

## Sentinel Linear Search

### Description

Sentinel linear search is an optimization of the standard linear search algorithm. It works by placing a sentinel value at the end of the array or list, which simplifies the loop condition and reduces the number of comparisons required. This technique is particularly useful when the array or list is large, as it slightly improves the performance of the search.

### Performance

- **Time Complexity**: O(n)
- **Space Complexity**: O(1)

Like standard linear search, sentinel linear search operates in linear time. However, it minimizes the number of checks required to determine whether the target is in the list, making it slightly faster in practice.

### How It Works

1. **Initial Setup**: Place the target value as a sentinel at the end of the array or list.
2. **Iteration**: Start from the first element:
    - If the current element matches the target value, the search is successful, and the index of that element is returned.
    - If the current element does not match, move to the next element.
3. **Sentinel Check**: The loop stops when the target is found, including the sentinel. If the match occurs at the sentinel position, the method checks whether the target was genuinely found within the original bounds of the array or list.
4. **Repeat**: Continue until the target is found or the sentinel is reached.

### Steps and Example

Let's consider an example where we search for the value 7 in an unsorted array: [10, 9, 8, 7, 6, 5, 4, 3, 2, 1].

1. Initial array: [10, 9, 8, 7, 6, 5, 4, 3, 2, 1]
   - Place sentinel at the end of the array.
   - Start at index 0: value = 10 (no match)
   - Move to index 1: value = 9 (no match)
   - Move to index 2: value = 8 (no match)
   - Move to index 3: value = 7 (match found)

2. 7 == 7: Target found at index 3.

### Advantages

- **Efficiency**: Sentinel linear search reduces the number of comparisons needed, making it slightly more efficient than the standard linear search and it is like Guard class for standard linear search.
- **Simplicity**: The algorithm is easy to understand and implement, similar to the standard linear search.

### Limitations

- **Efficiency Gain**: The efficiency gain is minimal compared to standard linear search, so it's most beneficial in large datasets.
- **Applicability**: While it improves linear search, it still doesn't compare to more advanced algorithms like binary search for sorted datasets.

### Implementation in C#.NET 8

You can see the implementation of Sentinel Linear Search in C# in code written in the `SentinelLinearSearch.cs` class.


## Meta Binary Search

### Description

Meta Binary Search is an advanced variation of the standard binary search algorithm. It utilizes either recursion or bitwise operations to perform the search in a more structured or efficient manner. This method is particularly useful when dealing with sorted data and offers an alternative approach to the standard binary search.

### Performance

- **Time Complexity**: O(log n)
- **Space Complexity**: 
  - Recursive Approach: O(log n) due to the stack space used by recursion.
  - Bitwise Approach: O(1) as it operates without additional stack space.

Both approaches maintain logarithmic time complexity, making Meta Binary Search highly efficient for large datasets.

### How It Works

#### Recursive Meta Binary Search

1. **Initial Setup**: Start by dividing the array into halves recursively.
2. **Middle Calculation**: Calculate the middle index of the current range.
3. **Comparison**:
    - If the target matches the middle element, the search is successful.
    - If the target is less than the middle element, search in the left half.
    - If the target is greater than the middle element, search in the right half.
4. **Repeat**: Continue the process recursively until the target is found or the search range is invalid.

#### Bitwise Meta Binary Search

1. **Bit Calculation**: Determine the number of bits needed to represent the largest index.
2. **Bitwise Construction**: Use bitwise operations to construct and navigate potential indices.
3. **Comparison**:
    - Use the constructed indices to compare with the target.
    - Adjust the current position based on the comparison.
4. **Repeat**: Continue the process using bitwise operations until the target is found.

### Steps and Example

Let's consider an example where we search for the value 13 in a sorted array: [1, 3, 5, 7, 9, 11, 13, 15, 17, 19].

#### Recursive Meta Binary Search Example:

1. Initial array: [1, 3, 5, 7, 9, 11, 13, 15, 17, 19]
   - Start at indices 0 to 9.
   - Calculate middle: mid = (0 + 9) / 2 = 4, value = 9
   - 13 > 9: Search the right subarray.
   - Update indices to 5 to 9.
   - Calculate middle: mid = (5 + 9) / 2 = 7, value = 15
   - 13 < 15: Search the left subarray.
   - Update indices to 5 to 6.
   - Calculate middle: mid = (5 + 6) / 2 = 5, value = 11
   - 13 > 11: Search the right subarray.
   - Update indices to 6 to 6.
   - Calculate middle: mid = 6, value = 13
   - 13 == 13: Target found at index 6.

#### Bitwise Meta Binary Search Example:

1. Initial array: [1, 3, 5, 7, 9, 11, 13, 15, 17, 19]
   - Calculate the number of bits required for the largest index (9 in binary is 1001, so 4 bits).
   - Construct index using bitwise operations and navigate the array.
   - Adjust indices based on comparisons until the target is found.

### Advantages

- **Efficiency**: Meta Binary Search is as efficient as standard binary search but offers additional flexibility with its recursive and bitwise approaches.
- **Bitwise Operations**: The bitwise approach can be faster in certain environments where bitwise operations are optimized.

The advantage of Meta Binary Search over binary search is that it can perform fewer comparisons in some cases, particularly when the target element is close to the beginning of the list. The disadvantage is that the algorithm may perform more comparisons than binary search in other cases, particularly when the target element is close to the end of the list. Therefore, Meta Binary Search is most effective when the list is ordered in a way that is consistent with the distribution of the target elements.

### Limitations

- **Complexity**: The bitwise approach may be harder to understand and implement compared to standard binary search.
- **Applicability**: As with binary search, Meta Binary Search is only applicable to sorted datasets.

### Implementation in C#.NET 8

You can see the implementation of Meta Binary Search in C# in code written in the `MetaBinarySearch.cs` class.