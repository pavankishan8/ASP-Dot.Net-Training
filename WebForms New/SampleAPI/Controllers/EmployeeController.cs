using SampleAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SampleAPI.Controllers
{
    [EnableCors("*","*","*","*")]
    public class EmployeeController : ApiController
    {
        public List<Employee> GetAllEmployees()
        {
            var repo = new EmployeeDatabase();
            return repo.GetEmployees();
        }
    }
}