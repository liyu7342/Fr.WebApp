using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fr.Dto.JqGrid
{
    public class jqGridParam
    {
        /// <summary>
        /// 页数
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// 每页显示条数
        /// </summary>
        public int Rows { get; set; }

        /// <summary>
        ///排序字段
        /// </summary>
        public string Sidx { get; set; }

        /// <summary>
        /// 排序方式 asc ? desc
        /// </summary>
        public string Sord { get; set; }
    }
}
