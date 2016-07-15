using Fr.IService;
using Fr.Model;
using Fr.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Fr.WebApi.Controllers
{
    public class UserController : ApiController
    {
        public UserController(ISysUserService userService)
        {
            _userService = userService;
        }
        ISysUserService _userService;

        [HttpPost]
         public bool Post([FromBody] SysUser user){
             return _userService.Add(user);
         }
    }
}