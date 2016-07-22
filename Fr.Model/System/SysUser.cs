//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fr.Model
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity.ModelConfiguration;
    using System;
    using System.Collections.Generic;
    
    [Table("Sys_User")]
    public partial class SysUser
    {
    	/// <summary>
    	/// 用户Id
    	/// </summary>
        [StringLength(50), Key]
    		
    	public string UserId { get; set; }
    	/// <summary>
    	/// 账号
    	/// </summary>
    	[StringLength(200)]
    		
    	public string LoginName { get; set; }
    	/// <summary>
    	/// 昵称
    	/// </summary>
    	[StringLength(200)]
    		
    	public string NickName { get; set; }
    	/// <summary>
    	/// 密码
    	/// </summary>
    	[StringLength(50)]
    		
    	public string Password { get; set; }
    	/// <summary>
    	/// 电话
    	/// </summary>
    	[StringLength(50)]
    		
    	public string Tel { get; set; }
    	/// <summary>
    	/// 手机
    	/// </summary>
    	[StringLength(50)]
    		
    	public string Phone { get; set; }
    	/// <summary>
    	/// 邮箱
    	/// </summary>
    	[StringLength(50)]
    		
    	public string Email { get; set; }
    	/// <summary>
    	/// 备注
    	/// </summary>
    	[StringLength(1000)]
    		
    	public string Remark { get; set; }
    	/// <summary>
    	/// 状态
    	/// </summary>
    		
    	public UserStateEnum Status { get; set; }
    	/// <summary>
    	/// 创建时间
    	/// </summary>
    		
    	public System.DateTime? CreateTime { get; set; }
    	/// <summary>
    	/// 创建人
    	/// </summary>
    	[StringLength(50)]
    		
    	public string CreateUserId { get; set; }
    	/// <summary>
    	/// 修改时间
    	/// </summary>
    		
    	public System.DateTime? ModifyTime { get; set; }
    	/// <summary>
    	/// 修改人
    	/// </summary>
    	[StringLength(50)]
    		
    	public string ModifyUserId { get; set; }
    	/// <summary>
    	/// 
    	/// </summary>
    	[StringLength(200)]
    		
    	public string CreateUserName { get; set; }
    	/// <summary>
    	/// 
    	/// </summary>
    	[StringLength(200)]
    		
    	public string ModifyUserName { get; set; }
    }
    
    internal class SysUserConfig : EntityTypeConfiguration<SysUser>
    {
        SysUserConfig()
        {
            ToTable("Sys_User");
        }
    }
}
