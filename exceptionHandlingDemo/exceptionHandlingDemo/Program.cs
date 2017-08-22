using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9
{
    class Program
    {
        static void Main(string[] args)
        {

            //TryCatchDemo1 t = new TryCatchDemo1();
            //t.Divide(5, 0);

            Temparature t = new Temparature();
            try
            {                
                t.showTemp();
            }
            catch (CustomException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
