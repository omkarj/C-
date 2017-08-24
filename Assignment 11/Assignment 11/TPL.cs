using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11
{
    class TPL
    {
        private static int i;
        public void TPLDemo()
        {
            Parallel.For(0, 1000, x => Function1());
            Console.ReadKey();
        }

        public static void Function1()
        {
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Inside Function1 (Thread 1)");
            }
        }
    }
}
