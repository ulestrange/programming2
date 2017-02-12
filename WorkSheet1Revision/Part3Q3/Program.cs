using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3Q3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*An on line book retailer charges a flat 2.50 for each delivery,
            on top of which it applies the following the progressive fee rate 
            depending on delivery weight.
                The progressive fee rate is applicable to the book total weight.
                */

            decimal fee = 0;
            string loopAgain = "Y";


            do
            {

                Console.Write("Enter the weight of books (grams) :");
                int bookWeight = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Delivery (x/r/sx/ssx) :");
                string deliveryType = Console.ReadLine();


                if (bookWeight <= 2000)
                {
                    fee = bookWeight * .025m;
                }
                else if (bookWeight <= 5000)
                {
                    fee = (2000 * .025m) + ((bookWeight - 2000) * 0.03m);
                }
                else
                {
                   fee = (2000 * .025m) + (3000 * 0.03m) + ((bookWeight-5000) * 0.05m);
                }

                // Here we have calcualted the regular fee
                // Next to have to calculate how much to add on for delivery type.

                if (deliveryType == "x")
                {
                    fee += 1.5m;
                }
                else if (deliveryType == "sx")
                {
                    fee += 2.5m;
                }
                else if (deliveryType == "ssx")
                {
                    fee += 3.5m;
                }

                Console.WriteLine("You have to pay {0} for {1} grams.", fee, bookWeight);
                Console.Write("Calculate Another y/n ");
                loopAgain = Console.ReadLine().ToUpper();

                

            }while (loopAgain == "Y") ;
        }
    }
}
