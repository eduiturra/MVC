using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _6_Create.Models;

namespace _6_Create.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            _6_Create.Models.Context con = new Context();
            List<Departament> dep = con.Departamentos.ToList();
            return View(dep);
        }

        [HttpGet]
        public ActionResult Create()
        {
            
            return View();
        }

    }
}
