using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.DAL.Interfaces;
using DealerApi.Entities.Models;

namespace ClassLibrary.DAL
{
    public class DealerDAL : IDealer
    {
        public Task<Dealer> CreateAsync(Dealer entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Dealer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Dealer> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Dealer>> GetBySearchAsync(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public Task<Dealer> UpdateAsync(Dealer entity)
        {
            throw new NotImplementedException();
        }
    }
}