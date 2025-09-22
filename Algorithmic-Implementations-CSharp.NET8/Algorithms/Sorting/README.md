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


## Heap Sort

### Description

Heap Sort is a highly efficient, comparison-based sorting algorithm that utilizes a **binary heap** data structure. A heap is a special type of complete binary tree where the parent node is always greater (in a **max heap**) or smaller (in a **min heap**) than its children. Heap Sort works by first building a max heap from the input array, then repeatedly extracting the largest element (root of the heap) and placing it at the end of the array. This process is repeated until the entire array is sorted.

### Performance

- **Time Complexity**:
  - **Best Case**: O(n log n)
  - **Average Case**: O(n log n)
  - **Worst Case**: O(n log n)
- **Space Complexity**: O(1) (in-place sorting)
- **Stability**: Heap Sort is not stable, meaning it does not necessarily preserve the relative order of equal elements.
- **In-Place**: Yes

### How It Works

1. **Build Max Heap**: The array is first transformed into a **max heap** (a binary heap where the root is the largest element). This is done by calling the `Heapify` method starting from the middle of the array.
2. **Extract Elements**: The largest element (root of the heap) is swapped with the last element of the array, and the heap is reduced in size. The `Heapify` method is called again to restore the heap property.
3. **Repeat**: This process of extracting the root and restoring the heap is repeated until the entire array is sorted.

### Steps and Example

Let's consider an example where we sort the following array: [12, 11, 13, 5, 6, 7].

1. Initial array: [12, 11, 13, 5, 6, 7]
   - Build the max heap: [13, 11, 12, 5, 6, 7]

2. Extract the largest element (13), swap it with the last element (7), and heapify the reduced heap:
   - Array after first extraction: [7, 11, 12, 5, 6, 13]
   - Heapify: [12, 11, 7, 5, 6, 13]

3. Extract the next largest element (12), swap it with the second last element (6), and heapify:
   - Array after second extraction: [6, 11, 7, 5, 12, 13]
   - Heapify: [11, 6, 7, 5, 12, 13]

4. Continue the process until the array is sorted:
   - Sorted array: [5, 6, 7, 11, 12, 13]

### Advantages

- **Efficiency for Large Datasets**: Heap Sort has a time complexity of O(n log n) in all cases, making it efficient for large datasets.
- **In-Place Sorting**: Heap Sort sorts the array without requiring additional storage (i.e., in-place sorting), unlike Merge Sort.
- **No Worst-Case Degradation**: Unlike Quick Sort, Heap Sort does not degrade to O(n^2) in the worst case, which makes it more predictable.

### Limitations

- **Not Stable**: Heap Sort is not a stable sorting algorithm, meaning that equal elements may not retain their original relative order.
- **Performance Overhead**: While Heap Sort guarantees O(n log n) time complexity, it often performs slower in practice compared to Quick Sort due to the overhead of heap operations (swapping elements and maintaining the heap property).
- **Less Efficient for Small Arrays**: For smaller arrays, algorithms like Insertion Sort might be more efficient due to lower constant factors.

### Time and Space Complexity Comparison with Other Sorting Algorithms

| Algorithm         | Best Case Time | Average Case Time | Worst Case Time | Space Complexity | Stable | In-Place |
|-------------------|----------------|-------------------|-----------------|------------------|--------|----------|
| **Bubble Sort**    | O(n)           | O(n^2)            | O(n^2)          | O(1)             | Yes    | Yes      |
| **Selection Sort** | O(n^2)         | O(n^2)            | O(n^2)          | O(1)             | No     | Yes      |
| **Insertion Sort** | O(n)           | O(n^2)            | O(n^2)          | O(1)             | Yes    | Yes      |
| **Merge Sort**     | O(n log n)     | O(n log n)        | O(n log n)      | O(n)             | Yes    | No       |
| **Quick Sort**     | O(n log n)     | O(n log n)        | O(n^2)          | O(log n)         | No     | Yes      |
| **Heap Sort**      | O(n log n)     | O(n log n)        | O(n log n)      | O(1)             | No     | Yes      |

### Implementation in C#.NET 8

You can see the implementation of Heap Sort in C# in the `HeapSort.cs` class. The algorithm is implemented using a max heap, where the largest element is moved to the end of the array during each iteration.


## Cycle Sort

### Description

Cycle Sort is an in-place, comparison-based sorting algorithm that is particularly well-suited for situations where minimizing the number of write operations is critical. Unlike most sorting algorithms, which perform a large number of swaps or moves, Cycle Sort achieves optimal performance in terms of the number of writes to the array. It does this by arranging elements in cycles, where each cycle represents a set of elements that need to be placed in their correct positions. Cycle Sort then places each element directly in its correct position, performing only the necessary writes.

### Performance

- **Time Complexity**:
  - **Best Case**: O(n^2)
  - **Average Case**: O(n^2)
  - **Worst Case**: O(n^2)
- **Space Complexity**: O(1) (in-place sorting)
- **Stability**: Cycle Sort is not stable, meaning it does not necessarily preserve the relative order of equal elements.
- **In-Place**: Yes

### How It Works

1. **Identify Cycles**: Cycle Sort works by identifying cycles of elements that need to be rotated to their correct positions. Each cycle represents a subset of elements that need to be placed in their correct positions to achieve a sorted array.
2. **Position Calculation**: For each cycle, the algorithm finds the correct position of each element in the cycle.
3. **Rotation**: The element is placed in its correct position, and the remaining elements in the cycle are rotated until each one is in its proper place.
4. **Repeat**: This process continues for each element in the array until the entire array is sorted.

### Steps and Example

Let's consider an example where we sort the following array: [12, 11, 13, 5, 6].

1. Initial array: [12, 11, 13, 5, 6]
   - The first cycle starts with 12. It needs to move to position 3.
   - Swap 12 with 5: [5, 11, 13, 12, 6]
   - 5 now needs to move to position 0. 

2. Continue placing each element until all cycles are completed.
   - Final sorted array: [5, 6, 11, 12, 13]

### Advantages

- **Write Minimization**: Cycle Sort is optimal in terms of write operations, performing only the minimal number of writes necessary to sort the array. This property makes it well-suited for applications where write operations are costly or limited, such as sorting data in flash memory.
- **In-Place Sorting**: Like many efficient sorting algorithms, Cycle Sort sorts the array without requiring additional storage.

### Limitations

- **Time Complexity**: Despite its optimality in terms of write operations, Cycle Sort has a time complexity of O(n^2), making it inefficient for large datasets.
- **Not Stable**: Cycle Sort is not stable and does not preserve the relative order of duplicate elements.
- **Complexity of Implementation**: The algorithm can be challenging to understand and implement due to its cycle-based approach.

### Time and Space Complexity Comparison with Other Sorting Algorithms

| Algorithm         | Best Case Time | Average Case Time | Worst Case Time | Space Complexity | Stable | In-Place |
|-------------------|----------------|-------------------|-----------------|------------------|--------|----------|
| **Bubble Sort**    | O(n)           | O(n^2)            | O(n^2)          | O(1)             | Yes    | Yes      |
| **Selection Sort** | O(n^2)         | O(n^2)            | O(n^2)          | O(1)             | No     | Yes      |
| **Insertion Sort** | O(n)           | O(n^2)            | O(n^2)          | O(1)             | Yes    | Yes      |
| **Merge Sort**     | O(n log n)     | O(n log n)        | O(n log n)      | O(n)             | Yes    | No       |
| **Quick Sort**     | O(n log n)     | O(n log n)        | O(n^2)          | O(log n)         | No     | Yes      |
| **Heap Sort**      | O(n log n)     | O(n log n)        | O(n log n)      | O(1)             | No     | Yes      |
| **Cycle Sort**     | O(n^2)         | O(n^2)            | O(n^2)          | O(1)             | No     | Yes      |

### Implementation in C#.NET 8

