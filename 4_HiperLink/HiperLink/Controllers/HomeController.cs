using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HiperLink.Models;

namespace HiperLink.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            EmployeeContext con = new EmployeeContext();
            List<Employee> emplo = con.Employees.ToList();
            return View(emplo);
        }
        public ActionResult Details(int id)
        {
            EmployeeContext con = new EmployeeContext();
            Employee emplo = con.Employees.Single(a=>a.EmployeeId==id);
            return View(emplo);
        }


    }
}
