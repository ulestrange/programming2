using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            result = CalculateArea(3, 2);
            Console.WriteLine("Area is {0}", result);

        }

        static int CalculateArea(int width, int height)
        {
            int area;
            area = width * height;
            return area;
        } 

    }
}
