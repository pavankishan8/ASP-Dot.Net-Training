using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebProducts.Models;
using WebProducts.ViewModels;

namespace WebProducts.Controllers
{
    public class EmployeeController : ApiController
    {
        public List<EmployeeVM> GetEmployees()
        {
            var context = new Entities();
            var empList = from emp in context.Employees
                          select new EmployeeVM
                          {
                              Address = emp.Address,
                              DeptId = emp.DeptId,
                              EmpId = emp.EmpId,
                              EmpName = emp.EmpName,
                              Salary = emp.Salary
                          };
            return empList.ToList();
        }

        [Route("api/Depts")]
        public List<Departments> GetDepts()
        {
            var context = new Entities();
            var deptList = context.Depts.Select(d => new Departments { DeptId = d.DeptId, DeptName = d.DeptName, Location = d.Location }).ToList();
            return deptList;
        }

        [HttpPost]
        public EmployeeVM AddNewEmployee(EmployeeVM  employeeVM)
        {

            var newEmp = new Employee
            {
                EmpName = employeeVM.EmpName,
                Address = employeeVM.Address,
                Salary = employeeVM.Salary,
                DeptId = employeeVM.DeptId
            };

            var context = new Entities();
            context.Employees.Add(newEmp);
            context.SaveChanges();
            return employeeVM;
            
        }

        [HttpPut]
        public void UpdateEmployee(EmployeeVM employeeVM)
        {
            var context = new Entities();

            var foundEmployee = context.Employees.Find(employeeVM.EmpId);

            if (foundEmployee == null)
            {
                throw new Exception("Employee not found");
            }

            foundEmployee.EmpName = employeeVM.EmpName;
            foundEmployee.Address = employeeVM.Address;
            foundEmployee.Salary = employeeVM.Salary;
            context.SaveChanges();
        }

        [HttpDelete]
        [Route("api/Employee/{id}")]
        public void DeleteEmployee(string id)
        {
            var pId = int.Parse(id);
            var context = new Entities();
            var found = context.Employees.Find(pId);
            context.Employees.Remove(found);
            context.SaveChanges();

        }
    }
}
