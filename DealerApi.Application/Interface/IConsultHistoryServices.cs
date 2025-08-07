using System;
using DealerApi.Application.DTO;
using DealerApi.Entities.Models;

namespace DealerApi.Application.Interface;

public interface IConsultHistoryServices
{
    Task<SuccessInsertUpdateDTO> CreateAsyncConsultHistoryGuest(Customer dataCustomer, ConsultHistory dataConsultHistory, DealerCar dataDealerCar);

}
