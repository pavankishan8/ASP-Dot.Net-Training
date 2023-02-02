using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_App.DataComponents
{
    public class CarsRepo : ICarsRepo
    {
        private readonly CarsDataContext _context = new CarsDataContext();

        public void AddNewCar(Car info)
        {
            _context.Cars.InsertOnSubmit(info);
            _context.SubmitChanges();
        }

        public List<Car> GetAllCars() => _context.Cars.ToList();

        public Car FindCar(int id) => _context.Cars.FirstOrDefault((c) => c.EntryID == id);

        public void UpdateCar(Car carInfo)
        {
            var car = FindCar(carInfo.EntryID);
            Copy(car, carInfo);
            _context.SubmitChanges();
        }

        public void DeleteCar(int entryID)
        {
            var car = FindCar(entryID);
            _context.Cars.DeleteOnSubmit(car);
            _context.SubmitChanges();
        }

        private void Copy(Car current, Car other)
        {
            current.BodyType = other.BodyType;
            current.BrandName = other.BrandName;
            current.Capacity = other.Capacity;
            current.Engine = other.Engine;
            current.FuelType = other.FuelType;
            current.Model = other.Model;
            current.Price = other.Price;
        }
     
    }
   
}