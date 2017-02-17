using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Una";
            int age1 = 21;
            PrintHello(name1, age1);
            PrintHello("Pat", 12);
            PrintHello("Pat", 62);
            PrintHello("Jane", 52);
        }

        static void PrintHello(string name, int age)
        {
            Console.WriteLine("=============================");
            Console.WriteLine("Hello {0} your age is {1}", name, age);
            Console.WriteLine("=============================");
        }
    }
}
