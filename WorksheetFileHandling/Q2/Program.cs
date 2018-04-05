using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Q2
{
    class Program
    {

        /*
        A series of daily temperatures is stored in the CSV file “temp.txt”, 
        e.g.  
         23/11/2013,8
         24/11/2013,6

        This program 
        Reads the data from the file and writes a report on the Console.
        */



        static void Main(string[] args)
        {

            FileStream fs = new FileStream("../../temp.txt", FileMode.Open, FileAccess.Read);
            StreamReader inputStream = new StreamReader(fs);

            string formatString = "{0,-15} {1,-20}";

            // to keep a running total and the total number for calculating average

            double total = 0;
            int numberOfDataPoints = 0;

            string[] fields = new string[2]; // to store the indivdual bits of data.

            // write the heading
            Console.WriteLine("Temperature Report ");
            Console.WriteLine(formatString, "Date", "Temperature");


            string lineIn;

            lineIn = inputStream.ReadLine();


            while (lineIn != null)
            {

                fields = lineIn.Split(',');
                Console.WriteLine(formatString, fields[0], fields[1]);

                total += Double.Parse(fields[1]);
                numberOfDataPoints++;
                lineIn = inputStream.ReadLine();

            }


            Console.WriteLine("\n Average is {0}", total / numberOfDataPoints);


        }
    }
}
