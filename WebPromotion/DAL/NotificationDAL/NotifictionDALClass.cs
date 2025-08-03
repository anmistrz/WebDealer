using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPromotion.Models;

namespace WebPromotion.DAL.NotificationDAL
{
    public class NotifictionDALClass : INotification
    {
        private readonly DBPromotionExerciseContext _context;

        public NotifictionDALClass(DBPromotionExerciseContext context)
        {
            _context = context;
        }


        public Notification Create(Notification entity)
        {
            try
            {
                _context.Notifications.Add(entity);
                _context.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log them)
                throw new Exception("Error creating notification", ex);
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Notification> GetAll()
        {
            throw new NotImplementedException();
        }

        public Notification GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Notification Update(Notification entity)
        {
            throw new NotImplementedException();
        }
    }
}