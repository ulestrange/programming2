using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            4.Write a for loop to sum all the odd numbers between the integers n1 and n2,
                where n1 and n2 are entered by the user.Assume n1 <= n2.
                If the sum exceeds 500 print a message “sum too large” and exit the loop.
                */


            /*First get the numbers from the user
            there is no error checking before we convert to an int
            so an incorrect entry could lead to an run time error
            */

            Console.Write("Please enter first number > ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter second number > ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int sum = 0; // sum will hold the total of all numbers entered
            for (int i = n1; i <= n2; i++)
            {
                sum += i;
                if (sum > 500)
                {
                    Console.WriteLine("Sum too large");
                    break;
                }
            } //end of the for loop

            // Note the question doesn't ask us the write out the sum

                Console.WriteLine("Sum is {0}", sum);


        }
    }
}

