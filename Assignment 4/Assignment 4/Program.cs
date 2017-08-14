using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            StaticClass.print("Omkar");
            int i = 2;
            i.CheckLogin();

            IStudent student = new Student();
            student.getStudentName();
            
            SwapNumbers s = new SwapNumbers();
            s.Swap();
            
            GenerateTable s = new GenerateTable();
            s.Table();
            */
            RemoveVowels s = new RemoveVowels();
            s.Remove();

            Console.ReadLine();
        }
    }
}
