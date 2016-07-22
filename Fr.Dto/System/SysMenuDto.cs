using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fr.Dto.System
{
    public class SysMenuDto
    {
        public string MenuId { get; set; }

        public string MenuCode { get; set; }


        public string MenuName { get; set; }


        public string ParentId { get; set; }


        public string Icon { get; set; }


        public string Category { get; set; }


        public string Location { get; set; }


        public int? Level { get; set; }


        public int? SortCode { get; set; }



        public string Remark { get; set; }


    }
}
