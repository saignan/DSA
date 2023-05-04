using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    /// <summary>
    ///  program to implement Binary Search for strings 
    /// </summary>
    class BinarySearch
    {
        /// <summary>
        /// The purpose of this method is binary search 
        /// </summary>
        public void binarySearch()
        {
            Console.WriteLine("Please Enter the list of word file ");
            String str = Console.ReadLine();
            String[] arr = str.Split(" ");
            Array.Sort(arr);//sorting the above array for binary search

            Console.WriteLine("Please enter a string to be searched.");
            String x = Console.ReadLine();
            int result = binarySearch(arr, x);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at " + "index " + result);
        }

        /// <summary>
        /// Returns index of x if it is present in arr[],  
        /// else return -1  
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        static int binarySearch(String[] arr, String x)
        {
            int l = 0, r = arr.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                int res = x.CompareTo(arr[m]);

                // Check if x is present at mid  
                if (res == 0)
                    return m;

                // If x greater, ignore left half  
                if (res > 0)
                    l = m + 1;

                // If x is smaller, ignore right half  
                else
                    r = m - 1;
            }

            return -1;
        }
    }
}
