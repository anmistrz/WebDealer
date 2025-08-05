using System;
using DealerApi.Entities.Models;

namespace DealerApi.DAL.Interfaces;

public interface ICustomer : ICrud<Customer>
{
    Task<IEnumerable<Customer>> GetBySearchAsync(string searchTerm);

}
