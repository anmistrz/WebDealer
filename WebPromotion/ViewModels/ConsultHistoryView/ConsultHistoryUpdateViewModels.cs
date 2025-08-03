using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPromotion.ViewModels.ConsultHistoryView
{
    public class ConsultHistoryUpdateViewModels
    {
        public int ConsultHistoryId { get; set; }
        public int CustomerId { get; set; }

        public int DealerId { get; set; }

        public int SalesPersonId { get; set; }

        public decimal? Budget { get; set; }

        public DateTime ConsultDate { get; set; }

        public string Note { get; set; }
    }
}