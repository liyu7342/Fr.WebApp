using Fr.Security;
using Fr.Utilily;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fr.IAdapter;
using Fr.Dto.System;
using Fr.Dto;

namespace Fr.WebApp.Controllers
{

    public class HomeController : BaseController
    {
        ISysShortcutsAdapter _shortcutsAdapter { get; set; }
        ISysMenuPermissionAdapter _sysMenuPermissionAdapter { get; set; }
        public HomeController(ISysShortcutsAdapter sysShortcutsAdapter,ISysMenuPermissionAdapter sysMenuPermissionAdapter)
        {
            _shortcutsAdapter = sysShortcutsAdapter;
            _sysMenuPermissionAdapter = sysMenuPermissionAdapter;
        }
        
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AccordionPage()
        {
            ViewBag.Account = "管理员";
            return View();
        }

     


        /// <summary>
        /// 访问模块，写入系统菜单Id
        /// </summary>
        /// <param name="ModuleId">模块id</param>
        /// <param name="ModuleName">模块名称</param>
        /// <returns></returns>
        public ActionResult SetModuleId(string ModuleId, string ModuleName)
        {
            string _ModuleId = DESEncrypt.Encrypt(ModuleId);
            CookieHelper.WriteCookie("ModuleId", _ModuleId);
            if (!string.IsNullOrEmpty(ModuleName))
            {
                
                //SysLogAdapter.WriteLog(ModuleId, OperationType.Visit, "1", ModuleName);
            }
            return Content(_ModuleId);
        }


        /// <summary>
        /// 离开tab事件
        /// </summary>
        /// <param name="ModuleId">模块id</param>
        /// <param name="ModuleName">模块名称</param>
        /// <returns></returns>
        public ActionResult SetLeave(string ModuleId, string ModuleName)
        {
            //Base_SysLogBll.Instance.WriteLog(ModuleId, OperationType.Leave, "1", ModuleName);
            return Content(ModuleId);
        }

        #region 后台首页-开始菜单
        /// <summary>
        /// 开始菜单UI
        /// </summary>
        /// <returns></returns>
        public ActionResult StartIndex()
        {
            ViewBag.Account = CurrentUser == null ? "" : CurrentUser.NickName; //ManageProvider.Provider.Current().Account + "（" + ManageProvider.Provider.Current().UserName + "）";
            return View();
        }
        /// <summary>
        /// 开始-欢迎首页
        /// </summary>
        /// <returns></returns>
        public ActionResult StartPanel()
        {
            return View();
        }
        /// <summary>
        /// 加载开始菜单
        /// </summary>
        /// <returns></returns>
        public ActionResult LoadStartMenu()
        {
            string roleId = CurrentUser.RoleId;
            
            var list = _sysMenuPermissionAdapter.GetModuleList(roleId);
            return Content(list.Serialize());
        }
        #endregion

        #region 后台首页-手风琴菜单
        /// <summary>
        /// 手风琴UI
        /// </summary>
        /// <returns></returns>
        public ActionResult AccordionIndex()
        {
            ViewBag.Account =CurrentUser == null ? "" : CurrentUser.NickName ;
            return View();
        }
     
        /// <summary>
        /// 加载手风琴菜单
        /// </summary>
        /// <returns></returns>
        public ActionResult LoadAccordionMenu()
        {
             var list = _sysMenuPermissionAdapter.GetModuleList(CurrentUser.RoleId); 
            return Content(list.Serialize());
        }
        #endregion

