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
    
    [Table("Sys_Log")]
    public partial class SysLog
    {
    	/// <summary>
    	/// 
    	/// </summary>
        [StringLength(50), Key]
    		
    	public string Id { get; set; }
    	/// <summary>
    	/// 
    	/// </summary>
    	[StringLength(50)]
    		
    	public string UserId { get; set; }
    	/// <summary>
    	/// 
    	/// </summary>
    	[StringLength(50)]
    		
    	public string LogType { get; set; }
    	/// <summary>
    	/// 
    	/// </summary>
    	[StringLength(50)]
    		
    	public string IPAddress { get; set; }
    	/// <summary>
    	/// 
    	/// </summary>
    	[StringLength(50)]
    		
    	public string IPAddressName { get; set; }
    	/// <summary>
    	/// 
    	/// </summary>
    	[StringLength(50)]
    		
    	public string CompanyId { get; set; }
    	/// <summary>
    	/// 
    	/// </summary>
    	[StringLength(50)]
    		
    	public string DepartmentId { get; set; }
    	/// <summary>
    	/// 
    	/// </summary>
    		
    	public System.DateTime? CreateDate { get; set; }
    	/// <summary>
    	/// 
    	/// </summary>
    	[StringLength(50)]
    		
    	public string CreateUserId { get; set; }
    	/// <summary>
    	/// 
    	/// </summary>
    	[StringLength(50)]
    		
    	public string CreateUserName { get; set; }
    	/// <summary>
    	/// 
    	/// </summary>
    	[StringLength(50)]
    		
    	public string ModuleId { get; set; }
    	/// <summary>
    	/// 
    	/// </summary>
    	[StringLength(50)]
    		
    	public string Remark { get; set; }
    	/// <summary>
    	/// 
    	/// </summary>

        public RecordStateEnum Status { get; set; }
    }
    
    internal class SysLogConfig : EntityTypeConfiguration<SysLog>
    {
        SysLogConfig()
        {
            ToTable("Sys_Log");
        }
    }
}
