using Microsoft.AspNetCore.Mvc.Rendering;
using WebPromotion.DAL.CarDAL;
using WebPromotion.Models;
using WebPromotion.ViewModels.CarView;

namespace WebPromotion.BL.CarBL
{
    public class CarBLClass : ICarBL
    {
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
            throw new NotImplementedException();
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
