using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How long is your radius ?> ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double circleArea = CalculateCircleArea(radius);
            Console.WriteLine("Your circle has an area of {0}",
                circleArea);

        }

        static double CalculateCircleArea(double radius)
        {
            double area = Math.Pow(radius,2) * Math.PI;
            return area;

        }
    }
}
