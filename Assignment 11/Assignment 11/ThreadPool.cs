using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_11
{
    class TPool
    {
        private static int i;
        public void ThreadPoolDemo()
        {
            object a = "AAAAA";
            ThreadPool.QueueUserWorkItem(new WaitCallback(Function1), a);
            Console.ReadKey();
        }

        public static void Function1(object a)
        {
            for (i = 0; i < 100000; i++)
            {
                Console.WriteLine("Text sent from calling function : {0}", a.ToString());
            }
        }
    }
}
