using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controlador.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public string Index(string id)
        {
            return "id=" + id + " Name:" + Request.QueryString["name"]; 
            //Home/Index/10?name=Eduardo
            //hacer seguimiento /Trace.axd <trace enabled="true" pageOutput="false"/>
        }

        public string GetDetatails()
        {
            return "GetDetatails Invoke";
        }

    }
}
