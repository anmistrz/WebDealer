using Microsoft.AspNetCore.Mvc.Rendering;
using WebPromotion.DAL.CarDAL;
using WebPromotion.Models;
using WebPromotion.ViewModels.CarView;

namespace WebPromotion.BL.CarBL
{
    public class CarBLClass : ICarBL
    {
        private readonly ICar _carDAL;

        public CarBLClass(ICar carDAL)
        {
            _carDAL = carDAL;
        }

        public void DeleteCar(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CarViewModels> GetAllCars()
        {
            throw new NotImplementedException();
        }

        public CarViewModels GetCarById(int id)
        {
            throw new NotImplementedException();
        }

        public List<SelectListItem> GetOptionsCar()
        {
            try 
            {
                var cars = _carDAL.GetAll();
                return cars.Select(car => new SelectListItem
                {
                    Value = car.CarId.ToString(),
                    Text = $"{car.Make} {car.CarModel} ({car.Year})"
                }).ToList();
            }
            catch (Exception ex)
            {
                // Handle exceptions as needed
                throw new Exception("Error retrieving car options", ex);
            }
        }

        public CarInsertViewModels InsertCar(CarInsertViewModels car)
        {
            throw new NotImplementedException();
        }

        public CarUpdateViewModels UpdateCar(CarUpdateViewModels car)
        {
            throw new NotImplementedException();
        }
    }
}
