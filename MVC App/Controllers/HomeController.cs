using MVC_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_App.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string HelloWorld() => "Hi Pavan!";
        public double GetNumber(string p1, string p2)
        {
            var first = double.Parse(p1);
            var second = double.Parse(p2);
            return first + second;
        }

        public ViewResult DisplayEmployee()
        {
            var employee = new Employee
            { EmployeeId = 1, EmployeeName = "Pavan R" ,EmployeeEmail = "pavan@gmail.com", EmployeeSalary = 30000};
            return View(employee);
        }
    }
}