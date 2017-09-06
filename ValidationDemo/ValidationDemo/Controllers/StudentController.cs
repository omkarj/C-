using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationDemo.Models;

namespace ValidationDemo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.Message = "This is Index page";
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(Student model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.RollNo = model.RollNo;
                ViewBag.Name = model.Name;
                ViewBag.Email = model.Email;
            }
            return View(model);
        }
        
        public ActionResult Login()
        {
            ViewBag.Message = "This is Login page";
            return View();
     
        }
    }
}