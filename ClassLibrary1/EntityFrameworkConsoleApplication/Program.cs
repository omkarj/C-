using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityFrameworkConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var EmpObj = new EntityFrameworkDemoEntities())
            {
                //var emp = new Employee();
                //emp.EmpId = 6;
                //emp.EmpName = "Emp6";
                //emp.Salary = 150000;
                //EmpObj.Employees.Add(emp);

                //var emp1 = new Employee();
                //emp1.EmpId = 9;
                //emp1.EmpName = "Emp2";
                //emp1.Salary = 300000;
                //EmpObj.Employees.Add(emp1);


                //EmpObj.SaveChanges();
                //Console.WriteLine("Records Inserted");

                //Employee Emp1Obj = EmpObj.Employees.First(i => i.EmpId == 2);
                //Emp1Obj.EmpName = "abc";                  //Updating
                //Emp1Obj.Salary = 500;

                //EmpObj.Employees.Remove(Emp1Obj);           //Deleting
                //EmpObj.SaveChanges();

                var Emp2Obj = EmpObj.Employees;
                foreach (var v in Emp2Obj)                              //Retrieving data
                {
                    Console.WriteLine("Employee Name :{0} ", v.EmpName);
                }
            }
        }
    }
}
