using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPromotion.Models;
using WebPromotion.Services;

namespace WebPromotion.DAL.CustomerDAL
{
    public interface ICustomer : ICrud<Customer>
    {
        public Customer GetByName(string FirstName, string LastName);
    }
}