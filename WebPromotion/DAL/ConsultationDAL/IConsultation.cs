using WebPromotion.Models;
using WebPromotion.ViewModels.ConsultHistoryView;

namespace WebPromotion.DAL.ConsultationDAL
{
    public interface IConsultation : ICrud<ConsultHistory>
    {
        public Task<ConsultHistory> CreateAsyncConsultHistoryGuest(ConsultHistoryInsertGuestViewModels model);
    }
}