You can see the implementation of Cycle Sort in C# in the `CycleSort.cs` class. The algorithm is implemented by arranging elements into cycles and directly placing them in their correct positions.


## Counting Sort

### Description

Counting Sort is an integer sorting algorithm that works by counting the occurrences of each unique element in the input data. These counts are then used to determine the position of each element in the sorted output. Counting Sort is particularly efficient when the range of input values (`k`) is small compared to the number of elements (`n`).

Counting Sort is **stable**, meaning it preserves the relative order of equal elements. However, it is not an in-place algorithm because it requires additional memory for the count and output arrays.

### Performance

- **Time Complexity**:
  - **Best Case**: O(n + k)
  - **Average Case**: O(n + k)
  - **Worst Case**: O(n + k)
- **Space Complexity**: O(n + k)
- **Stability**: Yes
- **In-Place**: No

### How It Works

1. **Determine Range**:
   - Calculate the minimum and maximum values in the input array to determine the range of input data (`k = max - min + 1`).

2. **Count Occurrences**:
   - Use a count array to store the frequency of each value, adjusted for the minimum value.

3. **Cumulative Counts**:
   - Transform the count array into a cumulative count array, where each position stores the total count of elements up to that index.

4. **Build the Output Array**:
   - Traverse the input array in reverse, placing each element at its correct position in the output array using the cumulative count array. Decrement the count after placing each element to handle duplicates correctly.

5. **Return Result**:
   - Return the sorted output array.

### Steps and Example

Let's consider an example where we sort the following array: [4, 2, 2, 8, 3, 3, 1].

1. **Determine Range**:
   - Minimum = 1, Maximum = 8, Range = 8 - 1 + 1 = 8.

2. **Count Occurrences**:
   - Count array: [1, 2, 2, 1, 0, 0, 0, 1] (adjusted for the range).

3. **Cumulative Counts**:
   - Cumulative count array: [1, 3, 5, 6, 6, 6, 6, 7].

4. **Build the Output Array**:
   - Place elements in the correct position: [1, 2, 2, 3, 3, 4, 8].

5. **Sorted Array**:
   - Final output: [1, 2, 2, 3, 3, 4, 8].

### Advantages

- **Efficiency**: Counting Sort is highly efficient for sorting integers with a small range of values.
- **Stable Sorting**: The algorithm preserves the relative order of elements with equal keys, making it suitable for sorting data with secondary keys.
- **No Comparisons**: Unlike comparison-based algorithms (e.g., Quick Sort, Merge Sort), Counting Sort determines the sorted order using counting and indexing.

### Limitations

- **Limited to Integers**: Counting Sort is designed for discrete data, primarily integers or elements that can be mapped to integers.
- **Space Overhead**: Counting Sort requires additional memory proportional to the range of input values (`k`), which can be inefficient for large ranges.
- **Not In-Place**: The algorithm requires auxiliary memory for the count and output arrays, increasing space complexity.

### Time and Space Complexity Comparison with Other Sorting Algorithms

| Algorithm         | Best Case Time | Average Case Time | Worst Case Time | Space Complexity | Stable | In-Place |
|-------------------|----------------|-------------------|-----------------|------------------|--------|----------|
| **Bubble Sort**    | O(n)           | O(n^2)            | O(n^2)          | O(1)             | Yes    | Yes      |
| **Selection Sort** | O(n^2)         | O(n^2)            | O(n^2)          | O(1)             | No     | Yes      |
| **Insertion Sort** | O(n)           | O(n^2)            | O(n^2)          | O(1)             | Yes    | Yes      |
| **Merge Sort**     | O(n log n)     | O(n log n)        | O(n log n)      | O(n)             | Yes    | No       |
| **Quick Sort**     | O(n log n)     | O(n log n)        | O(n^2)          | O(log n)         | No     | Yes      |
| **Heap Sort**      | O(n log n)     | O(n log n)        | O(n log n)      | O(1)             | No     | Yes      |
| **Counting Sort**  | O(n + k)       | O(n + k)          | O(n + k)        | O(n + k)         | Yes    | No       |

### Implementation in C#.NET 8

You can see the implementation of Counting Sort in C# in the `CountingSort.cs` class. The algorithm counts occurrences of each element, builds a cumulative count array, and uses it to determine the correct position of each element in the sorted output.

## Radix Sort

### Description

Radix Sort is a **stable**, non-comparison-based sorting algorithm that sorts elements by processing individual digits from the least significant digit (LSD) to the most significant digit (MSD). It relies on a subroutine, typically **Counting Sort**, to sort the elements based on the current digit being processed. Radix Sort is particularly efficient for sorting integers or strings that can be represented in positional notation.

### Performance

- **Time Complexity**:
  - **Best Case**: O(n + k) * d
  - **Average Case**: O(n + k) * d
  - **Worst Case**: O(n + k) * d
    - Here:
      - `n` = Number of elements in the input array.
      - `k` = Range of digits (typically 10 for decimal system).
      - `d` = Number of digits in the largest number in the array.
- **Space Complexity**: O(n + k) (for the auxiliary arrays used during Counting Sort)
- **Stability**: Yes
- **In-Place**: No

### How It Works

1. **Determine the Maximum Value**:
   - Find the largest number in the array to determine the number of digits (`d`).

2. **Sort by Each Digit**:
   - Starting with the least significant digit (LSD), sort all elements based on the value of that digit using a stable sort, typically **Counting Sort**.
   - Repeat the process for each subsequent digit up to the most significant digit (MSD).

3. **Combine Results**:
   - After processing all digits, the array will be fully sorted.

### Steps and Example

Let's consider an example where we sort the following array: [170, 45, 75, 90, 802, 24, 2, 66].

1. **Step 1**: Sort by the Least Significant Digit (LSD):
   - Original Array: [170, 45, 75, 90, 802, 24, 2, 66]
   - Sorted by LSD: [802, 2, 24, 45, 66, 170, 75, 90]

2. **Step 2**: Sort by the Tens Digit:
   - Intermediate Array: [802, 2, 24, 45, 66, 170, 75, 90]
   - Sorted by Tens: [802, 2, 24, 45, 66, 75, 90, 170]

3. **Step 3**: Sort by the Most Significant Digit (MSD):
   - Intermediate Array: [802, 2, 24, 45, 66, 75, 90, 170]
   - Final Sorted Array: [2, 24, 45, 66, 75, 90, 170, 802]

### Advantages

- **Efficiency for Large Data**: Radix Sort is highly efficient for sorting integers with a large range when the number of digits (`d`) is small compared to the number of elements (`n`).
- **Stable Sorting**: The algorithm preserves the relative order of equal elements.
- **No Comparisons**: Unlike traditional comparison-based algorithms (e.g., Quick Sort, Merge Sort), Radix Sort processes elements based on their digits.

### Limitations

- **Not In-Place**: Radix Sort requires additional memory for auxiliary arrays.
- **Limited to Positional Data**: It is best suited for data that can be represented in positional notation (e.g., integers or strings).
- **Dependent on Digits**: The efficiency depends on the number of digits (`d`), which can make it less efficient for data with a large number of digits.

### Time and Space Complexity Comparison with Other Sorting Algorithms

| Algorithm         | Best Case Time   | Average Case Time | Worst Case Time | Space Complexity | Stable | In-Place |
|-------------------|------------------|-------------------|-----------------|------------------|--------|----------|
| **Bubble Sort**    | O(n)            | O(n^2)            | O(n^2)          | O(1)             | Yes    | Yes      |
| **Selection Sort** | O(n^2)          | O(n^2)            | O(n^2)          | O(1)             | No     | Yes      |
| **Insertion Sort** | O(n)            | O(n^2)            | O(n^2)          | O(1)             | Yes    | Yes      |
| **Merge Sort**     | O(n log n)      | O(n log n)        | O(n log n)      | O(n)             | Yes    | No       |
| **Quick Sort**     | O(n log n)      | O(n log n)        | O(n^2)          | O(log n)         | No     | Yes      |
| **Heap Sort**      | O(n log n)      | O(n log n)        | O(n log n)      | O(1)             | No     | Yes      |
| **Counting Sort**  | O(n + k)        | O(n + k)          | O(n + k)        | O(n + k)         | Yes    | No       |
| **Radix Sort**     | O(nk) (n + k)d  | O(nk)             | O(nk)           | O(n + k)         | Yes    | No       |

