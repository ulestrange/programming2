using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter number of nuggets >");
            int number = Convert.ToInt32(Console.ReadLine());

            if (! IsValidNuggetNumber(number))
            {
                Console.WriteLine(" Invalid Order");
            }

        }

        static bool IsValidNuggetNumber (int num)
        {
            bool isValid = false;
            
            if (num == 6  || num == 9 || num == 20)
            {
                isValid = true;
            }

            return isValid;

        }
    }
}
