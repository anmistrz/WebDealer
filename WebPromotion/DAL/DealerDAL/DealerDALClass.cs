using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPromotion.Models;

namespace WebPromotion.DAL.DealerDAL
{
    
    public class DealerDALClass : IDealer
    {
        private readonly DBPromotionExerciseContext _context;

        public DealerDALClass(DBPromotionExerciseContext context)
        {
            _context = context;
        }


        public Dealer Create(Dealer entity)
        {
            try
            {
                _context.Dealers.Add(entity);
                _context.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log them)
                throw new Exception("Error creating dealer", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var dealer = _context.Dealers.Find(id);
                if (dealer != null)
                {
                    _context.Dealers.Remove(dealer);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log them)
                throw new Exception("Error deleting dealer", ex);
            }
        }

        public IEnumerable<Dealer> GetAll()
        {
            try
            {
                return _context.Dealers.ToList();
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log them)
                throw new Exception("Error retrieving all dealers", ex);
            }
        }

        public Dealer GetById(int id)
        {
            try
            {
                return _context.Dealers.Find(id);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log them)
                throw new Exception("Error retrieving dealer by ID", ex);
            }
        }

        public Dealer GetBySearch(string criteria)
        {
            throw new NotImplementedException();
        }

        public Dealer Update(Dealer entity)
        {
            try
            {
                _context.Dealers.Update(entity);
                _context.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log them)
                throw new Exception("Error updating dealer", ex);
            }
        }
    }
}