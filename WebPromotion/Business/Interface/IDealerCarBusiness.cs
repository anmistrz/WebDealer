using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPromotion.Services.DTO;

namespace WebPromotion.Business
{
    public interface IDealerCarBusiness
    {
        public IEnumerable<List<DealerCarUnitOptionsDTO>> GetOptionsDealerCarUnitByStatus(string status);
    }
}