using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_11
{
    class Synchronization
    {
        private int i;

        public void SynchronizationUsingLock()
        {
            Monitor.Enter(this);
            Function1();        
            Monitor.Exit(this);
        }

        public void SynchronizationUsingMutex()
        {
            using (var m1 = new Mutex(false, "Assignment 11"))
            {
                if (!m1.WaitOne(500,false))
                {
                    Console.WriteLine("Already an instance is running");
                    Console.ReadKey();
                }
                Function1();
                Console.ReadKey();
            }
        }

        public void SynchronizationUsingSemaphore()
        {
            Semaphore s1;
            try
            {
                s1 = Semaphore.OpenExisting("Assignment 11");
            }
            catch(Exception e)
            {
                s1 = new Semaphore(3, 3, "Assignment 11");

            }
            Console.WriteLine("Acquiring....");
            s1.WaitOne();
            Function1();
            Console.ReadKey();
            s1.Release();
        }

        public void Function1()
        {
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Inside Function1");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
