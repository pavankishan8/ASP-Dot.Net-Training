using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
            return PartialView(new Employee());
        }

        [HttpPost]
        public ActionResult AddNew(Employee model)
        {
            _repo.AddNewEmployee(model);
            return RedirectToAction("Index");
        }

        public ActionResult Update()
        {
            return PartialView(new Employee());
        }

        [HttpPost]
        public ActionResult Update(Employee model)
        {
            _repo.UpdateEmployee(model);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string id)
        {
            var id1 = int.Parse(id);
            _repo.DeleteEmployee(id1);
            return RedirectToAction("Index");
        }
    }
}