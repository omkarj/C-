using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_11
{
    class ForegroundBackgroundThread
    {
        private static int i;
        public void CallThreads()
        {
            Thread t1 = new Thread(Function1);
            t1.IsBackground = true;               //Background thread
            t1.Start();
            Console.ReadKey();                    //Background thread exits as soon as key is pressed whereas foreground thread does not
        }

        static void Function1()
        {
            for (i = 0; i < 1000000; i++)
            {
                Console.WriteLine("Inside Function1");
            }
        }
    }

    
}
