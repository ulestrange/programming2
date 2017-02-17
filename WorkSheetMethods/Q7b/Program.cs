using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7b
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter nugget number > ");
            int numberOfNuggest = Convert.ToInt32(Console.ReadLine());

            if (IsValidNuggetNumber(numberOfNuggest))
            {
                Console.WriteLine("Enjoy your nuggets");
            }
            else
            {
                Console.WriteLine("Invalid Order");
            }

        }

        /* 
        This takes one integer and return true if the number is 
        6, 9 or 20 otherwise it return false
        */

        static bool IsValidNuggetNumber (int num)
        {
            return (num == 6 || num == 9 || num == 20);
        }
    }
}
