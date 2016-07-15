using System.Web.Mvc;

namespace Fr.WebApp.Areas.PublicInfo
{
    public class PublicInfoAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "PublicInfo";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "PublicInfo_default",
                "PublicInfo/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
