using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPromotion.Services.DTO;
using WebPromotion.Models;

namespace WebPromotion.Services.DealerCar
{
    public interface IDealerCarServices : ICrud<IDealerCarServices>
    {
        public Task<IEnumerable<DealerCarUnitOptionsDTO>> GetOptionsDealerCarUnitByStatusAsync(string status);
    }
}