using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    /// <summary>
    /// This class contains the code of inserton sort
    /// </summary>
    class InsertionSort
    {
        /// <summary>
        /// Purpose of this method is sorting the given array by insertion sort algorithm
        /// </summary>
        public void insertionSort()
        {
            Console.Write("Enter the length of array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            
            int[] arr = new int[length];

            Console.WriteLine("Enter the element in array");
            for(int col=0;col<length;col++)
            {
                arr[col] = Convert.ToInt32(Console.ReadLine());
            }

            sort(arr);
            printArray(arr);
        }

        /// <summary>
        /// Function to sort array 
        /// using insertion sort  
        /// </summary>
        /// <param name="arr"></param>

        private static void sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], 
                // that are greater than key, 
                // to one position ahead of 
                // their current position 
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        /// <summary>
        /// A utility function to print 
        /// array of size n 
        /// </summary>
        /// <param name="arr"></param>
        private static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.Write("\n");
        }

    }
}
