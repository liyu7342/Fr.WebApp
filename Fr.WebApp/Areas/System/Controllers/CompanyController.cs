﻿using Fr.Dto;
using Fr.Dto.System;
using Fr.IAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fr.WebApp.Areas.System.Controllers
{
    public class CompanyController : Controller
    {
        ISysCompanyAdapter _adapter;
        public CompanyController(ISysCompanyAdapter adapter)
        {
            _adapter = adapter;
        }
        // GET: System/Company
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Form()
        {
            return View();
        }

        [JsonException]
        public JsonResult GetCompanyList()
        {
            var list = _adapter.GetCompanyList();
            return Json(new JsonResponse<List<SysCompanyDto>>() {success=true,data=list }, JsonRequestBehavior.AllowGet);
        }

        [JsonException]
        public JsonResult GetCompanyInfo(string keyId)
        {
            var entity = _adapter.GetCompanyInfo(keyId);
            return Json(new JsonResponse<SysCompanyDto> { success = true, data = entity }, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyId"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        [JsonException]
        public JsonResult SaveCompanyInfo(string keyId,SysCompanyDto data)
        {
            var result = _adapter.SaveCompanyInfo(keyId,data);
            return Json(new JsonResponse<bool>() { success=result});
        }
    }
}
