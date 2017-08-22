using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9
{
    class TryCatchDemo1
    {

        int result;
        public void Divide(int i, int j)
        {
            try
            {
                result = i / j;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Division Result : {0}", result);
            }
        }
    }
}
