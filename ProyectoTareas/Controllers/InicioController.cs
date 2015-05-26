using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoTareas.Controllers
{
    public class InicioController : Controller
    {
        //
        // GET: /Inicio/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Tienda()
        {
            return View();
        }
        public ActionResult Colaboradores()
        {
            return View();
        }
        public ActionResult Servicios()
        {
            return View();
        }
        public ActionResult Contacto()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contacto(FormCollection forms)
        {
            return View();
        }
        public ActionResult ComoFunc() {
            return View();
        }
    }
}