using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vista.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Pais = new List<string>()
            { 
                "India",
                "UK",
                "Canada",
                "US"
            };

            ViewData["Paises"] = new List<string>()
            { 
                "India",
                "UK",
                "Canada",
                "US"
            };

            return View();
        }

        

    }
}
