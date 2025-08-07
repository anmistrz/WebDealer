using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebPromotion.Models;
using WebPromotion.ViewModels.ConsultHistoryView;

namespace WebPromotion.Services.Consultation
{
    public class ConsultationServices : IConsultationServices
    {
        public ConsultHistory Create(ConsultHistory entity)
        {
            throw new NotImplementedException();
        }

        public Task<ConsultHistory> CreateAsyncConsultHistoryGuest(ConsultHistoryInsertGuestViewModels model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ConsultHistory> GetAll()
        {
            throw new NotImplementedException();
        }

        public ConsultHistory GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ConsultHistory Update(ConsultHistory entity)
        {
            throw new NotImplementedException();
        }
    }
}