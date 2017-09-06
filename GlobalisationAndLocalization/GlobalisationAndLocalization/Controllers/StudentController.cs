using GlobalisationAndLocalization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GlobalisationAndLocalization.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> studentList = new List<Student>();

        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Submit()
        {
            return View("StudentForm");
        }

        [HttpPost]
        public ActionResult AfterSubmit(Student st)
        {
            if (!ModelState.IsValid)
            {
                return View("StudentForm",st);
            }
            return View("Submit",st);
        }


    }
}