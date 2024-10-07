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


## Bubble Sort

### Description

Bubble Sort is one of the simplest sorting algorithms. It works by repeatedly stepping through the list, comparing adjacent elements, and swapping them if they are in the wrong order. The algorithm gets its name because the largest elements "bubble up" to the end of the array after each pass. The process repeats until the array is sorted.

### Performance

- **Time Complexity**:
  - **Best Case**: O(n) (when the array is already sorted)
  - **Average Case**: O(n^2)
  - **Worst Case**: O(n^2)
- **Space Complexity**: O(1) (in-place sorting)
- **Stability**: Bubble Sort is a stable sorting algorithm, meaning it preserves the relative order of equal elements.
- **In-Place**: Yes

### How It Works

1. **Initial Setup**: The algorithm compares each pair of adjacent elements.
2. **Swapping**: If the element on the left is larger than the one on the right, they are swapped.
3. **Repeat**: After each pass, the largest unsorted element moves to its correct position.
4. **Optimization**: If no swaps are made in a pass, the array is already sorted, and the algorithm terminates early.

### Steps and Example

Let's consider an example where we sort the following array: [64, 34, 25, 12, 22, 11, 90].

1. Initial array: [64, 34, 25, 12, 22, 11, 90]
   - Compare 64 and 34 → swap → New array: [34, 64, 25, 12, 22, 11, 90]
   - Compare 64 and 25 → swap → New array: [34, 25, 64, 12, 22, 11, 90]
   - Continue this process until the end of the array.

2. After the first pass, the largest element (90) will be in its correct position:
   - New array: [34, 25, 12, 22, 11, 64, 90]

3. The process repeats until the entire array is sorted.

### Advantages

- **Simple to Implement**: Bubble Sort is one of the simplest sorting algorithms to implement and understand.
- **Stable Sorting**: Since it preserves the relative order of equal elements, it is a stable sorting algorithm.
- **Good for Small Datasets**: Although it is not efficient for large datasets, it works well for small datasets and when the array is nearly sorted.

### Limitations

- **Inefficient for Large Arrays**: Bubble Sort has a time complexity of O(n^2), making it impractical for large datasets.
- **Slow**: It is slower compared to other algorithms such as Quick Sort or Merge Sort, especially for large datasets.

### Implementation in C#.NET 8

You can see the implementation of Bubble Sort in C# in the `BubbleSort.cs` class. The algorithm uses an optimized version of Bubble Sort that terminates early if no swaps are made during a pass.


## Recursive Bubble Sort

### Description

Recursive Bubble Sort is a variation of the Bubble Sort algorithm that uses recursion instead of iteration. The logic behind the sorting process remains the same: the largest element "bubbles" up to the correct position in each pass, and the function is recursively called to sort the rest of the array.

### Performance

- **Time Complexity**: O(n^2) in the best, average, and worst cases (same as iterative bubble sort)
- **Space Complexity**: O(n) (due to the recursive call stack)
- **Stability**: Recursive Bubble Sort is stable, meaning it preserves the relative order of equal elements.
- **In-Place**: Yes

### How It Works

1. **Base Case**: The recursion stops when the array has only one element or no elements.
2. **One Pass**: The function goes through the unsorted portion of the array, performing one pass of bubble sort by comparing and swapping adjacent elements.
3. **Recursive Call**: After each pass, the largest element is placed in its correct position, and the function calls itself recursively to sort the remaining unsorted portion of the array.

### Steps and Example

Let's consider an example where we sort the following array: [64, 34, 25, 12, 22, 11, 90].

1. Initial array: [64, 34, 25, 12, 22, 11, 90]
   - Compare 64 and 34 → swap → New array: [34, 64, 25, 12, 22, 11, 90]
   - Continue this process until the largest element "90" is placed at the end.

2. Recursive call for the remaining array:
   - Recursive pass: Sort the first n-1 elements.
   - Continue sorting the array recursively until the base case is reached.

### Advantages

- **Simple to Implement**: Recursive Bubble Sort is easy to implement and understand, similar to the iterative version.
- **Good for Teaching**: It's a useful example for understanding recursion.

### Limitations

- **Inefficient for Large Arrays**: Recursive Bubble Sort, like iterative bubble sort, has a time complexity of O(n^2), making it inefficient for large datasets.
- **Memory Usage**: The recursive approach uses O(n) space due to the recursive call stack, making it less memory-efficient compared to the iterative version.

### Implementation in C#.NET 8

You can see the implementation of Recursive Bubble Sort in C# in the `RecursiveBubbleSort.cs` class. The algorithm uses recursion to sort the array by calling the `Sort` method with progressively smaller subarrays.



## Insertion Sort

### Description

Insertion Sort is a simple and intuitive comparison-based sorting algorithm. It works similarly to the way we sort playing cards in our hands. The array is virtually split into two parts: a sorted subarray and an unsorted subarray. Elements from the unsorted subarray are picked one by one and inserted into their correct position in the sorted subarray.


### Performance

