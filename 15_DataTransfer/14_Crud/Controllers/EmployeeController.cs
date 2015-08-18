using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _14_Crud.Models;

namespace _14_Crud.Controllers
{ 
    public class EmployeeController : Controller
    {
        private MVCcontext db = new MVCcontext();

        //
        // GET: /Employee/

        public ViewResult Index()
        {
            var tblemployee = db.tblEmployee.Include("Department");
            return View(tblemployee.ToList());
        }

        public ViewResult EmployeeByDepartment()
        {
            var tblemployee = db.tblEmployee.Include("Department")
                              .GroupBy(x=>x.Department.Name)
                              .Select(y=>new DepartmentTotal
                               {
                                 Name=y.Key,
                                 Total=y.Count()
                               }).ToList().OrderByDescending(a=>a.Total);
            return View(tblemployee.ToList());
        }

        //
        // GET: /Employee/Details/5

        public ViewResult Details(int id)
        {
            Employee employee = db.tblEmployee.Single(e => e.EmployeeId == id);
            return View(employee);
        }

        //
        // GET: /Employee/Create

        public ActionResult Create()
        {
            ViewBag.DepartmentId = new SelectList(db.tblDepartment, "Id", "Name");
            return View();
        } 

        //
        // POST: /Employee/Create

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (string.IsNullOrEmpty(employee.Name))
            {
                ModelState.AddModelError("Name","Nombre");
            }
            if (ModelState.IsValid)
            {
                db.tblEmployee.AddObject(employee);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.DepartmentId = new SelectList(db.tblDepartment, "Id", "Name", employee.DepartmentId);
            return View(employee);
        }
        
        //
        // GET: /Employee/Edit/5
 
        public ActionResult Edit(int id)
        {
            Employee employee = db.tblEmployee.Single(e => e.EmployeeId == id);
            ViewBag.DepartmentId = new SelectList(db.tblDepartment, "Id", "Name", employee.DepartmentId);
            return View(employee);
        }

        //
        // POST: /Employee/Edit/5

        [HttpPost]
        public ActionResult Edit([Bind(Exclude="Name")]Employee employee)
        {
            Employee emplo = db.tblEmployee.Single(a => a.DepartmentId == employee.DepartmentId);
            emplo.City = employee.City;
            emplo.Gender = employee.Gender;
            emplo.DepartmentId= employee.DepartmentId;
            employee.Name = emplo.Name;
            if (ModelState.IsValid)
            {
                db.ObjectStateManager.ChangeObjectState(emplo, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartmentId = new SelectList(db.tblDepartment, "Id", "Name", employee.DepartmentId);
            return View(employee);
        }

        //
        // GET: /Employee/Delete/5
 
        public ActionResult Delete(int id)
        {
            Employee employee = db.tblEmployee.Single(e => e.EmployeeId == id);
            return View(employee);
        }

        //
        // POST: /Employee/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Employee employee = db.tblEmployee.Single(e => e.EmployeeId == id);
            db.tblEmployee.DeleteObject(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}