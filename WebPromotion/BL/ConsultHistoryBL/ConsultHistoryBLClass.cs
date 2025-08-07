using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebPromotion.Services.Consultation;
using WebPromotion.DAL.CustomerDAL;
using WebPromotion.Models;
using WebPromotion.ViewModels.ConsultHistoryView;

namespace WebPromotion.BL.ConsultHistoryBL
{
    public class ConsultHistoryBLClass : IConsultHistoryBL
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ConsultHistoryViewModels> GetAllConsultHistories()
        {
            throw new NotImplementedException();
        }

        public ConsultHistoryViewModels GetConsultHistoryById(int id)
        {
            throw new NotImplementedException();
        }

        public ConsultHistoryInsertViewModels InsertConsultHistory(ConsultHistoryInsertViewModels model)
        {
            throw new NotImplementedException();
        }

        public ConsultHistoryInsertGuestViewModels InsertConsultHistoryGuest(ConsultHistoryInsertGuestViewModels model)
        {
            throw new NotImplementedException();
        }

        public ConsultHistoryUpdateViewModels UpdateConsultHistory(ConsultHistoryUpdateViewModels model)
        {
            throw new NotImplementedException();
        }
    }


}