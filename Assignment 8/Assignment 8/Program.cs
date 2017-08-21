using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    static class Program
    {
        static void Main(string[] args)
        {

            //RegularExpression r = new RegularExpression();
            //r.RegExForPhoneNumber();                                  //Question 1
            //r.RegExForExtraWhiteSpaces();                             //Question 2

            //Employee e = new Employee();
            //e.AddEmployee();
            //e.AddEmployee();                                          //Question 3
            //e.UpdateEmployeeCollection();
            //e.DeleteEmployeeRecord();

            List<EmployeeGenericCollection> emp = new List<EmployeeGenericCollection>();    //Question 4
            emp.Add(new EmployeeGenericCollection(700, "Anil", 6000));
            emp.Add(new EmployeeGenericCollection(600, "Sunil",8000));
            emp.Add(new EmployeeGenericCollection(500, "Ram", 9000));
            emp.Add(new EmployeeGenericCollection(400, "Shyam", 5000));

            foreach (var e in emp)
            {
                Console.WriteLine(e.empCode + "," +  e.name + "," + e.salary);
            }

            emp.Sort();
            Console.WriteLine("\nAfter sorting based on Employee Code : ");
            foreach (var e in emp)
            {
                Console.WriteLine(e.empCode + "," + e.name + "," + e.salary);
            }
            
            Console.ReadKey();
        }
    }
}