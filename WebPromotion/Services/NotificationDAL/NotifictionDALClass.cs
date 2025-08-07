using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPromotion.Models;

namespace WebPromotion.DAL.NotificationDAL
{
    public class NotifictionDALClass : INotification
    {
        public Task<Notification> CreateAsync(Notification entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Notification>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Notification> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Notification> UpdateAsync(Notification entity)
        {
            throw new NotImplementedException();
        }
    }
}