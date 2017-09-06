using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ScaffoldingDemo.Models
{
    public class ScaffoldingDemoEmployeeClass
    {
       
            //[Key]
            public int ID { get; set; }
            public string Name { get; set; }
            public DateTime JoiningDate { get; set; }
            public int Age { get; set; }
        }

        public class EmpDBContext : DbContext
        {
            public DbSet<ScaffoldingDemoEmployeeClass> Employees { get; set; }
        }
    }
