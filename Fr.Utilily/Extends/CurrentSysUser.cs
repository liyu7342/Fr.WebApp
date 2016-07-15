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

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

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
