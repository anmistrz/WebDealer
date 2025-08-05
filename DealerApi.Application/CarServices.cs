using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.DAL.Interfaces;
using DealerApi.Application.DTO;
using DealerApi.Application.Interface;

namespace DealerApi.Application
{
    public class CarServices : ICarServices
    {
        private readonly ICar _carDAL;

        public CarServices(ICar carDAL)
        {
            _carDAL = carDAL;
        }

        public Task<IEnumerable<CarOptionsDTO>> GetCarOptions()
        {
            try 
            {
                var cars = _carDAL.GetAllAsync().Result; // Assuming GetAllAsync returns Task<IEnumerable<Car>>
                return Task.FromResult(cars.Select(car => new CarOptionsDTO
                {
                    CarId = car.CarId,
                    CarName = car.CarModel
                }));
            }
            catch (Exception ex)
            {
                // Handle exceptions as needed
                throw new Exception("Error retrieving car options", ex);
            }
        }
    }
}