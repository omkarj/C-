using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class GenerateTable
    {
        public void Table()
        {
            try
            {
                Console.WriteLine("Enter the number :");
                int Number = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Table of {0} :",Number);
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("{0} * {1} = {2}", Number, i, (Number * i));
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
