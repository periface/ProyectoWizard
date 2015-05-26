using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoTareas.Areas.Bibliotecarios.Controllers
{
    public class MiAvatarController : Controller
    {
        //
        // GET: /Bibliotecarios/MiAvatar/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EditarAvatar() {
            return View();
        }
	}
}