using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    interface IStudent
    {
       void getStudentName();
    }


    class Student : IStudent
    {
        public void getStudentName()
        {
            Console.WriteLine("Name is Omkar");
        }    }
}
