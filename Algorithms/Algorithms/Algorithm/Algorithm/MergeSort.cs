using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{

    /// <summary>
    /// This code contains the merge sort algorithm for string array
    /// </summary>
    class MergeSort
    {
        /// <summary>
        /// Purpose of this method is driver for merge sort
        /// </summary>
        public void mergeSortMain()
        {
            Console.WriteLine("Enter the list of words:");
            String str = Console.ReadLine();
            String[] array = str.Split(" ");

            String[] sortedArray = mergeSort(array);
            
            //Print the sorted array
            Console.WriteLine("The sorted arrays as follows:");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i] + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// This method is for mergeSort algorithm
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private static String[] mergeSort(String[] list)
        {
            String[] sorted = new String[list.Length];
            if (list.Length == 1)
            {
                sorted = list;
            }
            else
            {
                int mid = list.Length / 2;
                String[] left = null;
                String[] right = null;
                if ((list.Length % 2) == 0)
                {
                    left = new String[list.Length / 2];
                    right = new String[list.Length / 2];
                }
                else
                {
                    left = new String[list.Length / 2];
                    right = new String[(list.Length / 2) + 1];
                }
                int x = 0;
                int y = 0;
                for (; x < mid; x++)
                {
                    left[x] = list[x];
                }
                for (; x < list.Length; x++)
                {
                    right[y++] = list[x];
                }
                left = mergeSort(left);
                right = mergeSort(right);
                sorted = mergeArray(left, right);
            }

            return sorted;
        }

        /// <summary>
        /// This method is created for merging array
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        private static String[] mergeArray(String[] left, String[] right)
        {
            String[] merged = new String[left.Length + right.Length];
            int lIndex = 0;
            int rIndex = 0;
            int mIndex = 0;
            int comp = 0;
            while (lIndex < left.Length || rIndex < right.Length)
            {
                if (lIndex == left.Length)
                {
                    merged[mIndex++] = right[rIndex++];
                }
                else if (rIndex == right.Length)
                {
                    merged[mIndex++] = left[lIndex++];
                }
                else
                {
                    comp = left[lIndex].CompareTo(right[rIndex]);
                    if (comp > 0)
                    {
                        merged[mIndex++] = right[rIndex++];
                    }
                    else if (comp < 0)
                    {
                        merged[mIndex++] = left[lIndex++];
                    }
                    else
                    {
                        merged[mIndex++] = left[lIndex++];
                    }
                }
            }
            return merged;
        }
    
    }
}