### Implementation in C#.NET 8

You can see the implementation of Radix Sort in C# in the `RadixSort.cs` class. The algorithm processes elements digit by digit, using **Counting Sort** as a stable subroutine.


## Bucket Sort

### Description

Bucket Sort is a **comparison-based** sorting algorithm that distributes elements into multiple buckets. Each bucket is then sorted individually using a different sorting algorithm, typically Insertion Sort. It is particularly efficient when the input data is uniformly distributed over a range.

### Performance

- **Time Complexity**:
  - **Best Case**: O(n + k)
  - **Average Case**: O(n + k)
  - **Worst Case**: O(n^2) (if all elements land in the same bucket)
    - Here:
      - `n` = Number of elements in the input array.
      - `k` = Number of buckets.
- **Space Complexity**: O(n + k)
- **Stability**: No (depends on the sub-sorting algorithm used)
- **In-Place**: No

### How It Works

1. **Determine Bucket Range**:
   - Calculate the range of input values and distribute them into buckets based on this range.

2. **Distribute Elements**:
   - Each element from the input array is assigned to a bucket based on a hashing function.

3. **Sort Buckets**:
   - Sort individual buckets using a simpler sorting algorithm, such as Insertion Sort.

4. **Concatenate Results**:
   - Combine all sorted buckets into the final sorted array.


### Steps and Example

Let's consider an example where we sort the following array: [0.897, 0.565, 0.656, 0.1234, 0.665, 0.3434].

1. **Step 1**: Distribute Elements into Buckets:
   - Buckets:
     - Bucket 0: [0.1234]
     - Bucket 1: [0.3434]
     - Bucket 5: [0.565]
     - Bucket 6: [0.656, 0.665]
     - Bucket 8: [0.897]

2. **Step 2**: Sort Individual Buckets:
   - Sorted Buckets:
     - Bucket 0: [0.1234]
     - Bucket 1: [0.3434]
     - Bucket 5: [0.565]
     - Bucket 6: [0.656, 0.665]
     - Bucket 8: [0.897]

3. **Step 3**: Concatenate Buckets:
   - Final Sorted Array: [0.1234, 0.3434, 0.565, 0.656, 0.665, 0.897]

### Advantages

- **Efficient for Uniform Data**: Works well for data that is uniformly distributed over a range.
- **Parallelizable**: Sorting buckets can be parallelized.

### Limitations

- **Depends on Data Distribution**: Performance heavily depends on the distribution of input data.
- **Requires Extra Space**: Additional memory is needed for buckets.
- **Choice of Bucket Count**: Improper choice of the number of buckets can lead to inefficiency.

### Time and Space Complexity Comparison with Other Sorting Algorithms

| Algorithm         | Best Case Time   | Average Case Time | Worst Case Time | Space Complexity | Stable | In-Place |
|-------------------|------------------|-------------------|-----------------|------------------|--------|----------|
| **Bubble Sort**    | O(n)            | O(n^2)            | O(n^2)          | O(1)             | Yes    | Yes      |
| **Selection Sort** | O(n^2)          | O(n^2)            | O(n^2)          | O(1)             | No     | Yes      |
| **Insertion Sort** | O(n)            | O(n^2)            | O(n^2)          | O(1)             | Yes    | Yes      |
| **Merge Sort**     | O(n log n)      | O(n log n)        | O(n log n)      | O(n)             | Yes    | No       |
| **Quick Sort**     | O(n log n)      | O(n log n)        | O(n^2)          | O(log n)         | No     | Yes      |
| **Heap Sort**      | O(n log n)      | O(n log n)        | O(n log n)      | O(1)             | No     | Yes      |
| **Counting Sort**  | O(n + k)        | O(n + k)          | O(n + k)        | O(n + k)         | Yes    | No       |
| **Radix Sort**     | O(nk) (n + k)d  | O(nk)             | O(nk)           | O(n + k)         | Yes    | No       |
| **Bucket Sort**    | O(n + k)        | O(n + k)          | O(n^2)          | O(n + k)         | No     | No       |

### Implementation in C#.NET 8

You can see the implementation of Bucket Sort in C# in the `BucketSort.cs` class. The algorithm efficiently handles fractional values distributed across buckets, sorted individually.

## Shell Sort

### Description

Shell Sort is an **in-place**, **comparison-based** sorting algorithm that generalizes Insertion Sort to allow exchanges of items that are far apart. The idea is to arrange the data sequence in a way that elements far apart can be moved closer quickly. It reduces the number of shifts required in later stages of Insertion Sort by initially sorting elements that are far apart.

It was invented by **Donald Shell** in 1959 and is an improvement over Insertion Sort.

### Performance

- **Time Complexity** *(depends on gap sequence)*:
  - **Best Case**: O(n log n)
  - **Average Case**: O(n^3/2) or better
  - **Worst Case**: O(n²)
- **Space Complexity**: O(1)
- **Stability**: No
- **In-Place**: Yes

### How It Works

1. **Gap Selection**:
   - Start with a large gap, typically `n / 2`, and reduce it by half each iteration.

2. **Gapped Insertion Sort**:
   - Perform insertion sort for elements separated by the current gap.

3. **Repeat**:
   - Continue the process, reducing the gap until it reaches 1.

4. **Final Pass**:
   - With a gap of 1, a final insertion sort ensures the array is fully sorted.

### Steps and Example

Let's say we want to sort this array:  
`[12, 34, 54, 2, 3]`

1. **Initial gap = 2**:
   - Compare and sort elements 2 positions apart.
   - Intermediate result: `[12, 3, 54, 2, 34]`

2. **Next gap = 1**:
   - Perform standard insertion sort.
   - Final sorted array: `[2, 3, 12, 34, 54]`

### Advantages

- **More Efficient than Insertion Sort**: Especially for medium-sized arrays.
- **In-Place**: Doesn’t require extra memory.
- **Simple to Implement**: Compared to more complex algorithms like Merge or Quick Sort.

### Limitations

- **Not Stable**: Equal elements may not retain their original order.
- **Performance Depends on Gap Sequence**: Optimal gap sequences can be complex (e.g., Hibbard, Sedgewick).

### Time and Space Complexity Comparison with Other Sorting Algorithms

| Algorithm         | Best Case Time | Average Case Time | Worst Case Time | Space Complexity | Stable | In-Place |
|------------------|----------------|-------------------|-----------------|------------------|--------|----------|
| **Bubble Sort**   | O(n)           | O(n²)             | O(n²)           | O(1)             | Yes    | Yes      |
| **Selection Sort**| O(n²)          | O(n²)             | O(n²)           | O(1)             | No     | Yes      |
| **Insertion Sort**| O(n)           | O(n²)             | O(n²)           | O(1)             | Yes    | Yes      |
| **Shell Sort**    | O(n log n)     | O(n^1.5)          | O(n²)           | O(1)             | No     | Yes      |
| **Merge Sort**    | O(n log n)     | O(n log n)        | O(n log n)      | O(n)             | Yes    | No       |
| **Quick Sort**    | O(n log n)     | O(n log n)        | O(n²)           | O(log n)         | No     | Yes      |
| **Heap Sort**     | O(n log n)     | O(n log n)        | O(n log n)      | O(1)             | No     | Yes      |

### Implementation in C#.NET 8

