//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fr.Adapter
{
    using Fr.Dto.System;
    using Fr.IAdapter;
    using Fr.IService;
    using Fr.Service;
    using System;
    using System.Collections.Generic;

    public partial class SysRoleAdapter : ISysRoleAdapter
    {
        ISysRoleService _service;
        public SysRoleAdapter(ISysRoleService service)
        {
            _service = service;
        }
        public SysRoleDto GetSysRole(string userId)
        {
            return _service.GetSysRole(userId).ToModel<SysRoleDto>();   
        }
    }
	
}
