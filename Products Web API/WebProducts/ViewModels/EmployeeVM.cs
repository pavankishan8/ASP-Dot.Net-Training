using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProducts.ViewModels
{
    public class EmployeeVM
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }
        public int DeptId { get; set; }
    }

    public class Departments
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string Location { get; set; }
    }
}