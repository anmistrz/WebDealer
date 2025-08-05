using ClassLibrary.DAL.Interfaces;
using DealerApi.Application.DTO;
using DealerApi.Application.Interface;
using DealerApi.DAL;
using DealerApi.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerApi.Application
{
    public class DealerServices : IDealerService
    {
        private readonly IDealer _dealerDAL;

        public DealerServices (IDealer dealerDAL)
        {
            _dealerDAL = dealerDAL;
        }

        public Task<IEnumerable<DealerOptionsDTO>> GetDealerOptions()
        {
            try
            {
                var cars = _dealerDAL.GetAllAsync().Result; // Assuming GetAllAsync returns Task<IEnumerable<Car>>
                return Task.FromResult(cars.Select(car => new DealerOptionsDTO
                {
                    DealerID = car.DealerId,
                    DealerName = car.DealerName
                }));
            }
            catch (Exception ex)
            {
                // Handle exceptions as needed
                throw new Exception("Error retrieving dealer options", ex);
            }
        }
    }
}
