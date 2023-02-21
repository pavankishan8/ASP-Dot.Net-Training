using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleAPI.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public int EmpSalary { get; set; }
    }

    public class EmployeeDatabase
    {
        public List<Employee> GetEmployees() => new List<Employee>
        {
            new Employee{ EmpId = 1, EmpName="Pavan R", EmpAddress="Bangalore", EmpSalary = 25000},
            new Employee{ EmpId = 2, EmpName="Sachin R", EmpAddress="Mysore", EmpSalary = 28000},
            new Employee{ EmpId = 3, EmpName="Vishwas V", EmpAddress="Chikka", EmpSalary = 25000},
            new Employee{ EmpId = 4, EmpName="Sawai K", EmpAddress="Andhra", EmpSalary = 29000},
            new Employee{ EmpId = 5, EmpName="Akshatha H", EmpAddress="Hakkandi", EmpSalary = 28000},
            new Employee{ EmpId = 6, EmpName="Roja", EmpAddress="Mandya", EmpSalary = 27000},
        };
    }
}
