using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9
{



    class Program
    {
        static void Main(string[] args)
        {
            //IDisposableDemo id = new IDisposableDemo();
            //id.FileIO();

            UsingDemo ud = new UsingDemo();
            ud.FileIO();
            Console.ReadKey();
        }
    }
}
