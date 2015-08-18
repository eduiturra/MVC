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

        [HttpPost]
        public ActionResult Create(FormCollection formColection)
        {
            _6_Create.Models.Context con = new Context();
            Response.Write(formColection["Name"]);
            Response.Write("<br/>");
            foreach (string key in formColection.AllKeys)
            {
                Response.Write("Key= " + key + "  ");
                Response.Write(formColection[key]);
                Response.Write("<br/>");
            }
            Departament nuevo = new Departament();
            nuevo.ID = 5;
            nuevo.Name = formColection["Name"];
            con.Departamentos.Add(nuevo);
            con.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
