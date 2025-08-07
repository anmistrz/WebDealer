using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPromotion.Services.DTO
{
    public class DealerCarUnitOptionsDTO
    {
        public List<DealerOptionsDTO> Dealers { get; set; }
        public List<CarOptionsDTO> Cars { get; set; }
        public List<DealerCarUnitDTO> DealerCarUnits { get; set; }
    }
}