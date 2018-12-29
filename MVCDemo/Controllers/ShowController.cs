using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVCDemo.Services;
using MVCDemo.Entity;

namespace MVCDemo.Controllers
{
    [RoutePrefix("api/UserInfo")]
    public class ShowController : ApiController
    {        
        private EmployeeService service { get; set; }
        public ShowController(EmployeeService service)
        {
            this.service = service;
        }

        public ShowController()
        {
            this.service = new EmployeeService();
        }
       
        [HttpGet,Route()]
        public List<Empolyee> GetUserInfo()
        {
            var user = service.GetEmpolyees();
            return user;          
        }
    }
}
