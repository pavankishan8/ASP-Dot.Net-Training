using System.Collections.Generic;

namespace MVC_App.DataComponents
{
    public interface ICarsRepo
    {
        void AddNewCar(Car info);
        void DeleteCar(int entryID);
        Car FindCar(int id);
        List<Car> GetAllCars();
        void UpdateCar(Car carInfo);
    }
}