using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fr.Utilily
{
    public static class Common
    {
        /// <summary>
        /// 字符串转换成日期
        /// </summary>
        /// <param name="timeStr"></param>
        /// <returns></returns>
        public static DateTime? ToDateTimeNull(this string timeStr)
        {
            if (string.IsNullOrEmpty(timeStr))
                return null;
            DateTime dtime;
            var result = DateTime.TryParse(timeStr, out dtime);
            if (result)
                return dtime; 
            return  null; 
        }

        /// <summary>
        /// 日期转换成字符串
        /// </summary>
        /// <param name="dtime"></param>
        /// <returns></returns>
        public static string ToDateTimeString(this DateTime? dtime)
        {
            return dtime.ToDateTimeString("yyyy-MM-dd HH:mm:ss");   
        }

        /// <summary>
        /// 日期转换成字符串
        /// </summary>
        /// <param name="dtime"></param>
        /// <param name="template"></param>
        /// <returns></returns>
        public static string ToDateTimeString(this DateTime? dtime, string template)
        {
            if (!dtime.HasValue)
                return "";
            return dtime.Value.ToString(template);
        }

        /// <summary>
        /// 序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string Serialize<T>(this T obj) where T : class
        {
            if (obj == null)
                return "";
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T Deserialize<T>(this string obj) where T:class
        {
            if (string.IsNullOrEmpty(obj)) return null;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(obj);

        }
    }
}