You can find the Shell Sort algorithm implemented in the `ShellSort.cs` class inside the `SortingLibrary` namespace. It follows a classic implementation with gap reduction by half.

## Tim Sort

### Description

Tim Sort is a hybrid, stable, comparison-based sorting algorithm that combines the best properties of **Insertion Sort** and **Merge Sort**. It was designed to perform well on many kinds of real-world data and is the default sorting algorithm in Python and Java.

It divides the array into small **runs** (typically size 32), sorts them using Insertion Sort, and then merges them using Merge Sort.

### Performance

- **Time Complexity**:
  - **Best Case**: O(n)
  - **Average Case**: O(n log n)
  - **Worst Case**: O(n log n)
- **Space Complexity**: O(n)
- **Stability**: Yes
- **In-Place**: No (requires auxiliary arrays during merge)

### How It Works

1. **Divide into Runs**:
   - The array is divided into small fixed-size chunks (called runs).
   - Each run is sorted using Insertion Sort (fast on small data).

2. **Merge Runs**:
   - The sorted runs are merged using Merge Sort logic until the full array is sorted.

### Steps and Example

Given an array: `[23, 12, 1, 8, 34, 54, 2, 3]`

1. **Runs of size 32 or smaller** are sorted with Insertion Sort:
   - Runs: `[23, 12, 1, 8, 34, 54, 2, 3]`
   - After Insertion Sort: `[1, 2, 3, 8, 12, 23, 34, 54]`

2. **Merge step** (if multiple runs exist) is applied:
   - Final sorted array: `[1, 2, 3, 8, 12, 23, 34, 54]`

### Advantages

- **Efficient on Real-World Data**: Especially for partially sorted arrays.
- **Stable**: Maintains the relative order of equal elements.
- **Adaptive**: Performs well across a wide range of inputs.

### Limitations

- **Not In-Place**: Requires extra space for merging.
- **Slightly Complex**: More involved implementation than other basic sorts.

### Time and Space Complexity Comparison with Other Sorting Algorithms

| Algorithm         | Best Case Time | Average Case Time | Worst Case Time | Space Complexity | Stable | In-Place |
|------------------|----------------|-------------------|-----------------|------------------|--------|----------|
| **Bubble Sort**   | O(n)           | O(n²)             | O(n²)           | O(1)             | Yes    | Yes      |
| **Selection Sort**| O(n²)          | O(n²)             | O(n²)           | O(1)             | No     | Yes      |
| **Insertion Sort**| O(n)           | O(n²)             | O(n²)           | O(1)             | Yes    | Yes      |
| **Merge Sort**    | O(n log n)     | O(n log n)        | O(n log n)      | O(n)             | Yes    | No       |
| **Quick Sort**    | O(n log n)     | O(n log n)        | O(n²)           | O(log n)         | No     | Yes      |
| **Tim Sort**      | O(n)           | O(n log n)        | O(n log n)      | O(n)             | Yes    | No       |

### Implementation in C#.NET 8

The `TimSort.cs` class implements this hybrid algorithm using a run size of 32. It uses Insertion Sort for small chunks and Merge Sort for merging, offering fast and stable performance across various datasets.

## Bitonic Sort

### Description

Bitonic Sort is a **parallel**, comparison-based sorting algorithm that works best on input sizes that are powers of two. It recursively builds bitonic sequences (sequences that first increase and then decrease), then merges them in sorted order. Due to its predictable structure and parallelism, it is often used in **parallel computing**, such as GPU or FPGA environments.

Bitonic Sort was introduced by **Ken Batcher** and is primarily useful in systems that benefit from parallel execution.

### Performance

- **Time Complexity**:
  - **Best Case**: O(log² n)
  - **Average Case**: O(log² n)
  - **Worst Case**: O(log² n)
- **Space Complexity**: O(1) (in-place)
- **Stability**: No
- **In-Place**: Yes
- **Parallelizable**: Yes (highly)

### How It Works

1. **Split the Array**:
   - The array is divided recursively into two halves.
   - The first half is sorted in ascending order and the second in descending order.

2. **Create Bitonic Sequences**:
   - These two halves now form a bitonic sequence (first increases, then decreases).

3. **Merge the Bitonic Sequence**:
   - A bitonic merge is applied to produce a sorted sequence in the desired order.

4. **Recursive Merging**:
   - This process is repeated recursively until the whole array is sorted.

### Steps and Example

Given an array:  
`[3, 7, 4, 8, 6, 2, 1, 5]` (length = 8, power of 2)

1. Split and recursively sort:
   - Ascending half: `[3, 7, 4, 8]`
   - Descending half: `[6, 2, 1, 5]`

2. Create bitonic sequence:
   - `[3, 7, 4, 8, 6, 2, 1, 5]` (bitonic)

3. Merge:
   - Final sorted: `[1, 2, 3, 4, 5, 6, 7, 8]`

### Advantages

- **Highly Parallelizable**: Can be efficiently implemented on parallel hardware.
- **Deterministic Structure**: Predictable control flow is useful in hardware implementations.
- **In-Place**: No extra memory is needed.

### Limitations

- **Only works optimally for sizes that are powers of two**.
- **Not practical for general CPU use**: Compared to Quick Sort or Merge Sort, it's slower and more complex on standard machines.
- **Not Stable**: Equal elements may not preserve their relative order.

### Time and Space Complexity Comparison with Other Sorting Algorithms

| Algorithm         | Best Case Time | Average Case Time | Worst Case Time | Space Complexity | Stable | In-Place |
|------------------|----------------|-------------------|-----------------|------------------|--------|----------|
| **Bubble Sort**   | O(n)           | O(n²)             | O(n²)           | O(1)             | Yes    | Yes      |
| **Merge Sort**    | O(n log n)     | O(n log n)        | O(n log n)      | O(n)             | Yes    | No       |
| **Quick Sort**    | O(n log n)     | O(n log n)        | O(n²)           | O(log n)         | No     | Yes      |
| **Tim Sort**      | O(n)           | O(n log n)        | O(n log n)      | O(n)             | Yes    | No       |
| **Bitonic Sort**  | O(log² n)      | O(log² n)         | O(log² n)       | O(1)             | No     | Yes      |

### Implementation in C#.NET 8

You can find the Bitonic Sort implementation in the `BitonicSort.cs` class. The algorithm is implemented recursively and performs in-place sorting, assuming the array length is a power of two.


## Odd-Even (Brick) Sort

### Description

Odd-Even Sort—also called **Brick Sort**—is a simple, comparison-based, in-place sorting algorithm closely related to Bubble Sort.  
Instead of repeatedly scanning the whole list, it alternates two partial “bubble” passes:

1. **Odd phase:** compare / swap pairs (1, 2), (3, 4), …  
2. **Even phase:** compare / swap pairs (0, 1), (2, 3), …

These two phases are repeated until a full cycle completes with **no swaps**, indicating the list is sorted.  
Because the odd and even phases are independent, the algorithm is easy to parallelise on SIMD or GPU hardware.

### Performance

| Metric | Value |
|--------|-------|
| **Best Case** | O(n)  &nbsp;*(already sorted)* |
| **Average Case** | O(n²) |
| **Worst Case** | O(n²) |
| **Space Complexity** | O(1) (in-place) |
| **Stable** | Yes |
| **Parallelisable** | Yes (odd & even passes) |

### How It Works

1. **Initial Pass**  
   - Array: `[34, 2, 25, 12, 22, 11]`
2. **Odd Phase** (index 1↔2, 3↔4, …)  
   - Swap `2 ↔ 25` ⇒ `[34, 2, 25, 12, 22, 11]` → `[34, 2, 25, 12, 22, 11]`
3. **Even Phase** (index 0↔1, 2↔3, …)  
   - Swap `34 ↔ 2`, swap `25 ↔ 12` ⇒ `[2, 34, 12, 25, 22, 11]`
