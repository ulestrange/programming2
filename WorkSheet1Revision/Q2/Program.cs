using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Question 2
            Write a for loop to print all integers
                between 1 and 20 excluding 6 and 8 in ascending order – 
                implement with the continue keyword.
                */


            for (int i=1; i<=20; i++)
            {
                if (i == 6 || i == 8)
                {
                    continue; // control skips the rest of the loop and goes back to for 
                }
                Console.WriteLine(i);
            }

            /*
            It is also possible to write it without the continue
            keyword
            */

            for (int i = 1; i <= 20; i++)
            {
                if (i != 6 && i != 8)
                {
                    Console.WriteLine(i);// write out the number if it is anything other than 6 or 8
                }
                
            }


        }
    }
}
