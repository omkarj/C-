using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    class Employee
    {
        List<string> employee = new List<string>();
        public string Name { get; set; }

        public void AddEmployee()
        {
            Console.WriteLine("Enter employee name : ");
            employee.Add(Console.ReadLine());
        }

        public void UpdateEmployeeCollection()
        {
            Console.WriteLine("Enter the existing name of employee : ");
            string ExistingName = Console.ReadLine();
            Console.WriteLine("Enter the updated name of employee : ");
            string UpdatedName = Console.ReadLine();
            int flag = 0;
            for (int i = 0; i < employee.Count; i++)
            {
                if (employee[i] == ExistingName)
                {
                    employee[i] = UpdatedName;
                    Console.WriteLine("Name updated!");
                    flag = 1;
                }
            }
            if (flag == 0)
                Console.WriteLine("No such record exist!");
        }

        public void DeleteEmployeeRecord()
        {
            Console.WriteLine("Enter the name of the employee whose record is to be deleted : ");
            string ExistingName = Console.ReadLine();
            bool checkIfDeleted =employee.Remove(ExistingName);
            if (checkIfDeleted)
            {
                Console.WriteLine("Enter the name of the employee whose record is to be deleted : ");
                Console.WriteLine("Updated employee list : ");
                foreach (var v in employee)
                {
                    Console.WriteLine(v);
                }
            }
            else
            {
                Console.WriteLine("No such record exist");
            }
        }
    }
}
