using AutoMapper;
using Fr.Dto.System;
using Fr.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fr.Utilily;

namespace Fr.Adapter
{
    /// <summary>
    /// Model和Entity之间的转换
    /// ConditionQuery和Condition之间的转换
    /// </summary>
    public static class MapperConfig
    {
        static MapperConfig()
        {
            Init();
        }
        private static void Init()
        {
            Mapper.CreateMap<SysUser, SysUserDto>() 
                .ForMember(c => c.CreateTime, c => c.MapFrom(src => src.CreateTime.ToDateTimeString()))
                .ForMember(c => c.ModifyTime, c => c.MapFrom(src => src.ModifyTime.ToDateTimeString()));
            Mapper.CreateMap<SysUserDto, SysUser>()
                .ForMember(c => c.CreateTime, c => c.MapFrom(src => src.CreateTime.ToDateTimeNull()))
                .ForMember(c => c.ModifyTime, c => c.MapFrom(src => src.ModifyTime.ToDateTimeNull()));

            Mapper.CreateMap<SysRole, SysRoleDto>() 
                .ForMember(c => c.CreateTime, c => c.MapFrom(src => src.CreateTime.ToDateTimeString()))
                .ForMember(c => c.ModifyTime, c => c.MapFrom(src => src.ModifyTime.ToDateTimeString()));

            Mapper.CreateMap<SysRoleDto, SysRole>()
                .ForMember(c => c.CreateTime, c => c.MapFrom(src => src.CreateTime.ToDateTimeNull()))
                .ForMember(c => c.ModifyTime, c => c.MapFrom(src => src.ModifyTime.ToDateTimeNull()));
            Mapper.CreateMap<SysUserRole, SysUserRoleDto>();
            Mapper.CreateMap<SysUserRoleDto, SysUserRole>();

            Mapper.CreateMap<SysMenu, SysMenuDto>();
            Mapper.CreateMap<SysMenuDto, SysMenu>();

            Mapper.CreateMap<SysCompany, SysCompanyDto>();
            Mapper.CreateMap<SysCompanyDto, SysCompany>();
        }

        public static TResult ToModel<TResult>(this object entity)
        {
            return Mapper.Map<TResult>(entity);
        }

        public static List<TResult> ToListModel<TResult, TInput>(this IEnumerable<TInput> list)
        {
            return list.Select(x => x.ToModel<TResult>()).ToList();
        }
    }
}
