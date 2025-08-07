using WebPromotion.Models;
using WebPromotion.Services.DTO;
using WebPromotion.ViewModels.ConsultHistoryView;

namespace WebPromotion.Services.Consultation
{
    public interface IConsultationServices
    {
        public Task<ConsultHistory> CreateAsyncConsultHistoryGuest(ConsultationInsertGuestDTO model);
    }
}
