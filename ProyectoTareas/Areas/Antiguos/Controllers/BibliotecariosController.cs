using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoTareas.Areas.Antiguos.Controllers
{
    public class BibliotecariosController : Controller
    {
        //
        // GET: /Antiguos/Bibliotecarios/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EditarBibliotecarios() {
            return View();
        }
	}
}