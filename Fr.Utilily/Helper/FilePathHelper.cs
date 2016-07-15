using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;
using System.Configuration;

namespace Fr.Utilily.Helper
{
    /// <summary>
    /// 文件路径
    /// </summary>
    /// <remarks>
    /// </remarks>
    public class FilePathHelper
    {
        /// <summary>
        /// 获取临时文件夹的存放地址
        /// </summary>
        /// <returns></returns>
        public static string GetTempFilePath()
        {
            string result = string.Empty;
            string Path = ConfigurationManager.AppSettings["TempFilePath"].ToString();
            string Year = DateTime.Now.ToString("yyyy");
            string Month = DateTime.Now.ToString("MM");
            string Day = DateTime.Now.ToString("dd");
            result = string.Format(@"{0}\{1}\{2}\{3}\", Path, Year, Month, Day);
            return result;
        }

        /// <summary>
        /// 获取临时文件夹的存放地址
        /// </summary>
        /// <returns></returns>
        public static string GetPdfFilePath()
        {
            string result = string.Empty;
            string Path = ConfigurationManager.AppSettings["PdfFilePath"].ToString();
            result = string.Format(@"{0}\", Path);
            return result;
        }

        /// <summary>
        /// 获取临时文件存放的物理路径
        /// </summary>
        /// <param name="fileName">文件名称</param>
        /// <returns></returns>
        public static string GetTempFilePath(string fileName)
        {
            string result = string.Empty;
            string TempPath = FilePathHelper.GetTempFilePath();
            result = FilePathHelper.UrlConvertorLocal(TempPath);
            if (!Directory.Exists(result))
            {
                Directory.CreateDirectory(result);
            }
            result += fileName;
            return result;
        }

        /// <summary>
        /// 获取临时文件存放的物理路径
        /// </summary>
        /// <returns></returns>
        public static string GetPhysicsFilePath()
        {
            string result = string.Empty;
            string TempPath = FilePathHelper.GetTempFilePath();
            result = FilePathHelper.UrlConvertorLocal(TempPath);
            if (!Directory.Exists(result))
            {
                Directory.CreateDirectory(result);
            }
            return result;
        }


        /// <summary>
        /// 本地路径转换成URL相对路径
        /// </summary>
        /// <param name="Path"></param>
        /// <returns></returns>
        public static string UrlConvertor(string Path)
        {

            string tmpRootDir = System.Web.HttpContext.Current.Server.MapPath(System.Web.HttpContext.Current.Request.ApplicationPath.ToString());//获取程序根目录
            string imagesurl2 = Path.Replace(tmpRootDir, ""); //转换成相对路径
            imagesurl2 = imagesurl2.Replace(@"\", @"/");
            return imagesurl2;
        }

        /// <summary>
        /// 相对路径转换成服务器本地物理路径
        /// </summary>
        /// <param name="Path"></param>
        /// <returns></returns>
        public static string UrlConvertorLocal(string Path)
        {
            string tmpRootDir = System.Web.HttpContext.Current.Server.MapPath(System.Web.HttpContext.Current.Request.ApplicationPath.ToString());//获取程序根目录
            string imagesurl2 = tmpRootDir + Path.Replace(@"/", @"\"); //转换成绝对路径
            return imagesurl2;
        }

        /// <summary>
        /// 获取网站根目录
        /// </summary>
        /// <returns></returns>
        public static string GetApplicationRootDir()
        {
            return System.Web.HttpRuntime.BinDirectory.Substring(0, System.Web.HttpRuntime.BinDirectory.TrimEnd('\\').LastIndexOf("\\")) + "\\";
        }

        /// <summary>
        /// 获得目录的物理路径
        /// </summary>
        /// <param name="sPath">文件路径</param>
        /// <returns></returns>
        public static string GetPathAtApplication(string sPath)
        {
            string result = "";
            if (sPath.StartsWith("~"))
            {
                result = sPath.Replace("~/", GetApplicationRootDir()).Replace("/", "\\");
            }
            else
            {
                result = GetApplicationRootDir() + sPath;
            }
            return result;
        }
    }
}
