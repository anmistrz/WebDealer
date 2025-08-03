using WebPromotion.Models;

namespace WebPromotion.DAL.CarDAL
{
    public class CarDALClass : ICar
    {
        private readonly DBPromotionExerciseContext _context;

        public CarDALClass(DBPromotionExerciseContext context)
        {
            _context = context;
        }


        public Car Create(Car entity)
        {
            try
            {
                _context.Cars.Add(entity);
                _context.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                throw new Exception("An error occurred while creating the car.", ex);
            }
        }

        public void Delete(int id)
        {
            try 
            {
                var car = _context.Cars.Find(id);
                if (car == null)
                {
                    throw new KeyNotFoundException("Car not found.");
                }
                _context.Cars.Remove(car);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                throw new Exception("An error occurred while deleting the car.", ex);
            }
        }

        public IEnumerable<Car> GetAll()
        {
            try
            {
                return _context.Cars.ToList();
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                throw new Exception("An error occurred while retrieving all cars.", ex);
            }
        }

        public Car GetById(int id)
        {
            try 
            {
                var car = _context.Cars.Find(id);
                if (car == null)
                {
                    throw new KeyNotFoundException("Car not found.");
                }
                return car;
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                throw new Exception("An error occurred while retrieving the car by ID.", ex);
            }
        }

        public Car Update(Car entity)
        {
            try 
            {
                var existingCar = _context.Cars.Find(entity.CarId);
                if (existingCar == null)
                {
                    throw new KeyNotFoundException("Car not found.");
                }
                // Update properties
                existingCar.Make = entity.Make;
                existingCar.CarModel = entity.CarModel;
                existingCar.CarType = entity.CarType;
                existingCar.Year = entity.Year;
                existingCar.EngineSize = entity.EngineSize;
                existingCar.FuelType = entity.FuelType;
                existingCar.Transmission = entity.Transmission;
                existingCar.Color = entity.Color;
                existingCar.BasePrice = entity.BasePrice;
                existingCar.Description = entity.Description;
                _context.SaveChanges();
                return existingCar;
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                throw new Exception("An error occurred while updating the car.", ex);
            }
        }
    }
}
