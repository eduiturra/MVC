using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _21_Display.Models;
using System.Data;

namespace _21_Display.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            SampleContext db = new SampleContext();
            return View(db.tblEmployee.ToList());
        }

        //
        // GET: /Home/Details/5

        public ActionResult Details(int id)
        {
            SampleContext db = new SampleContext();
            tblEmployee emplo =  db.tblEmployee.Single(x => x.Id == id);
            //ViewData["EmployeeData"] = emplo;
            //@Html.Display("EmployeeData")
            return View(emplo);
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Home/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Home/Edit/5
 
        public ActionResult Edit(int id)
        {
            SampleContext db = new SampleContext();
            tblEmployee employee = db.tblEmployee.Single(x => x.Id == id);
            return View(employee);
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        public ActionResult Edit(tblEmployee emplo)
        {
            try
            {
                SampleContext db = new SampleContext();
                if (ModelState.IsValid)
                {
                    db.tblEmployee.Attach(emplo);
                    db.ObjectStateManager.ChangeObjectState(emplo, EntityState.Modified);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
               
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Home/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Home/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
