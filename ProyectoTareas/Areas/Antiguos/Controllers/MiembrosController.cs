using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoTareas.Areas.Antiguos.Controllers
{
    public class MiembrosController : Controller
    {
        //
        // GET: /Antiguos/Miembros/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Miembros() {
            return View();
        }
	}
}