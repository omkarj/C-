using GlobalisationAndLocalization.LocalResources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GlobalisationAndLocalization.Models
{
    public class Student
    {
        //[DisplayName("Student Roll No.")]
        //[Required(ErrorMessage = "Please enter Roll No.")]
        
        [Display(Name = "RollNo", ResourceType = typeof(Resource))]
        //[Required(ErrorMessage = Resource.PleaseEnterRollNo)]
        public int RollNo { get; set; }

        //[DisplayName("Student Name")]
        //[Required(ErrorMessage = "Please enter Name")]
        [Display(Name = "Name", ResourceType = typeof(Resource))]
        public string Name { get; set; }
    }
}