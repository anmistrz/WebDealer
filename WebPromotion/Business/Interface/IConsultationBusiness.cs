using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPromotion.Models;
using WebPromotion.Services.DTO;

namespace WebPromotion.Business.Interface
{
    public interface IConsultationBusiness
    {
        public Task<ConsultHistory> CreateConsultHistoryGuest(ConsultationInsertGuestDTO consultation);
    }
}