- **Time Complexity**:
  - **Best Case**: O(n) (when the array is already sorted)
  - **Average Case**: O(n^2)
  - **Worst Case**: O(n^2)
- **Space Complexity**: O(1) (in-place sorting)
- **Stability**: Insertion Sort is a stable sorting algorithm, meaning it preserves the relative order of equal elements.
- **In-Place**: Yes


### How It Works

1. **Initial Setup**: The algorithm starts by assuming that the first element is already sorted. Then, it picks each element from the unsorted subarray and compares it with elements in the sorted subarray.
2. **Shifting**: If an element in the sorted subarray is larger than the picked element, it is shifted one position to the right to make space for the picked element.
3. **Insertion**: The picked element is inserted into its correct position in the sorted subarray.
4. **Repeat**: This process is repeated for each element in the unsorted subarray until the entire array is sorted.

### Steps and Example

Let's consider an example where we sort the following array: [12, 11, 13, 5, 6].

1. Initial array: [12, 11, 13, 5, 6]
   - Start by picking 11, compare with 12 and insert it before 12.
   - New array: [11, 12, 13, 5, 6]

2. Pick 13 and place it in its correct position:
   - No shifting needed, array remains: [11, 12, 13, 5, 6]

3. Pick 5, compare with 13, 12, and 11, and insert it at the beginning:
   - New array: [5, 11, 12, 13, 6]

4. Finally, pick 6, and place it in the correct position between 5 and 11:
   - New array: [5, 6, 11, 12, 13]

The array is now sorted.

### Advantages

- **Simplicity**: Insertion Sort is easy to implement and understand.
- **Efficient for Small Arrays**: It works well for small datasets or nearly sorted arrays, where it can be more efficient than more complex algorithms like Quick Sort or Merge Sort.
- **Online Sorting**: It can sort data as it receives it, making it an online algorithm.

### Limitations

- **Inefficient for Large Arrays**: Insertion Sort has a time complexity of O(n^2), making it inefficient for large datasets.
- **Shifting Overhead**: As elements need to be shifted to make space for the new element, the overhead can increase for large arrays, particularly when the array is sorted in reverse order.

### Implementation in C#.NET 8

You can see the implementation of Insertion Sort in C# in the `InsertionSort.cs` class. The algorithm is implemented using an in-place approach, meaning it sorts the array without needing extra space for a copy of the array.


## Merge Sort

### Description

Merge Sort is a highly efficient, comparison-based sorting algorithm that follows the **divide and conquer** paradigm. It works by recursively splitting the array into two halves, sorting each half, and then merging them back together in sorted order. This approach allows Merge Sort to achieve better time complexity than algorithms like Bubble Sort and Insertion Sort, especially for larger datasets.

### Performance

- **Time Complexity**:
  - **Best Case**: O(n log n)
  - **Average Case**: O(n log n)
  - **Worst Case**: O(n log n)
- **Space Complexity**: O(n) (due to the need for temporary arrays during the merge process)
- **Stability**: Merge Sort is a stable sorting algorithm, meaning it preserves the relative order of equal elements.
- **In-Place**: No, Merge Sort requires additional space to store the divided subarrays.


### How It Works

1. **Divide**: The array is recursively split into two halves until each subarray has only one element (which is inherently sorted).
2. **Merge**: The sorted subarrays are then merged back together by comparing the smallest elements from each subarray and copying them into the original array in sorted order.
3. **Repeat**: This process continues until the entire array is sorted.

### Steps and Example

Let's consider an example where we sort the following array: [12, 11, 13, 5, 6, 7].

1. Initial array: [12, 11, 13, 5, 6, 7]
   - Split into two halves: [12, 11, 13] and [5, 6, 7]

2. Recursively split both halves:
   - [12, 11, 13] → [12], [11, 13] → [11], [13]
   - [5, 6, 7] → [5], [6, 7] → [6], [7]

3. Merge sorted subarrays:
   - Merge [11] and [13] → [11, 13]
   - Merge [12] and [11, 13] → [11, 12, 13]
   - Merge [6] and [7] → [6, 7]
   - Merge [5] and [6, 7] → [5, 6, 7]

4. Final merge:
   - Merge [11, 12, 13] and [5, 6, 7] → [5, 6, 7, 11, 12, 13]

The array is now sorted.

### Advantages

- **Efficiency for Large Datasets**: Merge Sort has a time complexity of O(n log n) in all cases, making it faster than algorithms like Bubble Sort and Insertion Sort, which have O(n^2) in the average and worst cases.
- **Stability**: It maintains the relative order of equal elements.
- **Consistent Performance**: Merge Sort guarantees O(n log n) time complexity regardless of the input distribution.

### Limitations

- **Space Complexity**: Unlike in-place algorithms like Bubble Sort and Insertion Sort, Merge Sort requires additional space (O(n)) to hold temporary subarrays during the merge process.
- **Not In-Place**: Because Merge Sort requires extra storage, it is not considered an in-place algorithm.

### Time and Space Complexity Comparison with Other Algorithms

