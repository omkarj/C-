using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //MultipleThreads m = new MultipleThreads();
            //m.CreateAndCallThreads();

            //ForegroundBackgroundThread f = new ForegroundBackgroundThread();
            //f.CallThreads();

            //TPL t = new TPL();
            //t.TPLDemo();

            //TPool tp = new TPool();
            //tp.ThreadPoolDemo();

            //Synchronization s = new Synchronization();
            //s.SynchronizationUsingLock();
            //s.SynchronizationUsingMutex();
            //s.SynchronizationUsingSemaphore();

            DivideExample d = new DivideExample();
            Thread[] threads = new Thread[3];
            for (int i = 0; i < 3; i++)
            {
                Thread t = new Thread(new ThreadStart(d.DivideExampleCall));
                threads[i] = t;
            }
            for (int i = 0; i < 3; i++)
            {
                threads[i].Start();
            }
            Console.ReadKey();
        }
    }
}
