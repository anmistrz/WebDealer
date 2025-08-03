using Microsoft.AspNetCore.Mvc.Rendering;
using WebPromotion.Models;
using WebPromotion.ViewModels.CarView;

namespace WebPromotion.BL.CarBL
{
    public interface ICarBL
    {
        public CarInsertViewModels InsertCar(CarInsertViewModels car);
        public CarUpdateViewModels UpdateCar(CarUpdateViewModels car);
        public void DeleteCar(int id);
        public CarViewModels  GetCarById(int id);
        public IEnumerable<CarViewModels> GetAllCars();
        public List<SelectListItem> GetOptionsCar();

    }
}
