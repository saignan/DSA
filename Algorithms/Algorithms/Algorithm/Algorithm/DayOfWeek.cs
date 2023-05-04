using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class DayOfWeek
    {
        /// <summary>
        ///Purpose of this method for finding the day of week 
        /// User will give date(including date month and year)
        /// </summary>
        public void dayOfWeek()
        {
            Console.Write("Please enter the date: ");
            int date = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the month: ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            int day = claculateDay(date, month, year);

            switch(day)
            {
                case 0:
                Console.WriteLine("Sunday");
                break;

                case 1:
                    Console.WriteLine("Monday");
                    break;
                
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                
                case 4:
                    Console.WriteLine("Thrusday");
                    break;
                
                case 5:
                    Console.WriteLine("Friday");
                    break;
                
                case 6:
                    Console.WriteLine("Saturday");
                    break;
            }
        
        }
        /// <summary>
        /// purpose of this method is calculate the day and return to the above method
        /// Using the formula to finding the day in any given date
        /// </summary>
        /// <param name="date"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        private static int claculateDay(int date, int month, int year)
        {
            int[] t=new int[] { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4};
            
            year -= (month < 3) ? 1 : 0;
            
            return (year + year / 4 - year / 100 + year / 400 + t[month - 1] + date) % 7;
        }
    }
}
