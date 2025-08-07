using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DealerApi.DAL.Interfaces;
using DealerApi.Entities.Models;

namespace ClassLibrary.DAL.Interfaces
{
    public interface IDealerCar : ICrud<DealerCarUnit>
    {
        public Task<IEnumerable<(Dealer, Car, DealerCarUnit)>> GetOptionsDealerCarUnitByStatusAsync(string status);
    }
}