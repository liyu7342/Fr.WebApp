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
    
    [Table("Sys_LogDetail")]
    public partial class SysLogDetail
    {
    	/// <summary>
    	/// 
    	/// </summary>
    	[StringLength(50)]
    		
    	public string SysLogDetailId { get; set; }
    	/// <summary>
    	/// 
    	/// </summary>
    	[StringLength(50)]
    		
    	public string SysLogId { get; set; }
    	/// <summary>
    	/// 
    	/// </summary>
    	[StringLength(50)]
    		
    	public string PropertyName { get; set; }
    	/// <summary>
    	/// 
    	/// </summary>
    	[StringLength(50)]
    		
    	public string PropertyField { get; set; }
    	/// <summary>
    	/// 
    	/// </summary>
    	[StringLength(2000)]
    		
    	public string NewValue { get; set; }
    	/// <summary>
    	/// 
    	/// </summary>
    	[StringLength(50)]
    		
    	public string OldValue { get; set; }
    	/// <summary>
    	/// 
    	/// </summary>
    		
    	public System.DateTime? CreateDate { get; set; }
    }
    
    internal class SysLogDetailConfig : EntityTypeConfiguration<SysLogDetail>
    {
        SysLogDetailConfig()
        {
            ToTable("Sys_LogDetail");
        }
    }
}
