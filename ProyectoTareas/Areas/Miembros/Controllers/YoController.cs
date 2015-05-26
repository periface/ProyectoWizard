using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;

namespace ProyectoTareas.Areas.Miembros.Controllers
{
    [Authorize]
    public class YoController : Controller
    {
        //Basarse en el hecho de que todos son miembros
        //
        // GET: /Miembros/Yo/
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Redirección segun tipo
        /// </summary>
        /// <returns></returns>
        public ActionResult EditarDatos() {
            if (User.IsInRole("Bibliotecario")) { return RedirectToAction("EditarAvatar", new { Area = "Bibliotecarios" }); }
            if (User.IsInRole("Antiguo")) { return RedirectToAction("EditarAvatar", new { Area = "Antiguos" }); }
            return View();
        }
        public ActionResult MisCompras() {
            return View();
        }
	}
}