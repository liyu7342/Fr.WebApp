﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fr
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Fr_dbEntities1 : DbContext
    {
        public Fr_dbEntities1()
            : base("name=Fr_dbEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Sys_Agent> Sys_Agent { get; set; }
        public virtual DbSet<Sys_Company> Sys_Company { get; set; }
        public virtual DbSet<Sys_Department> Sys_Department { get; set; }
        public virtual DbSet<Sys_Power> Sys_Power { get; set; }
        public virtual DbSet<Sys_Role> Sys_Role { get; set; }
        public virtual DbSet<Sys_User> Sys_User { get; set; }
        public virtual DbSet<Sys_UserRole> Sys_UserRole { get; set; }
        public virtual DbSet<Sys_UserRole_Power> Sys_UserRole_Power { get; set; }
        public virtual DbSet<Sys_Button> Sys_Button { get; set; }
        public virtual DbSet<Sys_ButtonPermission> Sys_ButtonPermission { get; set; }
        public virtual DbSet<Sys_Menu> Sys_Menu { get; set; }
        public virtual DbSet<Sys_MenuPermission> Sys_MenuPermission { get; set; }
        public virtual DbSet<Sys_Log> Sys_Log { get; set; }
        public virtual DbSet<Sys_LogDetail> Sys_LogDetail { get; set; }
    }
}