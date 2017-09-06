using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ScaffoldingDemo.Models;

namespace ScaffoldingDemo.Controllers
{
    public class ScaffoldingDemoEmployeeClassesController : Controller
    {
        private EmpDBContext db = new EmpDBContext();

        // GET: ScaffoldingDemoEmployeeClasses
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }

        // GET: ScaffoldingDemoEmployeeClasses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScaffoldingDemoEmployeeClass scaffoldingDemoEmployeeClass = db.Employees.Find(id);
            if (scaffoldingDemoEmployeeClass == null)
            {
                return HttpNotFound();
            }
            return View(scaffoldingDemoEmployeeClass);
        }

        // GET: ScaffoldingDemoEmployeeClasses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ScaffoldingDemoEmployeeClasses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,JoiningDate,Age")] ScaffoldingDemoEmployeeClass scaffoldingDemoEmployeeClass)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(scaffoldingDemoEmployeeClass);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(scaffoldingDemoEmployeeClass);
        }

        // GET: ScaffoldingDemoEmployeeClasses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScaffoldingDemoEmployeeClass scaffoldingDemoEmployeeClass = db.Employees.Find(id);
            if (scaffoldingDemoEmployeeClass == null)
            {
                return HttpNotFound();
            }
            return View(scaffoldingDemoEmployeeClass);
        }

        // POST: ScaffoldingDemoEmployeeClasses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,JoiningDate,Age")] ScaffoldingDemoEmployeeClass scaffoldingDemoEmployeeClass)
        {
            if (ModelState.IsValid)
            {
                db.Entry(scaffoldingDemoEmployeeClass).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(scaffoldingDemoEmployeeClass);
        }

        // GET: ScaffoldingDemoEmployeeClasses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScaffoldingDemoEmployeeClass scaffoldingDemoEmployeeClass = db.Employees.Find(id);
            if (scaffoldingDemoEmployeeClass == null)
            {
                return HttpNotFound();
            }
            return View(scaffoldingDemoEmployeeClass);
        }

        // POST: ScaffoldingDemoEmployeeClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ScaffoldingDemoEmployeeClass scaffoldingDemoEmployeeClass = db.Employees.Find(id);
            db.Employees.Remove(scaffoldingDemoEmployeeClass);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
