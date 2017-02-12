using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*An internet cafe charges a €2.00 minimum fee to use the internet 
            for up to three hours.  The cafe charges an additional €0.50 per hour 
            for each additional hour or part thereof.  
            The maximum charge for any given session is €10.00.  . 
            Write a program that calculates and displays the charges for each customer
            who uses the cafe.  Your program will accept the hours used by each customer.  
            The program will display the charge for each customer and a running total for 
            all usage. The program will have at least one method that calculates the charge
            for each customer.
    */

            // initalise variables

            decimal runningTotal = 0;
            decimal customerCharge = 0;

            Console.Write("Enter number of hours -999 to quit >");
            int numberOfHours = Convert.ToInt32(Console.ReadLine());

            while (numberOfHours != -999)
            {
                if (numberOfHours <= 3)
                {
                    customerCharge = 2;
                }
                else if (numberOfHours < 19)
                {
                    customerCharge = 2 + ((numberOfHours - 3) * .5m);
                }
                else
                {
                    customerCharge = 10;
                }

                runningTotal += customerCharge;

                Console.WriteLine("Customer Charge  {0,7:c}   Total Receipt {1,7:c}", customerCharge, runningTotal);
                Console.Write("Enter number of hours -999 to quit > ");
                numberOfHours = Convert.ToInt32(Console.ReadLine());

            }//end of the while loop
        } 
    }
}

