using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_Part2
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DepartmentName { get; set; }
        public string ProjectName { get; set; }
    }

    class EmployeeData
    {
        public void DisplayEmployeeData()
        {
            Employee e1 = new Employee()
            {
                ID = 1,
                Name = "Anil",
                DepartmentName = "Finance",
                ProjectName = "ABC"
            };

            Employee e2 = new Employee()
            {
                ID = 2,
                Name = "Sunil",
                DepartmentName = "IT",
                ProjectName = "PQR"
            };

            Employee e3 = new Employee()
            {
                ID = 3,
                Name = "Ajay",
                DepartmentName = "Admin",
                ProjectName = "XYZ"
            };

            List<Employee> employee = new List<Employee>(3);
            employee.Add(e1);
            employee.Add(e2);
            employee.Add(e3);

            //Lamba Expressions
            Console.WriteLine("Employees which do not have ID as 1 (Example of Find) :");
            foreach (Employee e in employee.FindAll(e => (e.ID != 1)))
            {
                Console.WriteLine("ID={0}, Name={1}, DepartmentName={2}, ProjectName={3}", e.ID, e.Name, e.DepartmentName, e.ProjectName);
            }

            Console.WriteLine("\nEmployee Name where ID=1 (Example of Where):");
            foreach (Employee e in employee.Where(e => (e.ID != 1)))
            {
                Console.WriteLine("ID={0}, Name={1}", e.ID, e.Name);
            }

            Console.WriteLine("\nEmployee from Admin Department (Example of Any):");
            if (employee.Any(e => (e.DepartmentName == "Admin")))
            {
                Console.WriteLine("Employee Name : {0}",e1.Name);
            }

            Console.WriteLine("\nEmployee from Admin Department (Example of Group by):");
            var tmp = employee.GroupBy(x => x.ID);
            var result = tmp.Select(y => new {
                ID = y.Key,
            });
            foreach (var v in result)
            {
                Console.WriteLine("Employee ID : {0}", v.ID);
            }
        }
    }
}
