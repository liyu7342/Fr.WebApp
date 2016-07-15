using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fr.WebApi.Areas.System.Controllers
{
    public class SysUserController : Controller
    {
        //
        // GET: /System/SysUser/

        public ActionResult Index()
        {
            return View();
        }


        public JsonResult GetUsers()
        {
            return new JsonResult();
        }
    }
}