4. **Repeat** odd / even passes until no swaps occur.

### Advantages

- **In-place & simple**—only adjacent swaps.
- **Naturally parallel**—odd and even comparisons are independent.
- **Stable**—equal elements keep their relative order.

### Limitations

- **O(n²)** average/worst-case cost—slower than Quick Sort, Merge Sort, etc.
- Mostly used for teaching or for highly parallel hardware where simplicity outweighs big-O cost.

### Complexity Comparison

| Algorithm        | Best | Avg | Worst | Space | Stable |
|------------------|------|-----|-------|-------|--------|
| Bubble Sort      | O(n) | O(n²) | O(n²) | O(1) | ✔ |
| **Odd-Even Sort**| O(n) | O(n²) | O(n²) | O(1) | ✔ |
| Insertion Sort   | O(n) | O(n²) | O(n²) | O(1) | ✔ |
| Merge Sort       | O(n log n) | O(n log n) | O(n log n) | O(n) | ✔ |
| Quick Sort       | O(n log n) | O(n log n) | O(n²) | O(log n) | ✘ |

### Implementation in C#.NET 8

The full implementation is available in **`OddEvenSort.cs`** inside the `SortingLibrary` namespace.  
The algorithm alternates odd and even passes until the `sorted` flag remains `true` for an entire cycle.


## Intro Sort (Introspective Sort)

### Description

**Intro Sort** is a hybrid, comparison-based sorting algorithm that combines **Quick Sort** for speed, **Heap Sort** as a worst-case fallback, and **Insertion Sort** for small partitions. It starts with Quick Sort; if recursion gets too deep (risking Quick Sort’s worst case), it switches to Heap Sort, guaranteeing **O(n log n)** worst-case time.

This implementation uses:
- **Median-of-three** pivot selection (improves partition quality)
- **Depth limit** = `2 * ⌊log₂ n⌋`
- **Insertion Sort** for partitions smaller than a threshold (e.g., 16)

### Performance

- **Time Complexity**:
  - **Best**: O(n log n)
  - **Average**: O(n log n)
  - **Worst**: O(n log n) *(due to Heap Sort fallback)*
- **Space Complexity**: O(log n) *(recursion stack)*
- **Stability**: No
- **In-Place**: Yes *(aside from recursion stack)*

### How It Works

1. **Start with Quick Sort**
   - Pick a pivot via **median-of-three** of `(left, mid, right)`.
   - Partition the array around the pivot.

2. **Monitor Recursion Depth**
   - Maintain a **depth limit** of `2 * ⌊log₂ n⌋`.
   - If the limit is reached, **switch to Heap Sort** on that subarray.

3. **Use Insertion Sort for Small Ranges**
   - When a subarray size ≤ threshold (e.g., 16), finish it with **Insertion Sort**.

4. **Tail Recursion Optimization**
   - Recurse on the **smaller** partition first; loop over the larger to reduce stack depth.

### Steps and Example

Given: `[23, 12, 1, 8, 34, 54, 2, 3]`

1. Quick Sort with median-of-three pivot; partition into smaller subarrays.
2. For tiny partitions (≤ 16), switch to **Insertion Sort**.
3. If recursion depth exceeds limit, **Heap Sort** the current range.
4. Final: `[1, 2, 3, 8, 12, 23, 34, 54]`

### Advantages

- **Guaranteed O(n log n) worst case** via Heap Sort fallback.
- **Fast in practice** (Quick Sort behavior on average).
- **Cache-friendly** due to small-range Insertion Sort.
- **In-place**, low extra memory usage.

### Limitations

- **Not stable** (relative order of equal elements may change).
- More complex than single-strategy sorts (e.g., pure Quick/Merge/Heap).

### Time and Space Complexity Comparison

| Algorithm        | Best        | Average     | Worst       | Space     | Stable | In-Place |
|------------------|-------------|-------------|-------------|-----------|--------|---------|
| Insertion Sort   | O(n)        | O(n²)       | O(n²)       | O(1)      | Yes    | Yes     |
| Merge Sort       | O(n log n)  | O(n log n)  | O(n log n)  | O(n)      | Yes    | No      |
| Quick Sort       | O(n log n)  | O(n log n)  | O(n²)       | O(log n)  | No     | Yes     |
| Heap Sort        | O(n log n)  | O(n log n)  | O(n log n)  | O(1)      | No     | Yes     |
| **Intro Sort**   | O(n log n)  | O(n log n)  | O(n log n)  | O(log n)  | No     | Yes     |

### Implementation in C#.NET 8

See **`IntroSort.cs`** in the `SortingLibrary` namespace.  
It uses median-of-three partitioning, a depth limit (`2 * ⌊log₂ n⌋`), Heap Sort fallback, and an Insertion Sort threshold of 16.

## Gapped Insertion Sort (Shell Pass)

### Description

**Gapped Insertion Sort** is the core operation behind **Shell Sort**.  
It performs an insertion-sort–like pass where elements are compared and shifted in steps of a given **gap** (e.g., compare `a[i]` with `a[i-gap]`, `a[i-2*gap]`, …).  
A **single pass** with gap `g` produces a **g-sorted** array (each of the `g` interleaved subsequences is individually sorted).  
To fully sort an array, multiple passes are applied with decreasing gaps (typical Shell sequences), ending with `gap = 1`.

> Use cases:
> - As a **utility** inside Shell Sort.
> - As a targeted **local smoothing** step for nearly g-sorted data.

### Performance

- **Per Pass (fixed gap g)**:
  - **Best Case**: O(n) *(already g-sorted)*
  - **Average Case**: O(n·k) — behaves like insertion sort on `k ≈ n/g` items per subsequence (rule-of-thumb)
  - **Worst Case**: O(n²)
- **Space Complexity**: O(1) *(in-place)*
- **Stability**: **Not guaranteed** globally (stable only within each gap-subsequence)
- **In-Place**: Yes

> Overall Shell Sort complexity depends on the **gap sequence**, not just this pass.

### How It Works

1. Choose a **gap** `g ≥ 1`.
2. For each index `i = g..n-1`:
   - Save `a[i]` to `temp`.
   - Shift elements `a[i-g], a[i-2g], …` right while they are `> temp`.
   - Insert `temp` into its position.
3. Repeat for smaller gaps (e.g., `n/2, n/4, …, 1`) to complete Shell Sort.

### Example (Single Pass, gap = 3)

Array: `[23, 12, 1, 8, 34, 54, 2, 3]`  
Subsequences by gap=3:
- Indices `0,3,6`: `[23, 8, 2]` → insertion-sorted → `[2, 8, 23]`
- Indices `1,4,7`: `[12, 34, 3]` → `[3, 12, 34]`
- Indices `2,5`:   `[1, 54]`     → `[1, 54]`

After the pass (recombined): `[*2*, *3*, 1, *8*, *12*, 54, *23*, *34*]`  
Array is **3-sorted**, not fully sorted yet—next passes with smaller gaps finish the job.

### Advantages

- **In-place** and simple.
- Great building block for **Shell Sort** (cache-friendly on small sublists).
- Useful for **partially g-sorted** data.

### Limitations

- A single pass doesn’t fully sort unless `gap = 1`.
- **Stability** is not guaranteed across different gap subsequences.
- Worst-case **O(n²)** per pass.

### Comparison (At a Glance)

| Algorithm                | Fully Sorts? | Stable | In-Place | Typical Use                         |
|--------------------------|--------------|--------|----------|--------------------------------------|
| Insertion Sort (gap=1)   | Yes          | ✔      | ✔        | Small/narrow ranges, nearly-sorted   |
| **Gapped Insertion (g>1)** | No (1 pass)  | ✖      | ✔        | Shell Sort building block            |
| Shell Sort (sequence)    | Yes          | ✖      | ✔        | Faster-than-insertion on medium n    |

### Implementation in C#.NET 8

