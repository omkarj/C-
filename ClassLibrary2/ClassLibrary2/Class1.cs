using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary2
{
    public class Department
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string addUrl { get; set; }
    }
}
