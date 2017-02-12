using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3Q2
{
    class Program
    {
        /*Write a program to print the pattern. 
        Printing one ‘#’ at a time
        #
        # #
        # # #
        # # # # 
        # # # # #
        Do it now upside down
        */

        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            /* upside down */

            for (int i = 5; i > 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}

