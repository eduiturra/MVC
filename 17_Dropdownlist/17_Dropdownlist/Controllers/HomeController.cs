using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _17_Dropdownlist.Models;

namespace _17_Dropdownlist.Controllers
{

    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            MVCdbContext con = new MVCdbContext();
            ViewBag.Departments = new SelectList(con.tblDepartment, "Id", "Name");
            ViewBag.Departments2 = new SelectList(con.tblDepartment, "Id", "Name","2");
            return View();
        }

    }
}
