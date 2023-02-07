using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeApp.Models;
using EmployeeLib.DataClasses;

namespace EmployeeApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDataComponent _repo = new EmployeeDataComponent();
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AllEmployees()
        {
            var model = _repo.GetAllEmployees();
            return PartialView(model);
        }
        public ActionResult AddNew()
        {
            return PartialView(new EmployeeVM());
        }

        [HttpPost]
        public ActionResult AddNew(EmployeeVM model, string AllDep)
        {

            if (ModelState.IsValid)
            {
                model.DeptId = int.Parse(AllDep);
                var emp = new Employee
                {
                    EmpName = model.EmpName,
                    Address = model.EmpAddress,
                    Salary = model.EmpSalary,
                    DeptId = model.DeptId
                };

                _repo.AddNewEmployee(emp);
                return RedirectToAction("Index");
            }
            else
            {
                return PartialView(model);
            }
        }

        public ActionResult Update(string id)
        {
           var selected = _repo.find(int.Parse(id));
            return PartialView(selected);
        }

        [HttpPost]
        public ActionResult Update(Employee model,string AllDep)
        {
            model.DeptId = int.Parse(AllDep);
            _repo.UpdateEmployee(model);
            return RedirectToAction("Index");
        }

        public ActionResult Del(string id)
        {
            var id1 = int.Parse(id);
            _repo.DeleteEmployee(id1);
            return RedirectToAction("AllEmployees");
        }
    }
}