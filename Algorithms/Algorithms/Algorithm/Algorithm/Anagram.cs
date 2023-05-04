using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    /// <summary>
    /// This class conatins the code for checking to strings are anagram or not
    /// </summary>
    class Anagram
    {
        /// <summary>
        /// Purpose of this method is for taking two string as inputs
        /// Checking two are anagram or not
        /// Print the output as anagram or not anagram 
        /// </summary>
        public void anagram()
        {
            Console.Write("Enter the first string: ");
            String str1 = Console.ReadLine();

            Console.Write("Enter the second string: ");
            String str2 = Console.ReadLine();

            str1 = str1.Replace(" ","");
            str2 = str2.Replace(" ","");

            str1 = str1.ToLower();
            str2 = str2.ToLower();

            char[] array1 = str1.ToCharArray();
            char[] array2 = str2.ToCharArray();

            Array.Sort(array1);
            Array.Sort(array2);

            string s1 = new string(array1);
            string s2 = new string(array2);

            if (s1 == s2)
                Console.WriteLine("Anagram");
            else
                Console.WriteLine("not Anagram");

        }
    }
}
