
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
    
[Table("Sys_Button")]
public partial class SysButton
{

	/// <summary>
	/// 
	/// </summary>
	
	[StringLength(50)]
	
	public string ButtonId { get; set; }

	/// <summary>
	/// 
	/// </summary>
	
	[StringLength(50)]
	
	public string MenuId { get; set; }

	/// <summary>
	/// 
	/// </summary>
	
	[StringLength(50)]
	
	public string ParentId { get; set; }

	/// <summary>
	/// 
	/// </summary>
	
	[StringLength(50)]
	
	public string Code { get; set; }

	/// <summary>
	/// 
	/// </summary>
	
	[StringLength(200)]
	
	public string ButtonName { get; set; }

	/// <summary>
	/// 
	/// </summary>
	
	[StringLength(50)]
	
	public string Category { get; set; }

	/// <summary>
	/// 
	/// </summary>
	
	[StringLength(50)]
	
	public string JsEvent { get; set; }

	/// <summary>
	/// 
	/// </summary>
	
	[StringLength(50)]
	
	public string ActionEvent { get; set; }

	/// <summary>
	/// 
	/// </summary>
	
	[StringLength(50)]
	
	public string Remark { get; set; }

	/// <summary>
	/// 
	/// </summary>
	
	public short? Status { get; set; }

	/// <summary>
	/// 
	/// </summary>
	
	public int? SortCode { get; set; }

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

internal class SysButtonConfig : EntityTypeConfiguration<SysButton>
{
    SysButtonConfig()
    {
        ToTable("Sys_Button");
    }
}

}
