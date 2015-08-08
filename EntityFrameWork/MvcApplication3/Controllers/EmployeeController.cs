using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication3.Models;

namespace MvcApplication3.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
       
        public ActionResult Details()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 101,
                Gender = "Male",
                City = "Melipilla",
                Name = "Eduardo"

            };
            return View(employee);
        }

        public ActionResult Entity()
        {
            EmployeeContext context = new EmployeeContext();
            Employee emplo = context.Employees.Single();
            return View(emplo);
        }

    }
}