| Algorithm         | Best Case Time | Average Case Time | Worst Case Time | Space Complexity | Stable | In-Place |
|-------------------|----------------|-------------------|-----------------|------------------|--------|----------|
| **Bubble Sort**    | O(n)           | O(n^2)            | O(n^2)          | O(1)             | Yes    | Yes      |
| **Selection Sort** | O(n^2)         | O(n^2)            | O(n^2)          | O(1)             | No     | Yes      |
| **Insertion Sort** | O(n)           | O(n^2)            | O(n^2)          | O(1)             | Yes    | Yes      |
| **Merge Sort**     | O(n log n)     | O(n log n)        | O(n log n)      | O(n)             | Yes    | No       |

### Implementation in C#.NET 8

You can see the implementation of Merge Sort in C# in the `MergeSort.cs` class. The algorithm is implemented manually without using predefined functions like `Array.Copy`.


## Quick Sort

### Description

Quick Sort is a highly efficient, comparison-based sorting algorithm that uses a **divide-and-conquer** approach. It works by selecting a "pivot" element and partitioning the array into two halves: elements smaller than the pivot and elements greater than the pivot. The two subarrays are then sorted recursively. Quick Sort is popular because of its average-case time complexity of O(n log n) and its in-place nature, which does not require additional space like Merge Sort.

### Performance

- **Time Complexity**:
  - **Best Case**: O(n log n) (when the pivot divides the array into two nearly equal halves)
  - **Average Case**: O(n log n)
  - **Worst Case**: O(n^2) (when the pivot consistently results in highly unbalanced partitions, such as when the array is already sorted or reverse-sorted)
- **Space Complexity**: O(log n) (due to recursion stack in the average case)
- **Stability**: Quick Sort is not stable, meaning it does not necessarily preserve the relative order of equal elements.
- **In-Place**: Yes

### How It Works

1. **Pivot Selection**: Choose an element as the pivot (commonly the last element, but other strategies exist).
2. **Partitioning**: Rearrange the elements so that those smaller than the pivot are on the left side and those greater than the pivot are on the right side.
3. **Recursion**: Recursively apply the same process to the subarrays on either side of the pivot.
4. **Repeat**: Continue the process until the entire array is sorted.

### Steps and Example

Let's consider an example where we sort the following array: [12, 7, 14, 9, 10, 11].

1. Initial array: [12, 7, 14, 9, 10, 11]
   - Choose 11 as the pivot.
   - Partition the array: [7, 9, 10] (less than 11) and [12, 14] (greater than 11).
   - Resulting array after partition: [7, 9, 10, 11, 12, 14].

2. Recursively sort the left subarray [7, 9, 10]:
   - Choose 10 as the pivot.
   - Partition the array: [7, 9] (less than 10).
   - Resulting array: [7, 9, 10].

3. Recursively sort the right subarray [12, 14]:
   - Already sorted, no changes needed.

The array is now sorted: [7, 9, 10, 11, 12, 14].

### Advantages

- **Efficiency**: Quick Sort is one of the fastest sorting algorithms in practice, especially for large datasets, because of its average-case time complexity of O(n log n).
- **In-Place Sorting**: Quick Sort sorts the array without requiring additional storage (i.e., in-place sorting), unlike Merge Sort.
- **Adaptive**: Quick Sort performs well on large and small datasets.

### Limitations

- **Worst-Case Time Complexity**: In the worst case, when the pivot divides the array very unevenly (e.g., when the array is already sorted), the time complexity degrades to O(n^2). This can be mitigated by using better pivot selection strategies, such as **randomized Quick Sort** or **median-of-three** partitioning.
- **Not Stable**: Quick Sort is not a stable algorithm, meaning it does not preserve the relative order of elements with equal keys.
- **Recursion Overhead**: For very large datasets, the recursion depth can become a limiting factor, leading to potential stack overflow issues.

### Time and Space Complexity Comparison with Other Sorting Algorithms

| Algorithm         | Best Case Time | Average Case Time | Worst Case Time | Space Complexity | Stable | In-Place |
|-------------------|----------------|-------------------|-----------------|------------------|--------|----------|
| **Bubble Sort**    | O(n)           | O(n^2)            | O(n^2)          | O(1)             | Yes    | Yes      |
| **Selection Sort** | O(n^2)         | O(n^2)            | O(n^2)          | O(1)             | No     | Yes      |
| **Insertion Sort** | O(n)           | O(n^2)            | O(n^2)          | O(1)             | Yes    | Yes      |
| **Merge Sort**     | O(n log n)     | O(n log n)        | O(n log n)      | O(n)             | Yes    | No       |
| **Quick Sort**     | O(n log n)     | O(n log n)        | O(n^2)          | O(log n)         | No     | Yes      |

### Implementation in C#.NET 8

You can see the implementation of Quick Sort in C# in the `QuickSort.cs` class. The algorithm is implemented using the **Lomuto partition scheme**, which selects the last element as the pivot and rearranges the array into two halves.