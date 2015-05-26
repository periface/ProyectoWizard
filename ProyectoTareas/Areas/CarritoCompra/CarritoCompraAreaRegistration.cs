using System.Web.Mvc;

namespace ProyectoTareas.Areas.CarritoCompra
{
    public class CarritoCompraAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "CarritoCompra";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "CarritoCompra_default",
                "CarritoCompra/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}