using System;

/* Description of QuickSort
 * 
 * QuickSort is comparison-based sorting algorithm that follows the divide-and-conquer strategy.
 * The Idea behind the QuickSort algorithm is to partition the array into two sub-arrays: 
 * one containing elements smaller than a chosen pivot element and another containing elements greater than the pivot.
 * The pivot element is chosen from the array, and its position is adjusted so that all elements smaller than the pivot are on its left, 
 * and all elements greater than the pivot are on its right.
 * 
 * 
 * Key Aspects of the sorting method:
 * Pivot:       
 *      Choose a pivot element from the array. 
 *      The choice of the pivot can vary, but common choices include the first, last, or middle element.
 * Partitioning:
 *      Rearrange the elements in the array so that all elements smaller than the pivot are on its left, 
 *      and all elements greater are on its right. The pivot element is now in its final sorted position.
 * Recursion:
 *      Recursively apply the QuickSort algorithm to the sub-arrays on the left and right sides of the pivot element.
 *      Repeat the partitioning and sorting steps for each sub-array.
 * Base Case:
 *      The recursion continues until the sub-arrays have only one or zero elements. 
 *      In these cases, the sub-arrays are already sorted.
 * Combine:
 *      As the recursion unwinds, the sorted sub-arrays are combined to form the fully sorted array.
 */

namespace H1___Quicksort_algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 10, 7, 9, 1, 15, 5, 12, 2, 11, 13, 6, 3, 0, 4, 8, 14 };
            char[] charArray = { 'b', 'j', 'd', 'e', 'i', 'h', 'c', 'a', 'g', 'k', 'f', 'l' };

            // Int array test
            Console.WriteLine("Integer Array:");
            Console.WriteLine("---------------");
            SortAndPrintArray(intArray);
            Console.ReadKey();

            // Char array test
            Console.WriteLine("\n\n\nCharacter Array:");
            Console.WriteLine("---------------");
            SortAndPrintArray(charArray);
            Console.ReadKey();
            
        }

        // Methods

        /// <summary>
        /// Sorts the array and prints the original and sorted arrays
        /// </summary>
        /// <param name="array">Requires the array you want to sort</param>
        static void SortAndPrintArray<T>(T[] array) where T : IComparable<T>
        {
            Console.WriteLine("Original Array:");
            PrintArray(array);

            QuickSort(array, 0, array.Length - 1);

            Console.WriteLine("\nSorted Array:");
            PrintArray(array);
        }

        /// <summary>
        /// Recursive function to perform quicksort
        /// </summary>
        /// <returns>i + 1</returns>
        /// <param name="array">Requires the array you want to sort</param>
        /// <param name="startingIndex">Requires the array's starting index, which is 0 you want to sort</param>
        /// <param name="endingIndex">Requires the ending index of the array which is the "array's length - 1" since we are using index.</param>
        static void QuickSort<T>(T[] array, int startingIndex, int endingIndex) where T : IComparable<T>
        {
            if (startingIndex < endingIndex)
            {
                int pi = Partition(array, startingIndex, endingIndex);
                QuickSort(array, startingIndex, pi - 1);
                QuickSort(array, pi + 1, endingIndex);
            }
        }

        /// <summary>
        /// Partitions the array and returns the pivot index
        /// </summary>
        /// <param name = "array" >Requires the array you want to sort</param>
        /// <param name="startingIndex">Requires the array's starting index, which is 0 you want to sort</param>
        /// <param name="endingIndex">Requires the ending index of the array which is the "array's length - 1" since we are using index.</param>
        /// <returns>The pivot index after partitioning.</returns>
        static int Partition<T>(T[] array, int startingIndex, int endingIndex) where T : IComparable<T>
        {
            if (typeof(T) == typeof(string))
            {
                string[] stringArray = array as string[];
                string pivot = stringArray[endingIndex];
                int i = (startingIndex - 1);

                for (int j = startingIndex; j <= endingIndex - 1; j++)
                {
                    if (CompareStrings(stringArray[j], pivot) < 0)
                    {
                        i++;
                        if (i != j)
                        {
                            Swap(stringArray, i, j);
                        }
                    }
                }

                if ((i + 1) != endingIndex)
                {
                    Swap(stringArray, i + 1, endingIndex);
                }

                return (i + 1);
            }
            else 
            {
                T pivot = array[endingIndex];
                int i = (startingIndex - 1);

                for (int j = startingIndex; j <= endingIndex - 1; j++)
                {
                    if (array[j].CompareTo(pivot) < 0)
                    {
                        i++;
                        if (i != j)
                        {
                            Swap(array, i, j);
                        }
                    }
                }

                if ((i + 1) != endingIndex)
                {
                    Swap(array, i + 1, endingIndex);
                }

                return (i + 1);
            }
            
        }

        /// <summary>
        /// Swaps two elements in the array
        /// </summary>
        /// <param name="array">
        /// Requires the array you want to sort
        /// </param>
        /// <param name="i">Index 1</param>
        /// <param name="j">Index 2</param>
        static void Swap<T>(T[] array, int i, int j)
        {
            (array[i], array[j]) = (array[j], array[i]);
        }

        /// <summary>
        /// Prints the elements of the array
        /// </summary>
        /// <param name="array">The array whose elements will be printed.</param>
        static void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Compares two strings and returns the result of the comparison.
        /// </summary>
        /// <param name="string1">The first string to compare.</param>
        /// <param name="string2">The second string to compare.</param>
        /// <returns>
        /// A negative value if str1 comes before str2 in alphabetical order.
        /// Zero if str1 and str2 are equal.
        /// A positive value if str1 comes after str2 in alphabetical order.
        /// </returns>
        static int CompareStrings(string string1, string string2)
        {
            return string.Compare(string1, string2);
        }
    }
}
