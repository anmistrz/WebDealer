using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPromotion.Models;

namespace WebPromotion.DAL.CustomerDAL
{
    public class CustomerDALClass : ICustomer
    {
        private readonly DBPromotionExerciseContext _context;

        public CustomerDALClass(DBPromotionExerciseContext context)
        {
            _context = context;
        }


        public Customer Create(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int id)
        {
            try
            {
                return _context.Customers.Find(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving customer by ID", ex);
            }
        }

        public Customer GetByName(string FirstName, string LastName)
        {
            try
            {
                return _context.Customers.FirstOrDefault(c => c.FirstName.Equals(FirstName, StringComparison.OrdinalIgnoreCase) &&
                        c.LastName.Equals(LastName, StringComparison.OrdinalIgnoreCase));
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving customer by name", ex);
            }
        }

        public Customer Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}