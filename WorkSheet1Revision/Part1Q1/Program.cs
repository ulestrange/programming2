using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Question
            1.	Write a for loop to print all integers between 1 and 20 in ascending order.
            Now write it with a while loop.
            */



            /* Note this for statement will print out 1 to 20
            inclusive. The question could also be read as printing out 
            1 to 20 exclusive */

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
            }

            /* You can do the same thing with a while statment. 
            */

            int j = 1;
            while (j <= 20)
            {
                Console.WriteLine(j);
                j++;
            }

            /* The while statement could also 
            be written this way */

            int k = 0;
            while (k < 20)
            {
                k++;
                Console.WriteLine(k);
            }
            
             
        }
    }
}

