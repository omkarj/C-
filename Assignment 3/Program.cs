using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using TestDemo.NestedNameSpace;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Demo1 cc = new Demo1();
            cc.print();
            Console.ReadLine();
            
            global::System.Console.ReadLine();
            GlobalVar.Global gg = new GlobalVar.Global();
            gg.WriteLine();*/

            Console.WriteLine("1st main method");
            Console.ReadLine();
        }
    }

     class CommandLineExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2nd main method");
            Console.ReadLine();
        }
    }
}


/*
namespace TestDemo
{
    namespace NestedNameSpace
    {
        public class Demo1
        {
            public void print()
            {
                Console.WriteLine("Printing");
            }
        }
    }
    
}

namespace GlobalVar
{
    public class Global
    {
        public void WriteLine()
        {
            Console.WriteLine("sdsdsa");
            Console.ReadLine();
        }
    }
}*/