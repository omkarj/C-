using SampleASPWebApplication.ActionFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleASPWebApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        //public ActionResult Index()
        //{
        //    //return View();
        //    return RedirectToAction("GetAllCustomers", "Customer");
        //}

        public string Index()
        {
            return "Hi this is home controller";
        }

        [ActionName("CurrentTime")]
        public string GetCurrentTime()
        {
            return DateTime.Now.ToString("T");
        }
    }
}