using System;
using System.Collections.Generic;

namespace giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Getday(9));

            Console.ReadLine();
        }
        static string Getday(int dayNum)
        {
            string dayName = "Ravi";
            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednseday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid DayNum";
                    break;

            }
            return dayName;
        }

    }
}