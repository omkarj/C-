using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ScaffoldingDemo_DatabaseFirst_;

namespace ScaffoldingDemo_DatabaseFirst_.Controllers
{
    public class empDBsController : Controller
    {
        private EmployeeDBEntities1 db = new EmployeeDBEntities1();

        // GET: empDBs
        public ActionResult Index()
        {
            return View(db.empDBs.ToList());
        }

        // GET: empDBs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            empDB empDB = db.empDBs.Find(id);
            if (empDB == null)
            {
                return HttpNotFound();
            }
            return View(empDB);
        }

        // GET: empDBs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: empDBs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] empDB empDB)
        {
            if (ModelState.IsValid)
            {
                db.empDBs.Add(empDB);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(empDB);
        }

        // GET: empDBs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            empDB empDB = db.empDBs.Find(id);
            if (empDB == null)
            {
                return HttpNotFound();
            }
            return View(empDB);
        }

        // POST: empDBs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] empDB empDB)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empDB).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empDB);
        }

        // GET: empDBs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            empDB empDB = db.empDBs.Find(id);
            if (empDB == null)
            {
                return HttpNotFound();
            }
            return View(empDB);
        }

        // POST: empDBs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            empDB empDB = db.empDBs.Find(id);
            db.empDBs.Remove(empDB);
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
