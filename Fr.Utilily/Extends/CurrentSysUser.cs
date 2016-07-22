using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fr.Utilily
{
    public class CurrentSysUser
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        public string UserId { get; set; }


        /// <summary>
        /// 账号
        /// </summary> 
        public string LoginName { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }


        public string RoleId { get; set; }


        public string CompanyId { get; set; }

        public string DeptId { get; set; }
         
    }
}
