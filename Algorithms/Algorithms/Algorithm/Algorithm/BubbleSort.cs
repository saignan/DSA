using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    /// <summary>
    /// This class contains the code of bubble sort
    /// </summary>
    class BubbleSort
    {
        /// <summary>
        /// Purpose of this method is bubble sort of integer array
        /// Read the list of array of integer
        /// Print the sorted array
        /// </summary>
        public void bubbleSort()
        {
            Console.Write("Please enter the  length of array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int temp;
            int[] array = new int[length];

            Console.WriteLine("Enter the element in array");
            
            //Inserting element in array
            for(int col=0;col<length;col++)
            {
                array[col] = Convert.ToInt32(Console.ReadLine());
            }

            //Sorting algorithm 
            for(int row=0;row<length-1;row++)
            {
                for(int col=0;col<length-1-row;col++)
                {
                    if(array[col]>array[col+1])
                    {
                        temp = array[col];
                        array[col] = array[col + 1];
                        array[col + 1] = temp;
                    }
                }
            }

            //Print sorted array
            Console.Write("Sorted element of given array are as follow: ");
            for(int col=0;col<length;col++)
            {
                Console.Write(array[col] + " ");
            }
            Console.WriteLine();
        
        }
    }
}