See **`GappedInsertionSort.cs`** (`SortingLibrary`):
- `Sort(int[] array, int gap)` — single full-array gapped pass.
- `SortRange(int[] array, int left, int right, int gap)` — bounded pass for a subrange.


## Pancake Sort

### Description

**Pancake Sort** is a comparison-based, in-place sorting algorithm that uses only one operation: a **flip** (reversing a prefix of the array).  
At each step, it locates the maximum element in the current unsorted prefix, flips it to the front (if needed), then flips it into its correct position at the end of that prefix. Repeat while shrinking the prefix.

While more of a teaching/novel algorithm than a practical one on CPUs, it’s a neat demonstration of sorting with a restricted operation set.

### Performance

- **Time Complexity**:
  - **Best Case**: O(n²)
  - **Average Case**: O(n²)
  - **Worst Case**: O(n²)
- **Space Complexity**: O(1) (in-place)
- **Stability**: No
- **In-Place**: Yes

> Even when the array is already sorted, the algorithm still scans for the maximum on each pass, leading to quadratic work overall.

### How It Works

1. Let `currSize` be the size of the current unsorted prefix (start from `n`, decrement to 2).
2. Find the index of the **maximum** element in `array[0..currSize-1]`.
3. If that max is not already at `currSize - 1`:
   - **Flip** `array[0..maxIndex]` to bring it to the front.
   - **Flip** `array[0..currSize-1]` to move it to its correct position at the end.
4. Reduce `currSize` by 1 and repeat.

### Steps and Example

Given: `[3, 6, 1, 10, 2]`

- `currSize = 5`, max in `[3, 6, 1, 10, 2]` is `10` at index `3`
  - Flip `0..3` → `[10, 1, 6, 3, 2]`
  - Flip `0..4` → `[2, 3, 6, 1, 10]`
- `currSize = 4`, max in `[2, 3, 6, 1]` is `6` at index `2`
  - Flip `0..2` → `[6, 3, 2, 1, 10]`
  - Flip `0..3` → `[1, 2, 3, 6, 10]`
- `currSize = 3`, max in `[1, 2, 3]` is `3` at index `2` → already in place
- `currSize = 2`, max in `[1, 2]` is `2` at index `1` → already in place  
Final: `[1, 2, 3, 6, 10]`

### Advantages

- **In-place**, uses only simple prefix reversals.
- Fun/educational example of sorting with a constrained operation.
- Conceptually aligns with problems involving “flipping” operations.

### Limitations

- **Quadratic time** in all cases → not competitive with `O(n log n)` sorts.
- **Unstable** due to large segment reversals.

### Time and Space Complexity Comparison with Other Sorting Algorithms

| Algorithm         | Best Case Time | Average Case Time | Worst Case Time | Space | Stable | In-Place |
|------------------|----------------|-------------------|-----------------|-------|--------|---------|
| Insertion Sort   | O(n)           | O(n²)             | O(n²)           | O(1)  | Yes    | Yes     |
| Merge Sort       | O(n log n)     | O(n log n)        | O(n log n)      | O(n)  | Yes    | No      |
| Quick Sort       | O(n log n)     | O(n log n)        | O(n²)           | O(log n) | No  | Yes     |
| Heap Sort        | O(n log n)     | O(n log n)        | O(n log n)      | O(1)  | No     | Yes     |
| **Pancake Sort** | **O(n²)**      | **O(n²)**         | **O(n²)**       | O(1)  | No     | Yes     |

### Implementation in C#.NET 8

The `PancakeSort.cs` class in the `SortingLibrary` namespace implements:
- `Sort(int[] array)` — main entry point
- Internal helpers:
  - `Flip(int[] array, int i)` — reverses prefix `0..i`
  - `FindMaxIndex(int[] array, int n)` — finds max index in `[0..n-1]`

Use `RunPancakeSortDemo()` in your `Program.cs` to see it in action with random data.


## Bogo Sort

### Description

**Bogo Sort** (a.k.a. *Permutation Sort*, *Stupid Sort*) is a deliberately naive, randomized sorting algorithm that repeatedly
**shuffles** the array until it happens to be sorted. It’s a fun teaching example for randomness and algorithmic
complexity—not something you’d ever use in production.

This repository’s implementation adds a **safety guard** (`maxShuffles`) to prevent unbounded runtimes.

### Performance

- **Time Complexity**:
  - **Best**: O(n) — already sorted on the first check
  - **Expected**: Θ(n · n!) — ~n work per attempt × ~n! shuffles expected
  - **Worst**: Unbounded (no guarantee it ever finishes). With a shuffle cap: O(cap · n)
- **Space Complexity**: O(1) — in-place (Fisher–Yates shuffle)
- **Stability**: No
- **In-Place**: Yes

> Even tiny arrays can take a comically long time. Keep inputs **very small** (n ≤ 6) if you must run it.

### How It Works

1. **Check Sorted?** If the array is in non-decreasing order, stop.
2. **Shuffle** the entire array uniformly at random (Fisher–Yates).
3. Repeat steps 1–2 until sorted (or until the shuffle limit is reached).

### Steps and Example

Given: `[3, 1, 2]`

1. Check → not sorted  
2. Shuffle → `[2, 3, 1]` → not sorted  
3. Shuffle → `[1, 2, 3]` → sorted ✅

The number of shuffles is unpredictable; that’s the point (and the problem).

### Advantages

- **Trivially simple** to implement and reason about.
- Illustrates **randomized algorithms** and **uniform shuffling** (Fisher–Yates).
- Good for demos on **why complexity matters**.

### Limitations

- **Astronomically slow** in expectation: Θ(n · n!).
- **Non-deterministic** runtime; can run “forever” without a guard.
- Provides no practical advantage over real sorting algorithms.

### Time and Space Complexity Comparison

| Algorithm         | Best        | Average       | Worst         | Space | Stable | In-Place |
|------------------|-------------|---------------|---------------|-------|--------|---------|
| Insertion Sort   | O(n)        | O(n²)         | O(n²)         | O(1)  | Yes    | Yes     |
| Merge Sort       | O(n log n)  | O(n log n)    | O(n log n)    | O(n)  | Yes    | No      |
| Quick Sort       | O(n log n)  | O(n log n)    | O(n²)         | O(log n) | No  | Yes     |
| Heap Sort        | O(n log n)  | O(n log n)    | O(n log n)    | O(1)  | No     | Yes     |
| **Bogo Sort**    | **O(n)**    | **Θ(n · n!)** | **Unbounded** | O(1)  | No     | Yes     |

### Implementation in C#.NET 8

See **`BogoSort.cs`** in the `SortingLibrary` namespace.  
Key points:
- `Sort(int[] array, int maxShuffles = int.MaxValue)`  
  - Repeatedly checks `IsSorted` and runs **Fisher–Yates** `Shuffle` until sorted.
  - Throws `InvalidOperationException` if `maxShuffles` is exceeded.

> For demos, use **very small arrays** and set a **reasonable `maxShuffles`** cap to avoid runaway tests.



## Gnome Sort

### Description

**Gnome Sort** is a simple, in-place, comparison-based sorting algorithm that works like a “walking” version of Insertion Sort using **adjacent swaps**.  
The “gnome” moves forward when neighboring elements are in order; if it finds a pair out of order, it swaps them and **steps back** one position to continue fixing locally—much like how insertion sort shifts elements but via swaps.

### Performance

- **Time Complexity**:
  - **Best Case**: O(n) *(already/nearly sorted)*
  - **Average Case**: O(n²)
  - **Worst Case**: O(n²)
- **Space Complexity**: O(1) *(in-place)*
- **Stability**: Yes *(only adjacent swaps of out-of-order pairs)*
- **In-Place**: Yes

### How It Works

1. Start at index `i = 1`.
2. If `a[i] >= a[i-1]`, move forward: `i++`.
3. Otherwise, swap `a[i]` and `a[i-1]` and, if possible, step back: `i--`.  
   If `i` reaches `0`, move forward to `1`.
