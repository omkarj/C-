using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_11
{
    class MultipleThreads
    {
        private static int i;
        public void CreateAndCallThreads()
        {
            Thread t1 = new Thread(Function1);
            Thread t2 = new Thread(Function2);
            Thread t3 = new Thread(Function3);
            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadKey();
        }

        public static void Function1()
        {
            for (i = 0; i < 1000000; i++)
            {
                Console.WriteLine("Inside Function1 (Thread 1)");
            }
        }

        public static void Function2()
        {
            for (i = 0; i < 1000000; i++)
            {
                Console.WriteLine("Inside Function2 (Thread 2)");
            }
        }

        public static void Function3()
        {
            for (i = 0; i < 1000000; i++)
            {
                Console.WriteLine("Inside Function3 (Thread 3)");
            }
        }
    }
}