        #region 后台首页-无限树菜单
        /// <summary>
        /// 无限树UI
        /// </summary>
        /// <returns></returns>
        public ActionResult TreeIndex()
        {
            ViewBag.Account = CurrentUser == null ? "" : CurrentUser.NickName;
            return View();
        }
        /// <summary>
        /// 无限树-欢迎首页
        /// </summary>
        /// <returns></returns>
        public ActionResult TreePage()
        {
            return View();
        }
        /// <summary>
        /// 加载无限树菜单
        /// </summary>
        /// <returns></returns>
        public ActionResult LoadTreeMenu(string ModuleId)
        {
            var list = _sysMenuPermissionAdapter.GetModuleList(CurrentUser.RoleId);
             
            List<TreeJsonEntity> TreeList = new List<TreeJsonEntity>();
            foreach (var item in list)
            {
                TreeJsonEntity tree = new TreeJsonEntity();
                
                if (item.Category == "页面")
                {
                    tree.Attribute = "Location";
                    tree.AttributeValue = item.Location;
                }
                tree.id = item.MenuId;
                tree.text = item.MenuName;
                tree.value = item.MenuId;
                tree.isexpand = false;
                tree.complete = true;
                tree.hasChildren = list.Any(t => t.ParentId == item.MenuId);
                tree.parentId = item.ParentId;
                tree.img = item.Icon != null ? "/Content/Images/Icon16/" + item.Icon : item.Icon;
                TreeList.Add(tree);
            }
            return Content(TreeList.TreeToJson(ModuleId));
        }
        #endregion

        #region 快捷方式设置
        /// <summary>
        /// 快捷方式设置
        /// </summary>
        /// <returns></returns>
        public ActionResult Shortcuts()
        {
            return View();
        }
        /// <summary>
        /// 快捷方式 返回菜单模块树JSON
        /// </summary>
        /// <returns></returns>
        public ActionResult ShortcutsModuleTreeJson()
        {
            string userId = CurrentUser.UserId;
            List<SysMenuDto>  shortcutList = _shortcutsAdapter.GetShortcutList(userId);

            List<SysMenuDto> list = _sysMenuPermissionAdapter.GetModuleList(CurrentUser.RoleId);
            List<TreeJsonEntity> TreeList = new List<TreeJsonEntity>();
            foreach (var item in list)
            {
                TreeJsonEntity tree = new TreeJsonEntity();
                tree.id = item.MenuId;
                tree.text = item.MenuName;
                tree.value = item.MenuId;
                if (item.Category == "页面")
                {
                    tree.checkstate = 0;//ShortcutList.FindAll(t => t.ModuleId == item.ModuleId).Count == 0 ? 0 : 1;
                    //tree.checkstate = item["objectid"].ToString() != "" ? 1 : 0;
                    tree.showcheck = true;
                }
                tree.isexpand = true;
                tree.complete = true;
                tree.hasChildren = list.Any(t => t.ParentId == item.MenuId);
                tree.parentId = item.ParentId;
                tree.img = item.Icon != null ? "/Content/Images/Icon16/" + item.Icon : item.Icon;
                TreeList.Add(tree);
            }
            return Content(TreeList.TreeToJson());
        }
        /// <summary>
        /// 快捷方式列表返回JSON
        /// </summary>
        /// <returns></returns>
        public ActionResult ShortcutsListJson()
        { 
            string UserId = CurrentUser.UserId;
            List<SysMenuDto> ShortcutList = _shortcutsAdapter.GetShortcutList(UserId);
            return Content(ShortcutList.Serialize());
        }
        /// <summary>
        /// 快捷方式设置 提交保存
        /// </summary>
        /// <param name="ModuleId"></param>
        /// <returns></returns>
        [JsonException]
        public ActionResult SubmitShortcuts(string menuId)
        { 
            string UserId = CurrentUser.UserId;
             _shortcutsAdapter.SaveShortcuts(menuId, UserId);
            return Content(new  JsonResponse{ success = true, message = "设置成功。" }.ToString());
            
        }
        #endregion

        #region 技术支持
        /// <summary>
        /// 技术支持
        /// </summary>
        /// <returns></returns>
        public ActionResult SupportPage()
        {
            return View();
        }
        #endregion

        #region 关于我们
        /// <summary>
        /// 关于我们
        /// </summary>
        /// <returns></returns>
        public ActionResult AboutPage()
        {
            return View();
        }
        #endregion

        #region 个性化皮肤设置
        /// <summary>
        /// 个性化皮肤设置
        /// </summary>
        /// <returns></returns>
        public ActionResult SkinIndex()
        {
            return View();
        }
        /// <summary>
        /// 切换主题
        /// </summary>
        /// <param name="UItheme"></param>
        /// <returns></returns>
        public ActionResult SwitchTheme(string UItheme)
        {
            CookieHelper.WriteCookie("UItheme", UItheme, 43200);
            return Content("1");
        }
        #endregion
    }
}
