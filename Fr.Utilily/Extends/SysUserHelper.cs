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
        public static CurrentSysUser CurrentUser
        {
            get
            { 
                var str = CookieHelper.GetCookie(FormsAuthentication.FormsCookieName);
                if(string.IsNullOrEmpty( str))
                    return null;
                var ticket = FormsAuthentication.Decrypt(str);
                if (ticket == null || string.IsNullOrEmpty(ticket.UserData))
                    return null;
                CurrentSysUser user = JsonConvert.DeserializeObject<CurrentSysUser>(ticket.UserData); 
                return user; 
            } 
        }
         
    }
}
