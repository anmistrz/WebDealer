using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPromotion.Business.Interface;
using WebPromotion.Models;
using WebPromotion.Services.Consultation;
using WebPromotion.Services.DTO;

namespace WebPromotion.Business
{
    public class ConsultationBusiness : IConsultationBusiness
    {
        public readonly IConsultationServices _consultationServices;

        public ConsultationBusiness(IConsultationServices consultationServices)
        {
            _consultationServices = consultationServices;
        }

        public Task<ConsultHistory> CreateConsultHistoryGuest(ConsultationInsertGuestDTO consultation)
        {
            try 
            {
                return _consultationServices.CreateAsyncConsultHistoryGuest(consultation);
            }
            catch (Exception ex)
            {
                // Handle exceptions as needed, e.g., logging
                throw new Exception("An error occurred while creating consultation history.", ex);
            }
        }
    }
}