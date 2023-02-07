using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeApp.Models
{
    public class EmployeeVM
    {
        public int EmpId { get; set; }
        [Required(ErrorMessage = "Name is Mandatory")]
        public string EmpName { get; set; }
        [Required(ErrorMessage = "Address is Mandatory")]
        [MinLength(4, ErrorMessage = "City name should be min of 4 characters")]
        public string EmpAddress { get; set; }
        [Range(20000, 100000, ErrorMessage = "Salary should be less than 100000 and more than 20000")]
        public int EmpSalary { get; set; }
        public int DeptId { get; set; }
    }
}