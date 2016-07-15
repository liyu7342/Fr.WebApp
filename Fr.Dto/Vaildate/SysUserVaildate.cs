using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Fr.Dto.Validate
{
    public class SysUserValidate
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        public string UserId { get; set; }
        
        
        /// <summary>
        /// 账号
        /// </summary> 
        [Required(ErrorMessage="账号不能为空")]
        public string LoginName { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Required(ErrorMessage = "密码不能为空")]
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

        
    }
}
