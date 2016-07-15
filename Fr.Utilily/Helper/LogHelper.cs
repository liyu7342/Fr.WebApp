using Fr.Utilily.Helper;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Fr.Utilily.Helper
{
    public static class LogHelper
    {
        /// <summary>
        /// 日志级别
        /// </summary>
        public static readonly log4net.ILog loginfo = log4net.LogManager.GetLogger("loginfo");

        /// <summary>
        /// 日志级别
        /// </summary>
        public static readonly log4net.ILog logerror = log4net.LogManager.GetLogger("logerror");
        private static Dictionary<string, string> iPAndCity = new Dictionary<string, string>();
        public static string GetCityByIP(string ip)
        {
            string result = "北京";
            string ipcity = ConfigurationManager.AppSettings["ipcity"];
            var client = new RestClient(string.Format(ipcity, ip));
            var request = new RestRequest("", Method.GET);
            var data = client.Execute<IPAndCity>(request);
            try
            {
                IPAndCity city = JsonConvert.DeserializeObject<IPAndCity>(data.Content);
                result = city.data.city;
            }
            catch { }
            return result;
        }

        /// <summary>
        /// 指定格式写入日志
        /// </summary>
        /// <param name="concent">记录内容</param>
        public static void Ilog(string http_referer, string concent)
        {
            try
            {
                string userAccount="admin";
                 
                string httpClientDoMain = ConfigurationManager.AppSettings["ReLogInUrl"];
                string clientIp = "";
                string insiteIp="";//= CookieHelper.GetWebSiteIpAndPort();
                //string fwVersion = Environment.Version.ToString();
                //string port = CookieHelper.GetWebSitePort();
                string serverIp = HttpContext.Current.Request.ServerVariables.Get("Local_Addr");
                string company = "";
                string city = "";
                if (!iPAndCity.Keys.Contains(clientIp))
                {
                    city = GetCityByIP(clientIp);
                    iPAndCity.Add(clientIp, city);
                }
                else
                {
                    city = iPAndCity[clientIp];
                }
                //{0}          - {1}          {2}          [{3}]         {4}   {5}      {6}             {7}            {8}          {9}
                //$remote_addr - $remote_user $remote_city [$time_local] $host $request $requestconcent $upstream_addr $server_addr $remote_company
                string logConcentFormat = "{0} - {1} {2} [{3}] {4} {5} {6} {7} {8} {9}";
                string logConcent = string.Format(logConcentFormat, clientIp, userAccount, city,
                    DateTime.Now.ToString("yyyyMMddHHmmss"), httpClientDoMain, http_referer, concent, insiteIp, serverIp,
                    company);
                string token = DateTime.Now.ToString("yyyyMMdd") + ".log";
                string logRoot = FilePathHelper.GetPathAtApplication("Logs\\" + DateTime.Now.ToString("yyyy"));
                if (!Directory.Exists(logRoot))
                {
                    Directory.CreateDirectory(logRoot);
                }
                StreamWriter sw = new StreamWriter(logRoot + "\\" + token, true);
                sw.WriteLine(logConcent);//写入
                sw.Close();
            }
            catch (Exception ex)
            {
                Error(ex.Message, ex);
            }
        }

        public static void WriteLog(string info)
        {
            if (loginfo.IsInfoEnabled)
            {
                loginfo.Info(info);
            }
        }

        /// <summary>
        /// 输出消息
        /// </summary>
        /// <param name="info">错误标题</param>
        /// <param name="se">异常消息</param>
        public static void WriteLog(string info, Exception se)
        {
            if (logerror.IsErrorEnabled)
            {
                logerror.Error(info, se);
            }
        }

        /// <summary>
        /// 错误记录封装
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public static void Error(string message, Exception ex)
        {
            if (logerror.IsErrorEnabled)
            {
                if (!string.IsNullOrEmpty(message) && ex == null)
                {
                    logerror.ErrorFormat("<br/>【附加信息】 : {0}<br>", new object[] { message });
                }
                else if (!string.IsNullOrEmpty(message) && ex != null)
                {
                    string errorMsg = BeautyErrorMsg(ex);
                    logerror.ErrorFormat("<br/>【附加信息】 : {0}<br>{1}", new object[] { message, errorMsg });
                }
                else if (string.IsNullOrEmpty(message) && ex != null)
                {
                    string errorMsg = BeautyErrorMsg(ex);
                    logerror.Error(errorMsg);
                }
            }
        }


        /// <summary>
        /// 美化错误信息
        /// </summary>
        /// <param name="ex">异常</param>
        /// <returns>错误信息</returns>
        private static string BeautyErrorMsg(Exception ex)
        {
            string errorMsg = string.Format("【异常类型】：{0} <br>【异常信息】：{1} <br>【堆栈调用】：{2}",
                new object[] { ex.GetType().Name, ex.Message, ex.StackTrace });
            errorMsg = errorMsg.Replace("\r\n", "<br>");
            errorMsg = errorMsg.Replace("位置", "<strong style=\"color:red\">位置</strong><br/>");
            return errorMsg;
        }
    }

    /// <summary>
    /// 操作结果返回
    /// </summary>
    /// <remark>
    /// </remark>
    internal class IPAndCity
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public int code { set; get; }

        /// <summary>
        /// 附加数据
        /// </summary>
        public IPAndCityInfo data { set; get; }

        public IPAndCity()
        {
            code = 0;
        }

    }

    /// <summary>
    /// 操作结果返回
    /// </summary>
    /// <remark>
    internal class IPAndCityInfo
    {
        public string country { set; get; }
        public string country_id { set; get; }
        public string area { set; get; }
        public string area_id { set; get; }
        public string region { set; get; }
        public string region_id { set; get; }
        public string city { set; get; }
        public string city_id { set; get; }
        public string county { set; get; }
        public string county_id { set; get; }
        public string isp { set; get; }
        public string isp_id { set; get; }
        public string ip { set; get; }
    }
}
