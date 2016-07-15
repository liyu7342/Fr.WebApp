using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fr.Utilily
{
    public static class Common
    {
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


        public static string ToDateTimeString(this DateTime? dtime)
        {
            return dtime.ToDateTimeString("yyyy-MM-dd HH:mm:ss");   
        }

        public static string ToDateTimeString(this DateTime? dtime, string template)
        {
            if (!dtime.HasValue)
                return "";
            return dtime.Value.ToString(template);
        }
    }
}
