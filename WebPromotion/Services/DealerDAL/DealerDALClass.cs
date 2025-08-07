using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPromotion.Models;

namespace WebPromotion.DAL.DealerDAL
{

    public class DealerDALClass : IDealer
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

        public Dealer GetBySearch(string criteria)
        {
            throw new NotImplementedException();
        }

        public Task<Dealer> UpdateAsync(Dealer entity)
        {
            throw new NotImplementedException();
        }
    }
}