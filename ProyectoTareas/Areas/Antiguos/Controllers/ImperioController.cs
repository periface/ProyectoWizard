using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoTareas.Areas.Antiguos.Controllers
{
    public class ImperioController : Controller
    {
        //
        // GET: /Antiguos/Imperio/
        /// <summary>
        /// Desde aqui se controlan los aspectos basicos del sitio
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

	}
}