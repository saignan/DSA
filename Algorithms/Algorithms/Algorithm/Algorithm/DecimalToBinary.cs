using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class DecimalToBinary
    {
        public void  decimalToBinary()
        {
            Console.Write("Please enter the decimal value: ");
            int dec = Convert.ToInt32(Console.ReadLine());


            String binary = toBinary(dec);

            Console.WriteLine(binary);
        }

        private static string toBinary(int dec)
        {
            string stnum = "";
            while (dec > 0)
            {
                stnum = stnum + dec % 2;
                dec /= 2;
            }

            string binary = "";
            for (int i = stnum.Length - 1; i >= 0; i--)
            {
                binary = binary + stnum[i];
            }

            return binary;
        }
    
    }
}
