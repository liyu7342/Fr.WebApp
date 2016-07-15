using Fr.Security;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace Fr.Utilily
{
    public static  class SysUserHelper
    {
        /// <summary>
        /// 秘钥
        /// </summary>
        private static string LoginUserKey = "Fr.Utilily";

        public static CurrentSysUser CurrentUser
        {
            get
            {
                
                
                var str = CookieHelper.GetCookie(FormsAuthentication.FormsCookieName);
                if(string.IsNullOrEmpty( str))
                    throw new Exception("登录信息超时，请重新登录。");
                CurrentSysUser user = JsonConvert.DeserializeObject<CurrentSysUser>(DESEncrypt.Decrypt(str)); 
                return user; 
            }
            set
            {
                CookieHelper.WriteCookie(LoginUserKey, DESEncrypt.Encrypt(JsonConvert.SerializeObject(value)), 1440);
            }
        }
         
    }
}
