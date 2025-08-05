using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DealerApi.DAL.Interfaces;
using DealerApi.Entities.Models;

namespace ClassLibrary.DAL
{
    public class CustomerDAL : ICustomer
    {
        public Task<Customer> CreateAsync(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> GetBySearchAsync(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> UpdateAsync(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}