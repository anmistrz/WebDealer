using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DealerApi.Application.DTO
{
    public class DealerCarOptionsDTO
    {
        public List<DealerOptionsDTO> Dealers { get; set; }
        public List<CarOptionsDTO> Cars { get; set; }

        public List<DealerCarUnitOnlyIdDTO> DealerCarUnits { get; set; } = new List<DealerCarUnitOnlyIdDTO>();
    }
}