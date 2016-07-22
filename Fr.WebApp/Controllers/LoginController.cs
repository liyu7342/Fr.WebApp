using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fr.Dto;
using Fr.Dto.System;
using Fr.Utilily;
using Fr.IAdapter;
using Fr.Adapter;
using Fr.Dto.Validate;
using System.Web.Security;
using Newtonsoft.Json;

namespace Fr.WebApp.Controllers
{
    public class LoginController : Controller
    {
        ISysUserAdapter _userService;
        public LoginController(ISysUserAdapter userService)
        {
            _userService = userService;
        }
        
 
        public ActionResult Index()
        {
            return View();
        }
         
        public ActionResult CheckLogin(string account, string password, string token)
        {
            
            string msg = "";
            try
            { 
                var result = _userService.Login(account, password);
                if (result == null)
                {
                    msg = "-1";
                }
                else if (result.Status == "启用")
                {
                    CurrentSysUser user = new CurrentSysUser
                    {
                        UserId = result.UserId,
                        LoginName = result.LoginName,
                        NickName = result.NickName,
                       // RoleId = 
                    };
                    var userStr = JsonConvert.SerializeObject(user);
                    FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(userStr, false, 6000);
                    //加密票据
                    string ticString = FormsAuthentication.Encrypt(ticket);
                    //输出到客户端
                    Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, ticString));
                    //if (string.IsNullOrEmpty(Request.QueryString["ReturnUrl"]))
                    //    return RedirectToAction("Index", "Home");
                    //else
                    //    return Redirect(HttpUtility.UrlDecode(Request.QueryString["ReturnUrl"]));
                    msg = "1";
                }
                else if (result.Status == "禁用")
                {
                    msg = "2";
                }
                else
                    msg = result.Status;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return Content(msg);
        }

        [Log("登出")]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return Redirect(FormsAuthentication.LoginUrl);
        }
    }
}
