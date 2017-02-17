using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHello("Una");
        }

        static void PrintHello(string name)
        {
            Console.WriteLine("=============================");
            Console.WriteLine("Hello {0}", name);
            Console.WriteLine("=============================");
        }
    }
}
