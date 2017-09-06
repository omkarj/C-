using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidationDemo.Models
{
    public class Student
    {
        [Key]
        [Required]
        public int RollNo { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [CustomEmailValidator]
        public string Email { get; set; }
    }
}