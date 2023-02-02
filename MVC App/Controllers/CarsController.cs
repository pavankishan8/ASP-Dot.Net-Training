using MVC_App.DataComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_App.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        public ActionResult Index()
        {
            var repo = new CarsRepo();
            var model = repo.GetAllCars();
            return View(model);
        }

        public ActionResult Edit(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                ViewBag.Message = "Car ID is not set, Please visit Index Page";
                return View();
            }

            var selectedId = int.Parse(id);
            var repo = new CarsRepo();
            var model = repo.FindCar(selectedId);
            if (model == null)
            {
                ViewBag.Message = "Car Info is not Available";
                return View();
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Car updatedData)
        {
            var repo = new CarsRepo();
            repo.UpdateCar(updatedData);
            return RedirectToAction("Index");
        }



        public ActionResult AddCar()
        {
            return View(new Car());
        }

        [HttpPost]
        public ActionResult AddCar(Car data)
        {
            var repo = new CarsRepo();
            repo.AddNewCar(data);
            return RedirectToAction("Index");
        }

        
        public ActionResult Del(string id)
        {
            int Cid = int.Parse(id);
            var repo = new CarsRepo();
            repo.DeleteCar(Cid);
            return RedirectToAction("Index");
        }
    }
}