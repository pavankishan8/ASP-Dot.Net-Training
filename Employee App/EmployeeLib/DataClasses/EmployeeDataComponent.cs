using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib.DataClasses
{
    public class EmployeeDataComponent : IDataClasses
    {
        private Entities _context = new Entities();
        public void AddNewEmployee(Employee emp)

        {
            _context.Employees.Add(emp);
            _context.SaveChanges();
        }

        public void DeleteEmployee(int empId)
        {
            var rec = _context.Employees.FirstOrDefault((e) => e.EmpId == empId);
            if (rec != null)
            {
                _context.Employees.Remove(rec);
                _context.SaveChanges();
            }
            else {
                throw new System.Exception("Employee Not Found!");
            }
        }

        public List<Dept> GetAllDepts()
        {
            return _context.Depts.ToList();
        }

        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employee find(int id) => _context.Employees.FirstOrDefault((p) => p.EmpId == id);

        public void UpdateEmployee(Employee emp)
        {
            var rec = _context.Employees.FirstOrDefault((e) => e.EmpId == emp.EmpId);
            if (rec != null)
            {
                rec.Address = emp.Address;
                rec.DeptId = emp.DeptId;
                rec.EmpName = emp.EmpName;
                rec.Salary = emp.Salary;
                _context.SaveChanges();
            }
            else
            {
                throw new System.Exception("Employee Not Found!");
            }
        }

       
    }
}
