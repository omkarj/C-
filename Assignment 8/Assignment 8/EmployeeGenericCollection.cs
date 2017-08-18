using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    class EmployeeGenericCollection : IComparable<EmployeeGenericCollection>
    {
        public EmployeeGenericCollection(int empCode, string name, double salary)
        {
            this.empCode = empCode;
            this.name = name;
            this.salary = salary; 
        }

        public EmployeeGenericCollection()
        {
        }

        public int empCode { get; set; }
        public string name { get; set; }
        public double salary { get; set; }

        public  int CompareTo(EmployeeGenericCollection other)
        {
            return empCode.CompareTo(other.empCode);

        }

        /*
        public int CompareToSalary(EmployeeGenericCollection other)
        {
            return salary.CompareTo(other.salary);
        }

        public int CompareToName(EmployeeGenericCollection other)
        {
            return name.CompareTo(other.name);
        }
        */
    }

}
