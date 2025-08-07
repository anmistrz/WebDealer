using ClassLibrary.DAL.Interfaces;
using DealerApi.DAL.Context;
using DealerApi.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary.DAL
{
    public class DealerDAL : IDealer
    {
        private readonly DealerRndDBContext _context;
        public DealerDAL(DealerRndDBContext context)
        {
            _context = context;
        }


        public Task<Dealer> CreateAsync(Dealer entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Dealer>> GetAllAsync()
        {
            try
            {
                return await _context.Dealers.ToListAsync();
            }
            catch (Exception ex)
            {
                // Handle exceptions as needed
                throw new Exception("Error retrieving dealers", ex);
            }
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