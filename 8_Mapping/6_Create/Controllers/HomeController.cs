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
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        //  public ActionResult Create(Department nuevo)
        public ActionResult Create_Post()//No se pueden tener dos ActionResult con el mismo nombre y los mismos parametros
        {
            if (ModelState.IsValid)
            {
                _6_Create.Models.Context con = new Context();
                Departament nuevo = new Departament();
                UpdateModel(nuevo);
                con.Departamentos.Add(nuevo);
                con.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
           
        }

    }
}
