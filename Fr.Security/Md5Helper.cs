using System;
using System.Collections.Generic;
using System.Text;

namespace Fr.Security
{
    /// <summary>
    /// MD5加密帮助类
    /// </summary>
    public class Md5Helper
    {

        #region "MD5加密"
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="str">加密字符</param>
        /// <param name="code">加密位数16/32</param>
        /// <returns></returns>
        public static string MD5(string str, int code)
        {
            string strKey = "Fr.Security";
            string strEncrypt = string.Empty;
            if (code == 16)
            {
                strEncrypt = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(strKey+str, "MD5").Substring(8, 16);
            }
            else 
            {
                strEncrypt = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(strKey +str, "MD5");
            }

            return strEncrypt;
        }

        public static string MD5(string str)
        {
            return MD5(str, 32);
        }
        #endregion
    }
}
