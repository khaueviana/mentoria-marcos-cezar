using System.Web.Mvc;

namespace UI.Areas.Plataforma
{
    public class PlataformaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Plataforma";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Plataforma_default",
                "Plataforma/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}