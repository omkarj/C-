using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Inside Main program");
            Thread t = new Thread(Function1);
            t.Start();
            Console.ReadKey();
            Console.WriteLine("Inside Main program");
        }

        static void Function1()
        {
            Console.WriteLine("\nInside Function1");
            string x = "ABC";
            Console.WriteLine(x);
        }
    }
}
