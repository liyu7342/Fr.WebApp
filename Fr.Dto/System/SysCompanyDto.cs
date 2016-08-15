using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fr.Dto.System
{
    public class SysCompanyDto
    {
        /// <summary>
        /// 公司Id
        /// </summary>
        public string CompanyId { get;set; }

        /// <summary>
        /// 公司编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 上级公司Id
        /// </summary>
        public string ParentId{get;set;}
        /// <summary>
        /// 公司名称
        /// </summary>
        public string CompanyName { get; set; }

       

        /// <summary>
        /// 公司性质 
        /// </summary>
        public string Nature { get; set; }

        /// <summary>
        /// 法人
        /// </summary>
        public string Manager { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public string Contact { get; set; }

        /// <summary>
        /// 手机
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 电子邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 传真
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        ///网站
        /// </summary>
        public string WebSite { get; set; }

        /// <summary>
        /// 开户信息
        /// </summary>
        public string AccountInfo { get; set; }

        /// <summary>
        /// 公司地址
        /// </summary>
        public string Adress { get; set; }

        /// <summary>
        /// 公司简介
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 排序
        /// </summary>

        public int? SortOrder { get; set; }

    }
}
