using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebPromotion.DAL.DealerDAL;
using WebPromotion.Models;

namespace WebPromotion.BL.DealerBL
{
    public class DealerBLClass : IDealerBL
    {
        private readonly IDealer _dealerDAL;

        public DealerBLClass(IDealer dealerDAL)
        {
            _dealerDAL = dealerDAL;
        }

        public void DeleteDealer(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Dealer> GetAllDealers()
        {
            throw new NotImplementedException();
        }

        public Dealer GetDealerById(int id)
        {
            throw new NotImplementedException();
        }

        public List<SelectListItem> GetoptionsDealers()
        {
            var dealers = _dealerDAL.GetAll();
            return dealers.Select(d => new SelectListItem
            {
                Value = d.DealerId.ToString(),
                Text = "" + d.DealerName + " (" + d.Location +  " - " + d.City + ")"
            }).ToList();
        }

        public Dealer InsertDealer(Dealer dealer)
        {
            throw new NotImplementedException();
        }

        public Dealer UpdateDealer(Dealer dealer)
        {
            throw new NotImplementedException();
        }
    }
}