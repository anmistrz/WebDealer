using WebPromotion.Models;
using WebPromotion.ViewModels.ConsultHistoryView;

namespace WebPromotion.Services.Consultation
{
    public interface IConsultationServices : ICrud<ConsultHistory>
    {
        public Task<ConsultHistory> CreateAsyncConsultHistoryGuest(ConsultHistoryInsertGuestViewModels model);
    }
}
