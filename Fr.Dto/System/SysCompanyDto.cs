using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fr.Dto.System
{
    public class SysCompanyDto
    {
        public string CompanyId { get;set; }

        public string ParentId{get;set;}

        public string CompanyName { get; set; }

        public string Status { get; set; }
    }
}