4. Continue until `i` reaches the end.

### Steps and Example

Given: `[34, 2, 25, 12]`

- `i=1`: `34 > 2` → swap → `[2, 34, 25, 12]`; step back impossible → `i=1`
- `i=1`: `2 ≤ 34` → `i=2`
- `i=2`: `34 > 25` → swap → `[2, 25, 34, 12]`; step back → `i=1`
- `i=1`: `2 ≤ 25` → `i=2`
- `i=2`: `25 ≤ 34` → `i=3`
- `i=3`: `34 > 12` → swap → `[2, 25, 12, 34]`; step back → `i=2`
- `i=2`: `25 > 12` → swap → `[2, 12, 25, 34]`; step back → `i=1`
- `i=1`: `2 ≤ 12` → `i=2`, then `i=3`, then `i=4` (done)

Final: `[2, 12, 25, 34]`

### Advantages

- **Very simple** to implement and reason about.
- **Stable** and **in-place**.
- Performs well on **nearly sorted** data.

### Limitations

- **Quadratic** on average and in the worst case.
- Generally slower than Insertion Sort due to more swaps.

### Time and Space Complexity Comparison

| Algorithm       | Best        | Average     | Worst       | Space | Stable | In-Place |
|----------------|-------------|-------------|-------------|-------|--------|---------|
| Insertion Sort | O(n)        | O(n²)       | O(n²)       | O(1)  | Yes    | Yes     |
| Bubble Sort    | O(n)        | O(n²)       | O(n²)       | O(1)  | Yes    | Yes     |
| **Gnome Sort** | O(n)        | O(n²)       | O(n²)       | O(1)  | Yes    | Yes     |
| Merge Sort     | O(n log n)  | O(n log n)  | O(n log n)  | O(n)  | Yes    | No      |
| Quick Sort     | O(n log n)  | O(n log n)  | O(n²)       | O(log n) | No | Yes     |

### Implementation in C#.NET 8

See **`GnomeSort.cs`** in the `SortingLibrary` namespace.  
The algorithm iteratively walks forward/backward performing adjacent swaps until the entire array is ordered.


## Cocktail Sort (Shaker Sort)

### Description

**Cocktail Sort**—also known as **Shaker Sort**—is a bidirectional variant of Bubble Sort.  
Each iteration performs two passes:

1. **Forward pass**: bubbles the largest element to the right end.  
2. **Backward pass**: bubbles the smallest element to the left end.

By moving elements in both directions, Cocktail Sort can finish sooner than Bubble Sort on some inputs, especially when small elements start near the right end or large ones near the left.

### Performance

- **Time Complexity**:
  - **Best**: O(n) *(already/nearly sorted; no swaps on a full cycle)*
  - **Average**: O(n²)
  - **Worst**: O(n²)
- **Space Complexity**: O(1) *(in-place)*
- **Stability**: Yes *(only adjacent swaps when strictly out of order)*
- **In-Place**: Yes

### How It Works

1. Set `start = 0`, `end = n - 1`, and `swapped = true`.
2. **Forward pass** from `start` to `end - 1`, swapping adjacent out-of-order pairs.
3. If no swaps occurred, the array is sorted → stop.
4. Decrement `end` (right boundary shrinks), reset `swapped = false`.
5. **Backward pass** from `end` down to `start + 1`, swapping out-of-order pairs.
6. Increment `start` (left boundary shrinks).
7. Repeat while any swaps occur in a full forward+backward cycle.

### Steps and Example

Array: `[5, 1, 4, 2, 8]`

- **Forward**: bubble up → `[1, 4, 2, 5, 8]`
- **Backward**: bubble down → `[1, 2, 4, 5, 8]`  
Next cycle makes no swaps → done.

### Advantages

- **Simple** and **in-place**.
- Can outperform Bubble Sort on data where small/large elements are misplaced on opposite ends.
- **Stable** due to adjacent swaps.

### Limitations

- Still **O(n²)** on average and worst case.
- Slower than `O(n log n)` algorithms (Quick/Merge/Heap) for large arrays.

### Time and Space Complexity Comparison

| Algorithm        | Best        | Average     | Worst       | Space | Stable | In-Place |
|------------------|-------------|-------------|-------------|-------|--------|---------|
| Bubble Sort      | O(n)        | O(n²)       | O(n²)       | O(1)  | Yes    | Yes     |
| **Cocktail Sort**| O(n)        | O(n²)       | O(n²)       | O(1)  | Yes    | Yes     |
| Insertion Sort   | O(n)        | O(n²)       | O(n²)       | O(1)  | Yes    | Yes     |
| Merge Sort       | O(n log n)  | O(n log n)  | O(n log n)  | O(n)  | Yes    | No      |
| Quick Sort       | O(n log n)  | O(n log n)  | O(n²)       | O(log n) | No | Yes     |
| Heap Sort        | O(n log n)  | O(n log n)  | O(n log n)  | O(1)  | No     | Yes     |

### Implementation in C#.NET 8

See **`CocktailSort.cs`** in the `SortingLibrary` namespace.  
The implementation keeps shrinking the unsorted window (`start..end`) after each forward and backward pass and stops when a complete cycle performs **no swaps**.


## Strand Sort

### Description

**Strand Sort** is a comparison-based, **stable** sorting algorithm that repeatedly extracts an
increasing subsequence (called a **strand**) from the input and **merges** it into a running
result. It behaves similarly to a *natural merge sort*: the more structure (pre-existing
increasing runs) your data has, the better it performs.

### Performance

- **Time Complexity** *(data dependent)*:
  - **Best**: O(n) — already (or largely) increasing; one strand + single merge
  - **Average**: O(n log n) — typical when multiple moderate-length strands form naturally
  - **Worst**: O(n²) — highly adversarial (e.g., strictly decreasing)
- **Space Complexity**: O(n) — extra lists for input/result/strands
- **Stability**: **Yes** — merge keeps equal elements in original order
- **In-Place**: No

### How It Works

1. **Extract a strand**:
   - Start with the first element from the remaining input.
   - Scan input left-to-right, greedily append any element ≥ last in the strand.
   - Remove appended elements from the input; the strand is strictly non-decreasing.

2. **Merge** the new strand into the **result** list (which is always sorted).

3. **Repeat** steps 1–2 until the input becomes empty.

4. Copy the result back to the original array.

### Steps and Example

Given: `[34, 2, 25, 12, 22, 11]`

1. **Extract strand #1** from input:
   - Start with `34`, then no larger element appears immediately → strand₁ = `[34]`
   - Result = `[]` → merge ⇒ Result = `[34]`
   - Remaining input: `[2, 25, 12, 22, 11]`

2. **Extract strand #2**:
   - Start `2` → can append `25` → cannot append `12` (12 < 25) → append `?` skip `12` → append `?` `22` < 25 → skip → append `?` `11` < 25 → skip
   - strand₂ = `[2, 25]`
   - Merge `Result = [34]` with `[2, 25]` ⇒ `[2, 25, 34]`
   - Remaining input: `[12, 22, 11]`

3. **Extract strand #3**:
   - Start `12` → append `22` → skip `11` → strand₃ = `[12, 22]`
   - Merge `[2, 25, 34]` with `[12, 22]` ⇒ `[2, 12, 22, 25, 34]`
   - Remaining input: `[11]`

4. **Extract strand #4**: `[11]` → merge ⇒ `[2, 11, 12, 22, 25, 34]` ✅

### Advantages

- **Stable** and conceptually simple.
- Performs well on **partially sorted** data (leverages natural runs).
- Merge step is straightforward and can be optimized.

### Limitations

- Not in-place; requires **O(n)** extra memory.
- Worst case can degrade to **O(n²)** (e.g., strictly decreasing inputs).
- Less common than mainstream `O(n log n)` sorts (Merge/Quick/Heap) and usually slower in practice.

