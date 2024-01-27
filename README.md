Given a sorted array in which all elements appear twice (one after one) and one element
appears only once. It’s required to find this element (i.e. element that appears once)
Design an efficient algorithm that you can use for solving this problem.

Input: Already Implemented
The first line of input is an integer T (T < 30), that indicates the number of test cases. Each
case consists of array items
Output: Already Implemented
A single integer that represents the element that appears once in the given array.

Function: Implement it!
 public static int FindUniqueElement(int[] arr, int N)

It takes one sorted array (which all elements appear twice except one), it shall return the
unique element in arr.
ElementOnceAppearence.cs includes this method.

Examples
#  
1.
  Input Array 1, 1, 3, 3, 4, 5, 5, 7, 7, 8, 8
  Output 4
2.
  Input Array 1, 1, 3, 3, 4, 4, 5, 5, 7, 7, 8
  Output 8
4.
  Input Array 1, 1, 2, 4, 4, 5, 5, 6, 6
  Output 2
6.
  Input Array 4, 10, 10, 11, 11
  Output 4
