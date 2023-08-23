using System;

class program 
{ 
    static void Main(string[] args)
    {
        int[] intArray = { 10, 7, 9, 1, 15, 5, 12, 2, 11, 13, 6, 3, 0, 4, 8, 14 };
        char[] charArray = { 'b', 'j', 'd', 'e', 'i', 'h', 'c', 'a', 'g', 'k', 'f', 'l'};

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





        // Methods

        /// <summary>
        /// Sorts the array and prints the original and sorted arrays
        /// </summary>
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
        static int Partition<T>(T[] array, int startingIndex, int endingIndex) where T : IComparable<T>
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

        /// <summary>
        /// Swaps two elements in the array
        /// </summary>
        static void Swap<T>(T[] array, int i, int j)
        {
            (array[i], array[j]) = (array[j], array[i]);
        }


        /// <summary>
        /// Prints the elements of the array
        /// </summary>
        static void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}