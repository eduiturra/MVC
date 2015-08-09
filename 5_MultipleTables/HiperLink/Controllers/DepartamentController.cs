using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HiperLink.Models;

namespace HiperLink.Controllers
{
    public class DepartamentController : Controller
    {
        //
        // GET: /Departament/

        public ActionResult Index()
        {
            EmployeeContext con = new EmployeeContext();
            List<Department> dep = con.Departaments.ToList();
            return View(dep);
        }

    }
}
