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

        public ActionResult Create_Post()
        {
            if (ModelState.IsValid)
            {
                _6_Create.Models.Context con = new Context();
                Departament nuevo = new Departament();
                TryUpdateModel(nuevo);//El UpdateModel no valida, El TryUpdateModel tira el mensaje de validacion
                con.Departamentos.Add(nuevo);
                con.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();

        }
        [HttpGet]
        [ActionName("Edit")]
        public ActionResult Edit_Get(int id)
        {
            _6_Create.Models.Context con = new Context();
            Departament dep = con.Departamentos.Single(a => a.ID == id);
            return View(dep);
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post(int id) 
        {
            _6_Create.Models.Context con = new Context();
            Departament dep= con.Departamentos.Single(a => a.ID == id);
            UpdateModel<IDepartament>(dep);
            if (ModelState.IsValid)
            {
                
                con.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(dep);


        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            _6_Create.Models.Context con = new Context();
            Departament dep = con.Departamentos.Single(a=>a.ID==id);
            con.Departamentos.Remove(dep);
            con.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
