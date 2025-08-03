using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebPromotion.Models;

namespace WebPromotion.BL.DealerBL
{
    public interface IDealerBL
    {
        public Dealer InsertDealer(Dealer dealer);
        public Dealer UpdateDealer(Dealer dealer);
        public void DeleteDealer(int id);
        public Dealer GetDealerById(int id);
        public IEnumerable<Dealer> GetAllDealers();
        public List<SelectListItem> GetoptionsDealers();
        
    }
}