### Time and Space Complexity Comparison

| Algorithm        | Best        | Average     | Worst       | Space | Stable | In-Place |
|------------------|-------------|-------------|-------------|-------|--------|---------|
| Insertion Sort   | O(n)        | O(n²)       | O(n²)       | O(1)  | Yes    | Yes     |
| Merge Sort       | O(n log n)  | O(n log n)  | O(n log n)  | O(n)  | Yes    | No      |
| Quick Sort       | O(n log n)  | O(n log n)  | O(n²)       | O(log n) | No | Yes     |
| Heap Sort        | O(n log n)  | O(n log n)  | O(n log n)  | O(1)  | No     | Yes     |
| **Strand Sort**  | O(n)        | O(n log n)  | O(n²)       | O(n)  | Yes    | No      |

### Implementation in C#.NET 8

See **`StrandSort.cs`** in the `SortingLibrary` namespace.  
This implementation:
- Extracts strands greedily from a mutable input `List<int>`.
- Uses a **stable** merge (`<=` when picking from the left list).
- Copies the final merged result back into the source array.



## Spaghetti Sort (Software Simulation)

### Description

**Spaghetti Sort** is a whimsical, physical sorting idea: place “spaghetti sticks” of different lengths together and repeatedly pull the tallest (or shortest).  
In software, this is typically **simulated** by counting how many times each value occurs and then reconstructing the array from the smallest to the largest value — effectively behaving like a **Counting Sort** variant.

This implementation supports **negative and positive integers** by normalizing values to a non-negative range.

### Performance

- **Time Complexity**:  
  - **Best / Average / Worst**: **O(n + k)**  
    - `n` = number of elements  
    - `k` = range size = `max(array) - min(array) + 1`
- **Space Complexity**: **O(k)** (frequency array)
- **Stability**: **No** (this simple frequency-writeback variant does not preserve relative order)
- **In-Place**: **No** (auxiliary frequency array required)

> If `k` is small compared to `n`, this is fast. If `k` is very large, memory and time usage can be impractical.

### How It Works

1. **Scan for min/max** to compute the **range** `k`.
2. **Allocate a frequency array** `freq[0..k-1]`.
3. **Count** each value: `freq[value - min]++`.
4. **Reconstruct** the original array from the frequency array in ascending order.

### Example

Input: `[34, -2, 25, 12, 22, 11, 90, 3, -18, 45]`  
- `min = -18`, `max = 90`, `k = 109`  
- Count each value into `freq`  
- Write back values from `min` to `max` according to their counts →  
Output: `[-18, -2, 3, 11, 12, 22, 25, 34, 45, 90]`

### Advantages

- **Linear time** in `n + k` for integer keys.
- Handles **negative numbers** via normalization.
- **Simple** and deterministic.

### Limitations

- Requires **O(k)** auxiliary memory → poor when the value range is large.
- **Not stable** in this basic form (does not preserve order of equal keys).
- Only applicable to **integer-like** keys (or data that can be discretized to a small range).

### Time and Space Complexity Comparison

| Algorithm         | Best        | Average     | Worst       | Space | Stable | In-Place |
|------------------|-------------|-------------|-------------|-------|--------|---------|
| Insertion Sort   | O(n)        | O(n²)       | O(n²)       | O(1)  | Yes    | Yes     |
| Merge Sort       | O(n log n)  | O(n log n)  | O(n log n)  | O(n)  | Yes    | No      |
| Quick Sort       | O(n log n)  | O(n log n)  | O(n²)       | O(log n) | No | Yes     |
| Heap Sort        | O(n log n)  | O(n log n)  | O(n log n)  | O(1)  | No     | Yes     |
| **Spaghetti Sort (sim.)** | **O(n + k)** | **O(n + k)** | **O(n + k)** | **O(k)** | No | No |

### Implementation in C#.NET 8

See **`SpaghettiSort.cs`** in the `SortingLibrary` namespace.  
Key points:
- Finds `min` and `max`, builds `freq` of size `max - min + 1`.
- Rewrites the original array from `freq`.
- Works with negative values via offset (`value - min`).

> If you need **stability**, switch to a full counting-sort approach with **cumulative counts** and a temporary output array (extra O(n) space).


## Sleep Sort (Asynchronous Novelty)

### Description

**Sleep Sort** is a tongue-in-cheek, timing-based “algorithm” that emits numbers after sleeping for a time proportional to their value. Smaller values wake earlier and are output first. It is **not** practical for real use and is presented for education and fun (randomness, scheduling, and why time-based algorithms are a bad idea).

This implementation is **deterministic** despite scheduler jitter: each distinct value is assigned an emission order, tasks sleep proportionally, then wait for their turn to write to output. It also includes a **delay budget guard** to prevent long sleeps and supports **negative values** by delaying relative to the minimum.

### Performance

- **Time Complexity**:
  - **Best**: O(n) + O(R·d) sleep time  *(R = value range; d = unit delay)*
  - **Average/Worst**: O(n) work + **time dominated by sleeps** (can be very large)
- **Space Complexity**: O(n) *(task bookkeeping + output buffer)*
- **Stability**: Yes for equal values within this implementation (deterministic emission per key)
- **In-Place**: No

> Runtime depends on the **value range** and chosen **unit delay**; keep ranges small.

### How It Works

1. Compute `min` and `max` to determine the **range** and check against a **max total delay** guard.
2. Count occurrences of each distinct value.
3. For each distinct value `v`, start a task that:
   - Sleeps for `(v - min) * unitDelayMs`.
   - Waits until all smaller values have emitted (deterministic “turn”).
   - Writes its `count(v)` copies into the output.
4. Wait for all tasks; copy output back to the input array.

### Example

Input: `[5, 1, 3, 0, 4, 2]`, `unitDelayMs = 1`, `min = 0`

- Task(0) sleeps 0ms → emits `0`
- Task(1) sleeps 1ms → emits `1`
- …
- Task(5) sleeps 5ms → emits `5`

Final: `[0, 1, 2, 3, 4, 5]`

### Advantages

- Cute demonstration for **concurrency**, **timers**, and **determinism** under scheduler jitter.
- Very simple to reason about for **small ranges**.

### Limitations

- **Not practical**: runtime tied to numeric range and delays.
- Requires threads/tasks and timers; **not deterministic** without additional ordering control.
- Not in-place; allocates an output array and starts multiple tasks.

### Time and Space Complexity Comparison

| Algorithm        | Best        | Average       | Worst         | Space | Stable | In-Place |
|------------------|-------------|---------------|---------------|-------|--------|---------|
| Insertion Sort   | O(n)        | O(n²)         | O(n²)         | O(1)  | Yes    | Yes     |
| Merge Sort       | O(n log n)  | O(n log n)    | O(n log n)    | O(n)  | Yes    | No      |
| Quick Sort       | O(n log n)  | O(n log n)    | O(n²)         | O(log n) | No | Yes  |
| Heap Sort        | O(n log n)  | O(n log n)    | O(n log n)    | O(1)  | No     | Yes     |
| **Sleep Sort**   | O(n)+sleep  | O(n)+sleep    | O(n)+sleep    | O(n)  | Yes*   | No      |

\*Stable in this implementation due to deterministic emission; classic Sleep Sort is not inherently stable.

### Implementation in C#.NET 8

See **`SleepSort.cs`** in the `SortingLibrary` namespace.

- `Sort(int[] array, int unitDelayMs = 1, int maxTotalDelayMs = 30_000)`  
  - Supports negatives by delaying relative to `min`.
  - Guards against long sleeps via `maxTotalDelayMs`.
  - Ensures correct ascending output even with scheduler jitter.

> **Tip:** Keep values within a **small range** (e.g., 0–20) and use a tiny `unitDelayMs` for demos.
