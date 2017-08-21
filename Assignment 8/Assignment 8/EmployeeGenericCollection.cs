using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    public class EmployeeGenericCollection : IComparable<EmployeeGenericCollection>
    {
        public EmployeeGenericCollection(int empCode, string name, double salary)
        {
            this.empCode = empCode;
            this.name = name;
            this.salary = salary;
        }

        public int empCode { get; set; }
        public string name { get; set; }
        public double salary { get; set; }

        public int CompareTo(EmployeeGenericCollection other)
        {
            int result;
            result = empCode.CompareTo(other.empCode);
            //result = name.CompareTo(other.name);  
            //result = salary.CompareTo(other.salary);    
            return result;  
        }
    }
}
