using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fr.Adapter;
using Fr.Dto;
using Fr.Dto.JqGrid;
using Fr.Dto.System;
using Fr.IAdapter;

namespace Fr.WebApp.Areas.System.Controllers
{
    public class UserController : Controller
    {

        public UserController(ISysUserAdapter service)
        {
            _service = service;
        }
        //
        // GET: /System/User/
        ISysUserAdapter _service ;

        public ActionResult Index()
        {
            return View();
        }


        public JsonResult GetUserList( jqGridParam param)
        {
            int total = 0;
            var list = _service.GetUserList(param.Page, param.Rows, out total);
            var result = new JsonResponse<List<SysUserDto>>(){
                Data = list,
                Success=true
            };
            return  Json(result,JsonRequestBehavior.AllowGet);
        }
    }
}
