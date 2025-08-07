using DealerApi.DAL.Interfaces;
using WebPromotion.Models;

namespace WebPromotion.DAL.DealerDAL
{
    public interface IDealer : ICrud<Dealer>
    {
        // Additional methods specific to Dealer can be added here
        // For example, methods to get dealers by specific criteria
        Dealer GetBySearch(string criteria);
    }
}
