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
    
    [Table("Sys_UserRole_Power")]
    public partial class SysUserRolePower
    {
    	/// <summary>
    	/// 用户角色功能权限Id
    	/// </summary>
    	[StringLength(50)]
    		
    	public string UserRolePowerId { get; set; }
    	/// <summary>
    	/// 用户角色Id
    	/// </summary>
    	[StringLength(50)]
    		
    	public string UserRoleId { get; set; }
    	/// <summary>
    	/// 功能权限Id
    	/// </summary>
    	[StringLength(50)]
    		
    	public string PowerId { get; set; }
    	/// <summary>
    	/// 
    	/// </summary>
    		
    	public System.DateTime? CreateTime { get; set; }
    	/// <summary>
    	/// 
    	/// </summary>
    	[StringLength(50)]
    		
    	public string CreateUserId { get; set; }
    	/// <summary>
    	/// 
    	/// </summary>
    	[StringLength(200)]
    		
    	public string CreateUserName { get; set; }
    	/// <summary>
    	/// 
    	/// </summary>
    		
    	public System.DateTime? ModifyTime { get; set; }
    	/// <summary>
    	/// 
    	/// </summary>
    	[StringLength(50)]
    		
    	public string ModifyUserId { get; set; }
    	/// <summary>
    	/// 
    	/// </summary>
    	[StringLength(200)]
    		
    	public string ModifyUserName { get; set; }
    }
    
    internal class SysUserRolePowerConfig : EntityTypeConfiguration<SysUserRolePower>
    {
        SysUserRolePowerConfig()
        {
            ToTable("Sys_UserRole_Power");
        }
    }
}
