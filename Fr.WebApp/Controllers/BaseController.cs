using Fr.Utilily;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fr.WebApp.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            bool isAuth = requestContext.HttpContext.User.Identity.IsAuthenticated;
            if (isAuth)
            {
                
            }
            base.Initialize(requestContext);
        }


        public CurrentSysUser CurrentUser
        {
            get
            {
                return SysUserHelper.CurrentUser;
            }
        }
    }
}