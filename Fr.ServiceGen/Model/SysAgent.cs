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
    
    [Table("Sys_Agent")]
    public partial class SysAgent
    {
    	/// <summary>
    	/// 代理Id
    	/// </summary>
    	[StringLength(50)]
    		
    	public string AgentId { get; set; }
    	/// <summary>
    	/// 用户Id
    	/// </summary>
    	[StringLength(50)]
    		
    	public string UserId { get; set; }
    	/// <summary>
    	/// 上级代理Id
    	/// </summary>
    	[StringLength(50)]
    		
    	public string ParentId { get; set; }
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
    
    internal class SysAgentConfig : EntityTypeConfiguration<SysAgent>
    {
        SysAgentConfig()
        {
            ToTable("Sys_Agent");
        }
    }
}
