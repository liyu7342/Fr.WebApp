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
    
    [Table("Sys_Shortcuts")]
    public partial class SysShortcuts
    {
    	/// <summary>
    	/// 
    	/// </summary>
    	[StringLength(50),Key]
    		
    	public string ShortcutsId { get; set; }
    	/// <summary>
    	/// 
    	/// </summary>
    	[StringLength(50)]
    		
    	public string MenuId { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        [StringLength(50)]
        public string UserId { get; set; }

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
        /// <summary>
        /// 菜单
        /// </summary>
        public SysMenu SysMenu { get; set; } 


    }
    
    internal class SysShortcutsConfig : EntityTypeConfiguration<SysShortcuts>
    {
        SysShortcutsConfig()
        {
            ToTable("Sys_Shortcuts"); 
            HasOptional(x => x.SysMenu).WithMany().HasForeignKey(c=>c.MenuId);
        }
    }
}