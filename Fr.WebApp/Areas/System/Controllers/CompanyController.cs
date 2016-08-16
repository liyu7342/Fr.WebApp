using Fr.Dto;
using Fr.Dto.System;
using Fr.IAdapter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        [JsonException,HttpGet]
        public ActionResult GetCompanyList()
        {
            var list = _adapter.GetCompanyList();
            StringBuilder sb = new StringBuilder();
            sb.Append("{ \"rows\": [");
            sb.Append(TreeGridJson(list, -1));
            sb.Append("]}");
            return Content(sb.ToString());
        }

        [JsonException,HttpGet]
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
        [JsonException,HttpPost]
        public JsonResult Save(string keyId,SysCompanyDto data)
        {
            var result = _adapter.SaveCompanyInfo(keyId,data);
            return Json(new JsonResponse() { success=result});
        }

        [JsonException,HttpPost]
        public JsonResult Delete(string keyId)
        {
            _adapter.Delete(keyId);
            return Json(new JsonResponse() { success=true});
        }

        
        int lft = 1, rgt = 1000000;
        public string TreeGridJson(List<SysCompanyDto> ListData, int index, string ParentId = "0")
        {
            StringBuilder sb = new StringBuilder();
            List<SysCompanyDto> ChildNodeList = ListData.FindAll(t => t.ParentId == ParentId);
            if (ChildNodeList.Count > 0) { index++; }
            foreach (SysCompanyDto entity in ChildNodeList)
            {
                string strJson =JsonConvert.SerializeObject(entity);
                strJson = strJson.Insert(1, "\"level\":" + index + ",");
                strJson = strJson.Insert(1, "\"isLeaf\":" + (ListData.Count<SysCompanyDto>(t => t.ParentId == entity.CompanyId) == 0 ? true : false).ToString().ToLower() + ",");
                strJson = strJson.Insert(1, "\"expanded\":true,");
                strJson = strJson.Insert(1, "\"lft\":" + lft++ + ",");
                strJson = strJson.Insert(1, "\"rgt\":" + rgt-- + ",");
                sb.Append(strJson);
                sb.Append(TreeGridJson(ListData, index, entity.CompanyId));
            }
            return sb.ToString().Replace("}{", "},{");
        }
    }
}
