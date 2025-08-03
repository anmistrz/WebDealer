using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPromotion.Models;
using WebPromotion.ViewModels.ConsultHistoryView;

namespace WebPromotion.BL.ConsultHistoryBL
{
    public interface IConsultHistoryBL
    {
        public ConsultHistoryInsertGuestViewModels InsertConsultHistoryGuest(ConsultHistoryInsertGuestViewModels model);

        public ConsultHistoryInsertViewModels InsertConsultHistory(ConsultHistoryInsertViewModels model);
        public ConsultHistoryUpdateViewModels UpdateConsultHistory(ConsultHistoryUpdateViewModels model);
        public ConsultHistoryViewModels GetConsultHistoryById(int id);  
        public void Delete(int id);
        public IEnumerable<ConsultHistoryViewModels> GetAllConsultHistories();
    }
}