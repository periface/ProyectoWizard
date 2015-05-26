using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoTareas.Areas.Miembros.Controllers
{
    [Authorize(Roles="Premium")]
    public class ZonPremiumController : Controller
    {
        //
        // GET: /Miembros/ZonPremium/
        public ActionResult Index()
        {
            return View();
        }
	}
}