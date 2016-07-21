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
    
    [Table("Sys_Company")]
    public partial class SysCompany
    {
    	/// <summary>
    	/// 公司Id
    	/// </summary>
    	[StringLength(50)]
    		
    	public string CompanyId { get; set; }
    	/// <summary>
    	/// 公司名称
    	/// </summary>
    	[StringLength(200)]
    		
    	public string CompanyName { get; set; }
    	/// <summary>
    	/// 父公司Id
    	/// </summary>
    	[StringLength(50)]
    		
    	public string parentId { get; set; }
    	/// <summary>
    	/// 状态
    	/// </summary>
    		
    	public byte Status { get; set; }
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
    
    internal class SysCompanyConfig : EntityTypeConfiguration<SysCompany>
    {
        SysCompanyConfig()
        {
            ToTable("Sys_Company");
        }
    }
}