using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib.DataClasses
{
    public interface IDataClasses
    {
        void AddNewEmployee(Employee emp);
        void UpdateEmployee(Employee emp);
        void DeleteEmployee(int id);
        List<Employee> GetAllEmployees();
        List<Dept> GetAllDepts();

    }
}
