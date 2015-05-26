using System.Web.Mvc;

namespace ProyectoTareas.Areas.Bibliotecarios
{
    public class BibliotecariosAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Bibliotecarios";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Bibliotecarios_default",
                "Bibliotecarios/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}