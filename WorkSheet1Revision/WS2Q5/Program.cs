using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS2Q5
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            5.	Write a program to determine much will be in your regular savings account
            after a number of years at a fixed monthly interest rate of  1%.  
            Inputs will be initial balance,  number of years saving
            and monthly saving amount. 
            (test with initial balance = 1000, years = 2; monthly saving = 100)

    */

            // Get the inputs
            Console.Write("What is your initial balance > ");
            decimal balance = Convert.ToDecimal(Console.ReadLine());
            Console.Write("How many years will you save for >");
            int numberOfYears = Convert.ToInt32(Console.ReadLine());
            Console.Write("what is your monthly saving amount >");
            decimal monthlySavingAmount = Convert.ToDecimal(Console.ReadLine());

            for (int i = 0; i < numberOfYears * 12; i++)
            {
                // note this assumes that they don't put the monthly amount
                // in until after the first month.

                decimal interest = balance * .01m;
                balance += interest + monthlySavingAmount;

                //
                Console.WriteLine("Balance after {0} months is {1:c}", i + 1, balance);
            }

            Console.WriteLine("You will have {0:c} at the end of the term", balance);



        }
    }
}
