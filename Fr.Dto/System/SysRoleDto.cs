using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fr.Dto.System
{
    public class SysRoleDto
    {
        /// <summary>
        /// 角色Id
        /// </summary>
        public string RoleId { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public string CreateTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string CreateUser { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public string ModifyTime { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public string ModifyUser { get; set; }
    }
}
