using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3Q1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            A year with 366 days is called a leap year.
            A is a leap year if it is divisible by four, 
                    except that it is not a leap year 
                if it is divisible by 100; however it is a leap year 
                if it is divisible by 400.There were no exceptions 
                before the introduction of the Gregorian year in 1582.
                Write a program that asks the user for a year and computes 
                whether that year is a leap year.
                */


      Console.Write("Please enter a year or -999 to quit > ");
            int year = Convert.ToInt32(Console.ReadLine());


            // the question didn't look for a loop but it made it easier to test.

            while (year != -999)
            {

                if (year % 400 == 0)
                {
                    Console.WriteLine("That is a leap year");
                }
                else if (year < 1582 && (year % 4 == 0))
                {
                    Console.WriteLine("That is a leap year");
                }
                else if (year % 4 == 0 && year % 100 != 0)
                {
                    Console.WriteLine("That is a leap year");
                }
                else
                {
                    Console.WriteLine("That is not a leap year");
                }

                Console.Write("Please enter a year or -999 to quit > ");
                year = Convert.ToInt32(Console.ReadLine());
            } // end of the while
        }
    }
}

