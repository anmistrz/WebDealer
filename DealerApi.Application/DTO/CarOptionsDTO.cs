using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DealerApi.Application.DTO
{
    public class CarOptionsDTO
    {
        public int CarId { get; set; }
        public int DealerCarUnitId { get; set; }
        public string CarName { get; set; }
    }
}