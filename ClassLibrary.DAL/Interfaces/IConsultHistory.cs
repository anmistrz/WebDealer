using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DealerApi.DAL.Interfaces;
using DealerApi.Entities.Models;

namespace DealerApi.DAL.Interfaces
{
    // Ensure the correct namespace for ConsultHistoryGuestDTO is used
    public interface IConsultHistory : ICrud<ConsultHistory>
    {
        public Task<ConsultHistory> CreateConsultHistoryGuestAsync(Customer dataCustomer, ConsultHistory consultHistory, DealerCar dataDealerCar);
    }
}