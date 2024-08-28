# Searching Algorithms

## Overview

Searching algorithms are fundamental techniques used in computer science to retrieve information stored within some data structure. They are essential for efficient data retrieval and are widely used in various applications, from databases to search engines. There are several types of searching algorithms, each with its own advantages and use cases.

## Navigation

- [Binary Search](#binary-search)
- [Linear Search](#linear-search)
- [Sentinel Linear Search](#sentinel-linear-search)
- [Meta Binary Search](#meta-binary-search)
- [Ternary Search](#ternary-search)
- [Jump Search](#jump-search)
- [Interpolation Search](#interpolation-search)
- [Exponential Search](#exponential-search)
- [Fibonacci Search](#fibonacci-search)

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


## Ternary Search

### Description

Ternary Search is a divide-and-conquer search algorithm that splits the search space into three parts, rather than the two parts used in binary search. It is applied to a sorted array and works by recursively determining which third of the array contains the target element.

### Performance

- **Time Complexity**: O(2 * log3 n)
- **Space Complexity**: 
  - Recursive Approach: O(log3 n) due to the stack space used by recursion.


The time complexity is slightly better than binary search theoretically, but in practice, binary search often outperforms ternary search due to fewer comparisons and simpler implementation.

### How It Works

1. **Initial Setup**: Start with two pointers, `left` and `right`, representing the current range of elements being searched.
2. **Calculate Midpoints**:
   - Calculate two midpoints: `mid1` and `mid2`, which divide the range into three equal parts.
   - `mid1` is at one-third of the way between `left` and `right`.
   - `mid2` is at two-thirds of the way between `left` and `right`.
3. **Comparison**:
   - If the target value equals the element at `mid1`, the search is successful, and the index `mid1` is returned.
   - If the target value equals the element at `mid2`, the search is successful, and the index `mid2` is returned.
   - If the target value is less than the element at `mid1`, repeat the process in the left third.
   - If the target value is greater than the element at `mid2`, repeat the process in the right third.
   - Otherwise, repeat the process in the middle third.
4. **Repeat**: Continue the process recursively until the target is found or the range becomes invalid.

### Steps and Example

Let's consider an example where we search for the value 9 in a sorted array: [1, 3, 5, 7, 9, 11, 13, 15, 17, 19].

1. Initial array: [1, 3, 5, 7, 9, 11, 13, 15, 17, 19]
   - Calculate mid1 and mid2:
     - mid1 = (0 + 9) / 3 = 3 (index), value = 7
     - mid2 = 2 * (0 + 9) / 3 = 6 (index), value = 13
   - 9 > 7 and 9 < 13: Search the middle third.
2. New search range: [5, 7, 9, 11, 13] (indices 3 to 6)
   - Calculate mid1 and mid2:
     - mid1 = (3 + 6) / 3 = 4 (index), value = 9
     - mid2 = 2 * (3 + 6) / 3 = 5 (index), value = 11
   - 9 == 9: Target found at index 4.

### Advantages

- **Efficiency**: Ternary search theoretically has a better time complexity than binary search but is more complex.
- **Divide-and-Conquer**: It further divides the search space, which can be useful in specific applications where such division is beneficial.

### Limitations

- **Practical Performance**: Despite its theoretical advantages, binary search usually outperforms ternary search in practice due to fewer comparisons and overhead.
- **Complexity**: Ternary search is more complex to implement and understand compared to binary search.

### Implementation in C#.NET 8

You can see the implementation of Ternary Search in C# in code written in the `TernarySearch.cs` class.


## Jump Search

### Description

Jump Search is an efficient search algorithm designed for ordered lists. It works by dividing the list into blocks of a fixed size and jumping ahead by these block sizes to find a block that contains the target value. Once the appropriate block is found, a linear search is performed within that block.

### Performance

- **Time Complexity**: O(√n)
- **Space Complexity**: O(1)

Jump Search provides a middle ground between linear search and binary search, offering better performance than linear search with a lower complexity than binary search, making it ideal for large sorted datasets.

### How It Works

1. **Initial Setup**: Calculate the optimal block size, typically the square root of the array length.
2. **Jumping**:
   - Start at the beginning of the array and jump ahead by the block size until you find a block where the target might be present.
3. **Linear Search**:
   - Once the correct block is identified, perform a linear search within the block to locate the target.
4. **Return the Result**: If the target is found, return its index; otherwise, return -1.

### Steps and Example

Let's consider an example where we search for the value 15 in a sorted array: [1, 3, 5, 7, 9, 11, 13, 15, 17, 19].

1. Initial array: [1, 3, 5, 7, 9, 11, 13, 15, 17, 19]
   - Calculate the optimal block size: √10 ≈ 3.
2. Start at index 0:
   - Value = 1, not 15. Jump to index 3.
   - Value = 7, not 15. Jump to index 6.
   - Value = 13, not 15. Jump to index 9.
3. Since 13 < 15 < 19, perform a linear search between indices 7 and 9.
   - Value at index 7 = 15. Target found at index 7.

### Advantages

- **Efficiency**: Faster than linear search, especially for large datasets, while simpler than binary search.
- **Simplicity**: Easy to implement and understand, making it a good choice when a binary search is not necessary.

### Limitations

- **Sorted Data**: Jump Search can only be applied to a sorted list of elements.
- **Optimal Jump Size**: The efficiency of Jump Search relies on choosing an appropriate block size, which is generally the square root of the array length.

### Implementation in C#.NET 8

You can see the implementation of Jump Search in C# in code written in the `JumpSearch.cs` class.


## Interpolation Search

### Description

Interpolation Search is an advanced search algorithm for finding an element in a sorted array. It improves on binary search by estimating the likely position of the target based on the value of the target relative to the values at the current bounds. This makes it particularly effective for searching in uniformly distributed datasets.

### Performance

- **Best-Case Time Complexity**: O(log2(log2 n)) — This occurs when the data is uniformly distributed.
- **Worst-Case Time Complexity**: O(n) — This occurs when the data is non-uniformly distributed or the distribution is skewed.
- **Space Complexity**: O(1) — The algorithm requires a constant amount of additional space.

Interpolation Search can outperform binary search in the best case because it uses a more accurate guess about where the target might be, reducing the number of comparisons needed. However, in the worst case, particularly with non-uniformly distributed data, its performance can degrade to linear time.

### How It Works

1. **Initial Setup**: Start with two pointers, `low` and `high`, representing the current search bounds of the array.
2. **Position Calculation**: Estimate the position of the target using the interpolation formula:
   - `pos = low + ((target - array[low]) * (high - low)) / (array[high] - array[low]);`
   - This formula calculates the likely position of the target based on its value relative to the values at the `low` and `high` indices.
3. **Comparison**:
   - If the target is found at the estimated position, return the index.
   - If the target is greater than the element at `pos`, move the `low` pointer to `pos + 1` and continue the search in the upper part of the array.
   - If the target is less than the element at `pos`, move the `high` pointer to `pos - 1` and continue the search in the lower part of the array.
4. **Repeat**: Continue the process until the target is found or the search range becomes invalid.

### Steps and Example

Let's consider an example where we search for the value 15 in a uniformly distributed sorted array: [1, 3, 5, 7, 9, 11, 13, 15, 17, 19].

1. Initial array: [1, 3, 5, 7, 9, 11, 13, 15, 17, 19]
   - Set `low = 0` and `high = 9`.
   - Calculate `pos` using the interpolation formula.
   - Position calculation: `pos = 0 + ((15 - 1) * (9 - 0)) / (19 - 1) = 7`.
   - Check `array[pos]`, which is 15. Target found at index 7.

### Advantages

- **Efficiency**: In the best case, Interpolation Search can be much faster than binary search due to its more accurate guess of the target's position.
- **Simplicity**: The algorithm is straightforward to implement and provides an interesting alternative to binary search for uniformly distributed data.

### Limitations

- **Data Distribution**: Interpolation Search is most effective with uniformly distributed data. If the data is skewed or non-uniform, the performance can degrade significantly.
- **Worst-Case Performance**: In cases where the data is not uniformly distributed, the time complexity can degrade to O(n), making it less efficient than binary search.

### Implementation in C#.NET 8

You can see the implementation of Interpolation Search in C# in code written in the `InterpolationSearch.cs` class.


## Exponential Search

### Description

Exponential Search is an advanced search algorithm designed for sorted arrays. It works by quickly finding a range where the target value may reside using exponential jumps, followed by a binary search within that range. This makes it particularly effective for large datasets, especially when the target is near the beginning of the array.

### Performance

- **Time Complexity**: 
  - **Best-Case**: O(log n) — This occurs when the target is near the beginning of the array.
  - **Average-Case**: O(log n) — Similar to binary search in most cases, as binary search is performed on a subset of the array.
  - **Worst-Case**: O(log n) — This occurs when the target is near the end of the array, as it requires more jumps and binary search over a larger range.
- **Space Complexity**: O(1) — The algorithm requires a constant amount of additional space.

Exponential Search combines the efficiency of binary search with a fast initial range determination, making it particularly useful for large, sorted datasets.

### How It Works

1. **Initial Setup**: Start by checking if the target is the first element.
2. **Exponential Range Finding**:
   - Begin with a range of size 1 and exponentially increase the range by doubling the index (`i = 1, 2, 4, 8, ...`) until the value at the current index exceeds the target or the end of the array is reached.
3. **Binary Search**:
   - Once the range is determined, perform a binary search within that range to find the exact position of the target.
4. **Return the Result**: If the target is found, return its index; otherwise, return -1.

### Steps and Example

Let's consider an example where we search for the value 15 in a sorted array: [1, 3, 5, 7, 9, 11, 13, 15, 17, 19].

1. Initial array: [1, 3, 5, 7, 9, 11, 13, 15, 17, 19]
   - Start with `i = 1`.
   - Continue doubling the index until `array[i]` exceeds the target:
     - `i = 1` → array[1] = 3
     - `i = 2` → array[2] = 5
     - `i = 4` → array[4] = 9
     - `i = 8` → array[8] = 17 (stop here, since 17 > 15)
   - Perform binary search in the range [4, 8].
   - Binary search finds the target at index 7.

### Advantages

- **Efficiency**: Exponential Search is particularly fast when the target is near the beginning of the array.
- **Combines Techniques**: By combining exponential jumps with binary search, the algorithm effectively narrows down the search space quickly and efficiently.

### Limitations

- **Sorted Data**: Exponential Search can only be applied to a sorted list of elements.
- **Large Gaps**: If there are large gaps in the array, the initial exponential jumps might overshoot, requiring a broader binary search.

### Implementation in C#.NET 8

You can see the implementation of Exponential Search in C# in code written in the `ExponentialSearch.cs` class. The implementation includes both a basic and an iterative version of the algorithm.


## Fibonacci Search

### Description

Fibonacci Search is an advanced search algorithm that uses Fibonacci numbers to divide the search space into smaller parts, similar to binary search. The key difference is that Fibonacci Search uses the Fibonacci sequence to calculate the index at which the array should be split, which can offer better performance in some scenarios, particularly for larger datasets.

### Performance

- **Time Complexity**: O(log n) — The time complexity is similar to that of binary search, as the search space is repeatedly divided.
- **Space Complexity**: O(1) — The algorithm requires only a constant amount of additional space.

Fibonacci Search is particularly effective for searching in sorted arrays, and while it generally performs similarly to binary search, its use of Fibonacci numbers can make it more efficient in certain situations.

### How It Works

1. **Fibonacci Initialization**: Initialize the Fibonacci numbers `fibMm2` (m-2), `fibMm1` (m-1), and `fibM` (m) such that `fibM` is the smallest Fibonacci number greater than or equal to the length of the array.
2. **Range Elimination**:
   - Compare the target value with the element at the Fibonacci index.
   - Depending on the comparison, adjust the Fibonacci numbers and update the offset to narrow down the search range.
3. **Final Comparison**: After narrowing down the search range, make a final comparison to determine if the target value is present.
4. **Return the Result**: If the target is found, return its index; otherwise, return -1.

### Steps and Example

Let's consider an example where we search for the value 15 in a sorted array: [1, 3, 5, 7, 9, 11, 13, 15, 17, 19].

1. Initial array: [1, 3, 5, 7, 9, 11, 13, 15, 17, 19]
   - Initialize Fibonacci numbers: `fibMm2 = 0`, `fibMm1 = 1`, `fibM = 1`.
   - Update Fibonacci numbers until `fibM >= n`:
     - `fibMm2 = 1`, `fibMm1 = 1`, `fibM = 2`
     - `fibMm2 = 1`, `fibMm1 = 2`, `fibM = 3`
     - Continue updating until `fibM = 13`.
   - Compare the target value with the element at the Fibonacci index.
   - Narrow down the search range and repeat until the target is found at index 7.

### Advantages

- **Efficiency**: Fibonacci Search can be more efficient than binary search in certain scenarios, particularly when the data distribution favors the Fibonacci sequence.
- **Simple Implementation**: The algorithm is straightforward to implement and requires minimal additional space.

### Limitations

- **Sorted Data**: Like binary search, Fibonacci Search can only be applied to sorted arrays.
- **Performance Variability**: While Fibonacci Search can outperform binary search in some cases, it is generally comparable in performance and may not always offer a significant advantage.

### Implementation in C#.NET 8

You can see the implementation of Fibonacci Search in C# in code written in the `FibonacciSearch.cs` class.