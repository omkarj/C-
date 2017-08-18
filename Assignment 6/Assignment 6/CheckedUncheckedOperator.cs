using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    public class CheckedUncheckedOperator
    {
        public void Operator()
        {
            try
            {
                int a = 300000;
                int b = 200000;
                int c = unchecked(a * b);
                Console.WriteLine(c);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }       
}
