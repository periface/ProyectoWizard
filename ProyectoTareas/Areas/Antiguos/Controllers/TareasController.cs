using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoTareas.Areas.Antiguos.Controllers
{
    public class TareasController : Controller
    {
        //
        // GET: /Antiguos/Tareas/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EditarTareas() {
            return View();
        }
	}
}