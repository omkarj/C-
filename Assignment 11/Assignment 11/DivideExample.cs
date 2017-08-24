using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_11
{
    class DivideExample
    {
        private int number1, number2;
        private float result;
        Random random = new Random();

        public void DivideExampleCall()
        {
            DivideFunction();
            Thread t1 = new Thread(DivideFunction);
        }

        public void DivideFunction()
        {
            for (int i = 0; i < 100000; i++)
            {
                lock(this)
                {
                    number1 = random.Next(100);
                    number2 = random.Next(100);
                    result = number1 / number2;
                    Console.WriteLine("Division Result : {0}", result);
                }              
            }
        } 
    }
}
