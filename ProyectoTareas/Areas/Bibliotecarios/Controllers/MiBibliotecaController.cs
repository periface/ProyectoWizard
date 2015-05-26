using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoTareas.Areas.Bibliotecarios.Controllers
{
    public class MiBibliotecaController : Controller
    {
        //
        // GET: /Bibliotecarios/MiBiblioteca/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EditarBiblioteca() {
            return View();
        }
        public ActionResult AgregarVolumen() {
            return View();
        }
	}
}