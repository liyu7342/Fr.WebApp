//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fr.Service
{ 
    using Fr.IService;
    using Fr.IRepositories;
    using Fr.Repositories;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public partial class SysMenuPermissionService:ISysMenuPermissionService
    { 
    	ISysMenuPermissionRepository _repository ;
    
    	/// <summary>
    	/// 构造函数注入
    	/// </summary>
    	/// <param name="repository"></param>
    	public SysMenuPermissionService(ISysMenuPermissionRepository repository){
    		_repository = repository;
    	}

        public List<Model.SysMenu> GetModuleList(List<string> roleIds)
        {
            return   _repository.Source.Where(c => roleIds.Contains( c.RoleId) && c.Status==Model.RecordStateEnum.启用).Select(c => c.SysMenu).Distinct().ToList();
        }
    }
	
}
